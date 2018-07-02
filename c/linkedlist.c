#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int main()
{
  struct stock {
    char symbol[5];
    struct stock *next;
  };

  struct stock *first;
  struct stock *current;
  struct stock *current1;
  struct stock *current2;
  struct stock *current3;
  struct stock *temp;
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
  current->next=NULL;

  new=(struct stock *)malloc(sizeof(struct stock));
  if(new==NULL)
    {
      puts("Another malloc() error");
      exit(1);
    }
  current->next=new;
  current1=new;
  strcpy(current1->symbol,"MSFT");
  current1->next=NULL;

  new=(struct stock *)malloc(sizeof(struct stock));
  if(new==NULL)
    {
      puts("Another malloc() error");
      exit(1);
    }
  current1->next=new;
  current2=new;
  strcpy(current2->symbol,"AMAZ");
  current2->next=NULL;

  new=(struct stock *)malloc(sizeof(struct stock));
  if(new==NULL)
    {
      puts("Another malloc() error");
      exit(1);
    }
  current2->next=new;
  current3=new;
  strcpy(current3->symbol,"TESL");
  current3->next=NULL;

  /* Display database */
  puts("Investment Portfolio");
  printf("Symbol\n"); 
  current=first;
  printf("%-6s\n", current->symbol); //goog
  current=current->next;
  printf("%-6s\n", current->symbol); //msft
  current=current1->next;
  printf("%-6s\n", current->symbol); //amaz
  current=current2->next;
  printf("%-6s\n", current->symbol); //tesl

  current3->next=first;

  /* Display database */
  puts("Investment Portfolio");
  printf("Symbol\n");
  current=first;
  printf("%-6s\n",
	 current->symbol);
  current=current->next;
  printf("%-6s\n",
	 current->symbol);
  current=current1->next;
  printf("%-6s\n",
	 current->symbol);
  current=current2->next;
  printf("%-6s\n",
	 current->symbol);
  current=current3->next;
  printf("%-6s\n",
	 current->symbol);
  
  return(0);
}
