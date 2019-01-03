/*C program to demonstrate example of void pointer*/

#include <stdio.h>

int main(){
	void *voidPointer;
	int a=10;
	float b=1.234f;
	char c='x';
	
	voidPointer=&a;
	printf("value of a: %d\n",*(int*)voidPointer);
	
	voidPointer=&b;
	printf("value of b: %f\n",*(float*)voidPointer);
	
	voidPointer=&c;
	printf("value of c: %c\n",*(char*)voidPointer);
	
	return 0;	
}
