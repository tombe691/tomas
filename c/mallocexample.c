/*
https://www.programiz.com/c-programming/c-dynamic-memory-allocation
*/

#include <stdio.h>
#include <stdlib.h>

int main()
{
  int input;
  scanf("%d", &input);
  int output = ((input >= 0) ? 1 : 2);
  printf("output is %d\n", output);

  int num, i, *ptr, sum = 0;
    printf("Enter number of elements: ");
    scanf("%d", &num);

    ptr = (int*) malloc(num * sizeof(int));  //memory allocated using malloc
    if(ptr == NULL)                     
    {
        printf("Error! memory not allocated.");
        exit(0);
    }

    printf("Enter elements of array: ");
    for(i = 0; i < num; ++i)
    {
        scanf("%d", ptr + i);
        sum += *(ptr + i);
    }

    printf("Sum = %d", sum);
    free(ptr);
    return 0;
}
