#include <stdio.h>

#define PNAMN_LANGD 30
struct person {
  char fornamn[PNAMN_LANGD];
  char efternamn[PNAMN_LANGD];
  int fodd_ar;
  struct person *partner;
  struct person *barn[20];
  int antal_barn;
};

void partners(struct person *pp1, struct person *pp2) {
  pp1->partner = pp2;
  pp2->partner = pp1;
}

void nytt_barn(struct person *pp, struct person *pbarn) {
  pp->barn[pp->antal_barn++] = pbarn;
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

void main()
{
  struct person p1 = {"Nisse", "Hult", 1970, NULL};
  struct person p2 = {"Anna", "Hult", 1972, NULL};
  struct person p3 = {"Ida", "Lund", 2001, NULL};
  struct person p4 = {"Oscar", "Lund", 2003, NULL};

  partners(&p1, &p2);
  nytt_barn(&p1, &p3);
  nytt_barn(&p1, &p4);
  skriv_person(&p1);
}
