/*
 * C program to create a linked list and display the elements in the list
 */
#include <stdio.h>
#include <malloc.h>
#include <stdlib.h>
 
void main()
{
    struct node
    {
      int num;
      char firstName[50];
      struct node *ptr;
    };
    typedef struct node NODE;
 
    NODE *head, *first, *temp = 0;
    int count = 0;
    int choice = 1;
    first = 0;
 
    while (choice)
    {
        head  = (NODE *)malloc(sizeof(NODE));
	printf("Enter the first name to insert : \n");
	scanf("%s", &head-> firstName);
        printf("Enter the data item\n");
        scanf("%d", &head-> num);
        if (first != 0)
        {
	  printf("in if (first not 0)\n");
            temp->ptr = head;
            temp = head;
        }
        else
        {
	  printf("in else no previous record\n");
            first = temp = head;
        }
        fflush(stdin);
        printf("Do you want to continue(Type 0 or 1)?\n");
        scanf("%d", &choice);
 
    }
    temp->ptr = 0;
    /*  reset temp to the beginning */
    temp = first;
    printf("\n status of the linked list is\n");
    while (temp != 0)
    {
        printf("%d=>", temp->num);
        printf("%s=>", temp->firstName);
        count++;
        temp = temp -> ptr;
    }
    printf("NULL\n");
    printf("No. of nodes in the list = %d\n", count);
}
