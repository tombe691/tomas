#include <stdio.h>
#include <stdlib.h>

#define PNAMN_LANGD 30
struct person {
    char fornamn[PNAMN_LANGD];
    char efternamn[PNAMN_LANGD];
    int fodd_ar;
    struct person *partner;
    struct list *barn;
};

struct node {
    struct node *next, *prev;
    void *data;
};

struct list {
    struct node *start, *current;
    int n, index;
};

static struct node *new_node(void *d) {
    struct node *p = malloc(sizeof (struct node));
    *p = (struct node) {NULL, NULL, d};
    return p;
}

struct list *new_list(void) {
  struct node *p = new_node(NULL); 
  p->next = p; p->prev = p;    // startnoden pekar på sig själv
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

void partners(struct person *pp1, struct person *pp2) {
    pp1->partner = pp2;
    pp2->partner = pp1;
}

void nytt_barn(struct person *pp, struct person *pbarn) {
    add_last(pp->barn, pbarn);
    //pp->barn[pp->antal_barn++] = pbarn;
}

int size(struct list *l) {
    return l->n;
}

/*int antal_barn(struct person *pp) {
    return size(pp->barn);
}

void skriv_person(struct person *pp) {
    if (pp->antal_barn > 0) {
        printf("Har barnen:\n");
        for (int i=0; i < pp->antal_barn; i++) {
            printf("%s\n", pp->barn[i]->fornamn);
        }
    }
    else {
        printf("Har inga barn:\n");
    }
}
*/
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

void skriv_barn(struct person *pp) {
    for (int i=0; i<size(pp->barn); i++)
        printf("%s\n", (char *) get(pp->barn, i));
}

void main()
{
  struct person p1 = {"Anders", "Lund", 1968, NULL, new_list()};
  struct person p2 = {"Eva", "Johansson", 1970, NULL, new_list()}; 
  struct person p3 = {"Ida", "Lund", 2001, NULL, new_list()};
  struct person p4 = {"Oscar", "Lund", 2003, NULL, new_list()};
  struct person p5 = {"Lina", "Johansson", 2004, NULL, new_list()};
  nytt_barn(&p1, &p3);
  nytt_barn(&p1, &p4);
  nytt_barn(&p2, &p5);
  skriv_barn(&p1);
  printf("\n");
  skriv_barn(&p2);
}
