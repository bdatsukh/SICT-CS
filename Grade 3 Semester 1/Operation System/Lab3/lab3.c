#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>
#include <unistd.h>
#include "buffer.h"


#define EXIT_SUCCESS 0
#define EXIT_ERROR -1


#define TRUE 1
#define FALSE 0


int insert_item(buffer_item );
int remove_item(buffer_item *);


void * consumer(void *);
void * producer(void *);

void wait(int *);
void signal(int *);

buffer_item buffer[BUFFER_SIZE];
int size = 0;

int mutex = 1;
int full = 0;
int empty = BUFFER_SIZE;

int main(int argc, char *argv[])
{
	srand(time(NULL));

	int duration = atoi(argv[1]);
	int number_producer = atoi(argv[2]);
	int number_consumer = atoi(argv[3]);

	pthread_t ptid[number_producer];
	pthread_t ctid[number_consumer];

	for(int i = 0; i < number_producer; i++)
		pthread_create(&ptid[i], NULL, producer, NULL);

	for(int i = 0; i < number_consumer; i++)
		pthread_create(&ctid[i], NULL, consumer, NULL);

	sleep(duration);

	for(int i = 0; i < number_producer; i++)
		pthread_join(ptid[i], NULL);

	for(int i = 0; i < number_consumer; i++)
		pthread_join(ctid[i], NULL);


	printf("Program exited\n");

	return EXIT_SUCCESS;
}


int insert_item(buffer_item item)
{
	if(size < BUFFER_SIZE)
		buffer[size++] = item;
	else	
		return EXIT_ERROR;

	return EXIT_SUCCESS;
}


int remove_item(buffer_item *item)
{
	wait(empty); // [1 2 3] .................
	wait(&mutex); 1 ....................

	*item = buffer[--size];

	signal(&mutex); 1
	signal(&empty);

	return EXIT_SUCCESS;
}


void * producer(void *param)
{
	buffer_item random_number;
	
	while(TRUE)
	{
		sleep(rand() % 5);

		random_number = rand() % 100;

		if(insert_item(random_number))
			fprintf(stderr, "Producer: Report error condition\n");
		else
			printf("Producer produced %d\n", random_number, size);
	}
}


void * consumer(void *param)
{
	buffer_item random_number;

	while(TRUE)
	{
		sleep(rand() % 5);

		if(remove_item(&random_number))
			fprintf(stderr, "Consumer: Report error condition\n");
		else
			printf("Consumer consumed %d\n", random_number, size);
	}
}


void wait(int *value)
{
	while(*value <= 0);

	*value = *value - 1;
}


void signal(int *value)
{
	*value = *value + 1;
}