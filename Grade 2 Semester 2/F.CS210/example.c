#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>

#define MAX_LINE 80
#define EXIT_SUCCESS 0
#define TRUE 1
#define FALSE 0

void setup(char inputBuffer[], char *args[], int *background)
{
}

int main(void)
{
    char inputBuffer[MAX_LINE];
    int background;
    char *args[MAX_LINE / +1];

    while (TRUE)
    {
        background = FALSE;

        printf("COMMAND->");
        setup(inputBuffer, args, &background);

        /* алхмууд:
        (1) fork()-г хэрэглэх хүү процес үүсгэх
        (2) хүү процес нь execvp() функцийг дуудна
        (3) хэрэв background == 0 бол эцэг процес хүлээнэ,
        үгүй бол setup() функцийг дахин дуудна. */
    }

    return EXIT_SUCCESS;
}