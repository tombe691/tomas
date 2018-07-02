
#include<stdio.h>

int main()
{

int arr[] = {10, 20, 30, 40, 50, 60};
int *ptr1 = arr;
printf("1 %d \n", (ptr1)); 
printf("2 %d \n", (&ptr1)); 
printf("3 %d \n", (*ptr1)); 
int *ptr2 = arr + 3;
printf("4 %d \n", (ptr2));
printf("5 %d \n", (ptr2 - ptr1) ); 

}