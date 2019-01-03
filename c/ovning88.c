#include <stdio.h>
int main() {
  int tab[10][10];
  for (int i=0; i<10; i++){
    for (int j=0; j<10; j++){
      tab[i][j] = (i+1)*(j+1);
    }
  }
  for (int i=0; i<10; i++) {
    for (int j=0; j<10; j++) {
      printf("%d\t", tab[i][j]);
    }
    printf("\n");
  }     
}
