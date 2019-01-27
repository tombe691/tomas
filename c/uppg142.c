#include <stdio.h>
#include <stdlib.h>
//#include "list.h"

struct node {
  struct node *next, *prev;
  void *data;
};

struct list {
  struct node *start, *current;
  int n, index; 
};

static void goto_position(struct list *l, int i) {
  if (i != l->index) {
	if (i > l->index && i < l->n) {
      for (; l->index < i; l->index++)
         l->current = l->current->next; 
    }
	else if (i < l->index && i >= 0) {
      for (; l->index > i; l->index--)
         l->current = l->current->prev; 
    }
    else {
	  l->current = l->start;
	  l->index = -1;
	}
  }
}

void *get(struct list *l, int i) {
  goto_position(l, i);
  return l->current->data;
}

int size(struct list *l) {
  return l->n;
}

_Bool ar_sorterat(struct list *l) {
  for (int i=1; i < size(l); i++) {
	double *d1 = get(l, i), *d2 = get(l, i-1);
    if (*d1 < *d2) 
      return 0;
  }
  return 1;
}

static struct node *new_node(void *d) {
  struct node *p = malloc(sizeof (struct node));
  *p = (struct node) {NULL, NULL, d};
  return p;
}    

struct list *new_list(void) {
  struct node *p = new_node(NULL); 
  p->next = p; p->prev = p;    // startnoden pekar pÃ¥ sig sjÃ¤lv
  struct list *l = malloc(sizeof (struct list));
  *l = (struct list) {p, p, 0, -1};
  return l;
}

static void insert_before(struct list *l, struct node *p, void *new_elem) { 
  struct node *pnew = new_node(new_elem); 
  pnew->next = p;
  pnew->prev = p->prev;
  p->prev->next = pnew;
  p->prev = pnew;
  l->n++; 
  l->current = pnew;
}

void add_last(struct list *l, void *new_elem) {
  insert_before(l, l->start, new_elem);
  l->index = l->n - 1;
}

int main() {
  struct list *ld = new_list();
  double tal;
  while ((scanf("%lf", &tal) == 1)) {
    double *pd = malloc(sizeof (double));
    *pd = tal;
    add_last(ld, pd);
  } 
  if (ar_sorterat(ld))
    printf("Listan är sorterad");
  else
    printf("Listan är inte sorterad");
}  
    
      
