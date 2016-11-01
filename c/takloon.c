#include <stdio.h>
#include <string.h>
#include <locale.h>
#include <stdlib.h>

typedef struct my_object {
	int my_int;
	
	struct my_object *next;
} obj;


void change(int *digit) {
	
	*digit = 3; //deref på pekaren sen tilldela 3
}	

void change_inobj(obj *o) {
	o->my_int = 6;
}


int main(void) {
		
	int a = 1;
	change(&a);
	printf("%d", a);
	
	obj *nr = (obj*)malloc(sizeof(obj));	
	nr->my_int = 2;
	nr->next = NULL;
	
	change_inobj(nr);
	printf("\n%d", nr->my_int);
	
	
	return 0;
}
