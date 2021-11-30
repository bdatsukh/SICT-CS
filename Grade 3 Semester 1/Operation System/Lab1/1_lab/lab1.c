#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>
#include <string.h>
#include <sys/wait.h>
#include <signal.h>
#include <errno.h>

#define TRUE 1
#define FALSE 0

#define MAX_BUFFER_LENGTH 80
#define MAX_COMMANDS 10

#define EXIT_EXECVPERROR -2

#define RUN 1;
#define DONT_RUN 0

char history[MAX_COMMANDS][MAX_BUFFER_LENGTH];
int command_counter = 0;

void showHistory();
void addToHistory(char[], int);
int setup(char[], char *[], int *);

void handler_SIGINT(int);

void mainLoop();

int main()
{
	struct sigaction handler;

	handler.sa_handler = handler_SIGINT;
	handler.sa_flags = SA_RESTART;
	sigemptyset(&handler.sa_mask);

	if (sigaction(SIGINT, &handler, NULL) < 0)
	{
		perror("error in sigaction");
		return EXIT_FAILURE;
	}

	mainLoop();

	return EXIT_SUCCESS;
}

void mainLoop()
{
	pid_t child;

	char inputBuffer[MAX_BUFFER_LENGTH];
	int background;
	char *args[MAX_BUFFER_LENGTH / 2 + 1];
	int shouldrun = RUN;

	while (TRUE)
	{
		background = FALSE;

		shouldrun = setup(inputBuffer, args, &background);

		if (strncmp(inputBuffer, "exit", 4) == 0)
			exit(EXIT_SUCCESS);
		else if (strncmp(inputBuffer, "history", 7) == 0)
		{
			showHistory();

			continue;
		}

		if (shouldrun)
		{
			child = fork();

			switch (child)
			{
			case -1:
				perror("Cannot able to fork child");
				break;

			case 0:
				if (execvp(args[0], args) != 0)
				{
					perror("error in execvp");
					exit(EXIT_EXECVPERROR);
				}
				break;

			default:
				if (background == FALSE)
					while (child != wait(NULL))
						;

				break;
			}
		}
	}
}

void showHistory()
{
	for (int i = 0; i < command_counter; i++)
	{
		char buffer[MAX_BUFFER_LENGTH];
		int len = sprintf(buffer, "%d \t %s\n\0", i, history[i]);
		write(STDOUT_FILENO, buffer, len);
	}
}

void addToHistory(char inputBuffer[], int length)
{
	if (command_counter == MAX_COMMANDS)
	{
		for (int i = 0; i < MAX_COMMANDS - 1; i++)
			strncpy(history[i], history[i + 1], strlen(history[i + 1]) + 1);

		command_counter--;
	}

	strncpy(history[command_counter], inputBuffer, length - 1);
	history[command_counter][length - 1] = '\0';

	if (command_counter < MAX_COMMANDS)
		command_counter++;
}

int setup(char inputBuffer[], char *args[], int *background)
{
	int length;

	do
	{
		printf("COMMANDS->");
		fflush(stdout);
		length = read(STDIN_FILENO, inputBuffer, MAX_BUFFER_LENGTH);
	} while (inputBuffer[0] == '\n');

	if (length <= 0)
		exit(EXIT_SUCCESS);

	if (inputBuffer[0] == 'r')
	{
		if (command_counter == 0)
			printf("There is no history");
		else if (inputBuffer[1] == '\n')
		{
			length = strlen(history[command_counter - 1]) + 1;
			strncpy(inputBuffer, history[command_counter - 1], length);
			inputBuffer[length] = '\n';
		}
		else if (inputBuffer[3] == '\n')
		{
			int found = FALSE;

			for (int i = command_counter - 1; i >= 0; i--)
			{
				if (history[i][0] == inputBuffer[2])
				{
					length = strlen(history[i]) + 1;
					strncpy(inputBuffer, history[i], length);
					inputBuffer[length] = '\n';
					found = TRUE;

					break;
				}
			}

			if (!found)
			{
				fprintf(stdout, "error in history: '%c' is not exist\n", inputBuffer[2]);

				return DONT_RUN;
			}
		}
	}

	addToHistory(inputBuffer, length);

	int start = -1;
	int counter = 0;

	for (int i = 0; i <= length; i++)
	{
		switch (inputBuffer[i])
		{
		case ' ':
		case '\t':
			if (start != -1)
				args[counter++] = &inputBuffer[start];

			inputBuffer[i] = '\0';
			start = -1;
			break;

		case '\n':
			if (start != -1)
				args[counter++] = &inputBuffer[start];

			inputBuffer[i] = '\0';
			args[counter] = NULL;
			break;

		default:
			if (start == -1)
				start = i;

			if (inputBuffer[i] == '&')
			{
				*background = TRUE;
				inputBuffer[i - 1] = '\0';
			}
			break;
		}
	}

	if (*background)
		args[--counter] = NULL;

	return RUN;
}

void handler_SIGINT(int signum)
{
	write(STDOUT_FILENO, "\n", 1);
	showHistory();
}