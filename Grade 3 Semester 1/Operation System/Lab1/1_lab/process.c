#include <stdio.h>
#include <curses.h>
#include <math.h>
#include <unistd.h>

#define TRUE 1
#define FALSE 0

#define EXIT_SUCCESS 0
#define EXIT_FAILURE 1
#define EXIT_INITIALIZE 2
#define EXIT_PROCESSING 3

#define INITIALIZE 0

#define TIME_OF_SLEEP 1

const int N = 45;

int fibonacciNumber(const int number)
{
	static unsigned int counter = 0;
	static unsigned long first = 0;
	static unsigned long second = 1;
	
	if(number == 0)
	{
		counter = 0;
		first = 1;
		second = 1;
		
		return EXIT_INITIALIZE;
	}
	else
	{

		if(counter == number)
		{
			printf("Fibonacci process is finished\n");

			counter++;

			return EXIT_SUCCESS;
		}
		else if(counter > number)
		{
			return EXIT_SUCCESS;			
		}
		else
		{
			second += first;
			first = second - first;
			counter++;

			printf("Fibonacci number at %u: %lu\n", counter, second);

			return EXIT_PROCESSING;
		}
	}
}

int isPrimeNumber(const int number)
{
	for(int i = 2; i <= sqrt(number); i++)
		if(number % i == 0)
			return FALSE;

	return TRUE;
}

int primeNumber(const int number)
{
	static unsigned int counter = 0;
	static unsigned long primeNumber = 1;

	if(number <= 0)
	{
		counter = 0;
		primeNumber = 1;

		return EXIT_INITIALIZE;
	}
	else
	{
		if(counter == number)
		{
			printf("Prime number process is finished\n");

			counter++;

			return EXIT_SUCCESS;
		}
		else if(counter > number)
		{
			return EXIT_SUCCESS;
		}
		else
		{
			while(TRUE)
			{
				primeNumber++;

				if(isPrimeNumber(primeNumber))
					break;
			}

			counter++;

			printf("Prime number at %u: %lu\n", counter, primeNumber);
			return EXIT_PROCESSING;
		}	
	}
}

int main(void)
{
	printf("-----------Sequantial-----------\n");
	while(EXIT_SUCCESS != fibonacciNumber(N));
	while(EXIT_SUCCESS != primeNumber(N));

	getch();

	fibonacciNumber(INITIALIZE);
	primeNumber(INITIALIZE);

	printf("-----------Parallel-----------\n");
	while(TRUE)
	{
		int checkFibonacci = fibonacciNumber(N);
		int checkPrime = primeNumber(N);

		if(checkFibonacci == EXIT_SUCCESS && checkPrime  == EXIT_SUCCESS)
			break;
	}

	getch();

	fibonacciNumber(INITIALIZE);
	primeNumber(INITIALIZE);	

	printf("-----------Parallel-----------\n");
	while (TRUE)
	{
		int checkFibonacci = fibonacciNumber(N);
		int checkPrime = primeNumber(N);

		if(checkFibonacci == EXIT_SUCCESS && checkPrime  == EXIT_SUCCESS)
			break;
		
		if(kbhit())
		{
			char mode = getch();

			switch(mode)
			{	
			case '1':
				while (!kbhit())
				{
					checkFibonacci = fibonacciNumber(N);

					sleep(TIME_OF_SLEEP);


					if(checkFibonacci == EXIT_SUCCESS)
						break;
				}
				
				break;
			
			case '2':
				while (!kbhit())
				{
					checkPrime = primeNumber(N);

					sleep(TIME_OF_SLEEP);

					if(checkPrime == EXIT_SUCCESS)
						break;
				}

				break;

			case '3':
				while (TRUE)
				{
					checkFibonacci = fibonacciNumber(N);
				 	checkPrime = primeNumber(N);

					if(checkFibonacci == EXIT_SUCCESS && checkPrime  == EXIT_SUCCESS)
						break;
				}
				

				break;

			default:
				break;
			}
		}

		sleep(TIME_OF_SLEEP);
	}

	return EXIT_SUCCESS;
}