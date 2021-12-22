#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>


int koPlaca = 10;
int field[10] = {2, 3, 3, 4, 6, 7, 3, 2, 5, 6};
int fieldSize = 10;

int flags[2];
int turn;

///*petterson
void enter_critical_section(int i){
	int j = 1 - i;
	flags[i] = 1;
	turn = j;
	while(flags[j] != 0 && turn == j);
}


void leave_critical_section(int i){
	flags[i] = 0;
}


/*Dekkerov
void enter_critical_section(int i){
	int j = 1 - i;
	flags[i] = 1;
	while(flags[j] != 0){
		if(turn == j){
			flags[i] = 0;
			while(turn == j);
			flags[i] = 1;
		}
	}
}


void leave_critical_section(int i){
	flags[i] = 0;
	turn = 1 - i;
}
*/

void BiggestElement(){
	int max = field[0];
	for(int i = 1; i < fieldSize; i++){
		if(max < field[i]){
			max = field[i];
		}
	}
	printf("%d\n", max);
}


void SmallestElement(){
	int min = field[0];
	for(int i = 1; i < 10; i++){
		if(min > field[i]){
			min = field[i];
		}
	}
	printf("%d\n", min);
}



void PrintField(){
	for(int i = 1; i < fieldSize; i++){
		printf("%d ", field[i]);
	}
	printf("\n");
}


void IncreaseAndPrint(){
	koPlaca += 5;
	printf("%d\n", koPlaca);

}


void DecreaseAndPrint(){
	koPlaca -= 3;
	printf("%d\n", koPlaca);
}

int main(void){
	pthread_t thread1, thread2, thread3;
	/*prvi	
	pthread_create(&thread1, NULL, BiggestElement, NULL);
	pthread_create(&thread2, NULL, SmallestElement, NULL);
	pthread_create(&thread3, NULL, PrintField, NULL);

	pthread_join(thread1, NULL);
	pthread_join(thread2, NULL);
	pthread_join(thread3, NULL);
	*/
	///*drugi-treci-cetvrti
	enter_critical_section(0);
	pthread_create(&thread1, NULL, IncreaseAndPrint, NULL);
	pthread_join(thread1, NULL);
	leave_critical_section(0);

	enter_critical_section(1);
	pthread_create(&thread2, NULL, DecreaseAndPrint, NULL);
	pthread_join(thread2, NULL);
	leave_critical_section(1);
	

	
	return 0;
}