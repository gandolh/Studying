#include <stdio.h>

int main(void){
	int x = 4;
	int *my_ptr = &x;
	int **my_d_ptr = & my_ptr;
	printf("x=%d, my_ptr=%p\n", x,my_ptr);
	printf("*my_ptr=%d\n", * my_ptr);
	printf("my_d_ptr=%p\n", my_d_ptr);
	printf("*my_d_ptr=%p\n", *my_d_ptr);
	printf("**my_d_ptr=%d\n", **my_d_ptr);
	return 0;
}
