#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>

#define M 3
#define N 3
#define K 2

#define NUM_THREADS M * N

struct v
{
	int i;
	int j;
};

int A[M][K] = {{1, 4}, {2, 5}, {3, 6}};
int B[K][N] = {{8, 7, 6}, {5, 4, 3}};
int C[M][N] = {0};

void print();
void *multiply(void *params);

int main()
{
	pthread_t workers[NUM_THREADS];

	int counter_workers = 0;
	for(int i = 0; i < M; i++)
	{
		for(int j = 0; j < N; j++)
		{
			struct v *data = (struct v *)malloc(sizeof(struct v));
			data->i = i;
			data->j = j;

			if(pthread_create(&workers[counter_workers++], NULL, multiply, data) != 0)
			{
				printf("Error in thread");

				exit(-1);
			}
		}
	}

	for(int i = 0; i < NUM_THREADS; i++)
		pthread_join(workers[i], NULL);

	print();

	return EXIT_SUCCESS;
}

void *multiply(void *params)
{
	struct v *data = (struct v *)params;

	for(int p = 0; p < K; p++)
		C[data->i][data->j] += (A[data->i][p] * B[p][data->j]);

	pthread_exit(EXIT_SUCCESS);
}

void print()
{
	for(int i = 0; i < M; i++)
	{
		for(int j = 0; j < N; j++)
			printf("%d ", C[i][j]);

		printf("\n");
	}
}