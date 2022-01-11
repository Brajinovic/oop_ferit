#include <stdio.h>
#include <pthread.h>
#include <semaphore.h>
#include <math.h>


float variable1=10;
float variable2 = 9;

sem_t mutex;

void *firstFunction() {
	while(1){
		//Radi samo ako je variable2>=variable1
		if(variable1 <= variable2){
		sem_wait(&mutex);//uzerpiraj cpu

		variable1 = 3*variable1*variable1 + 4*variable1 - 3;
		variable2 = sqrt(abs(variable2)) - 4;
		printf("Thread1: %.2f %.2f\n", variable1, variable2);
		
		sem_post(&mutex);//oslobodi cpu
		}
	}
	pthread_exit(0);
}


void *secondFunction() {
	while(1){
		//Radi samo ako je variable1>=variable2
		if(variable1 >= variable2){
			sem_wait(&mutex);//zauzmi cpu

			variable1 = sqrt(abs(variable1))-4;
			variable2 = 3*variable2*variable2 + 4*variable2 - 3;
			printf("Thread2: %.2f %.2f\n", variable1, variable2);
			//Obavijesti prvu nit ako je variable2>=variable1
			sem_post(&mutex);
		}
	}
	pthread_exit(0);
}


int main(void) {
	sem_init(&mutex, 1, 1);//mutex slobodan

	pthread_t thread1, thread2;
	pthread_create(&thread1, NULL, firstFunction, NULL);
	pthread_create(&thread2, NULL, secondFunction, NULL);
	pthread_join(thread1, NULL);
	pthread_join(thread2, NULL);
	
	return 0;
}