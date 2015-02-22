#include <pthread.h>
#include <stdio.h>
#include <stdlib.h>

void *run(void *dummyPtr) {
	printf("I am a thread...\n");
	return NULL;
}

int main(int argc, char **argv) {
	printf("Main start...\n");
	pthread_t connector;
	pthread_create(&connector, NULL, run, NULL);
	pthread_join(connector, NULL);
	printf("Main end...\n");
	return 0;
}