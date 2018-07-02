#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int main()
{
  struct stock {
    char symbol[5];
    int quantity;
    struct stock *next;
  };

  struct stock *first;
  struct stock *current;
  struct stock *new;

  /* Create structure in memory */
  first=(struct stock *)malloc(sizeof(struct stock));
  if(first==NULL)
    {
      puts("Some kind of malloc() error");
      exit(1);
    }
  /* Assign structure data */
  current=first;
  strcpy(current->symbol,"GOOG");
  current->quantity=100;
  current->next=NULL;

  new=(struct stock *)malloc(sizeof(struct stock));
  if(new==NULL)
    {
      puts("Another malloc() error");
      exit(1);
    }
  current->next=new;
  current=new;
  strcpy(current->symbol,"MSFT");
  current->quantity=100;
  current->next=NULL;
  

  /* Display database */
  puts("Investment Portfolio");
  printf("Symbol\tShares\tValue\n");
  current=first;
  printf("%-6s\t%5d\t%.2fn\n",
	 current->symbol,
	 current->quantity,
	 current->price,
	 current->quantity*current->price);
  current=current->next;
  printf("%-6s\t%5d\t%.2fn\n",
	 current->symbol,
	 current->quantity,
	 current->price,
	 current->quantity*current->price);
  return(0);
}
