#include <stdio.h>

int main (){
  int i, j;
  for (j='A';j<'H';j++) {
    for (i=1; i<8;i++) {
      printf("%c%d\t", j, i);
    }
    printf("\n");
  }
}
