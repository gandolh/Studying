#include <stdio.h>
#include <stdlib.h>
int main(void){
// static array

//	int my_array[5] = {0};
//	for(int i=0;i<5;i++){
//		printf("%d: %d\n", i, my_array[i]);
//	}
//	my_array[1] = 1337;
//	my_array[4] = 4096;

//	for(int i=0;i<5;i++){
//		printf("%d: %d\n", i, my_array[i]);
//	}


// dynamic array
	//5 element int array
	int *my_array = malloc(sizeof(int) * 5);
	for(int i=0;i<5;i++){
              printf("%d: %d\n", i, my_array[i]);
      	}

	return 0;
}
