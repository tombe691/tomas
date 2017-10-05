#include <stdio.h>
int main() {
  int tab[10];
  int chosen = 3;
  for (int i=0; i<10; i++){
    tab[i] = (i+1)*(chosen);
  }

  for (int i=0; i<10; i++) {
    printf("%d x %d = %d\n", i+1, chosen, tab[i]);
  }
  printf("\n");
}
