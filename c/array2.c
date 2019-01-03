#include <stdio.h>
int main() {
  double f1[] = {0, 0, 0, 0};
  int f2[] = {5, 10, 20, 50, 100, 200, 500};
  char name[] = {'T','o','m','a','s'};
  char name2[] = "Berggren";

  for (int i=0; i<4; i++) {
    //printf("%f ", f1[i]);
  }
  printf("\n");
  for (int i=0; i<7; i++) {
    //printf("%d ", f2[i]);
  }
  //  printf("%d ", f2[i]);
  //  printf("%s %s", name, name2);

  for (int i=5; i>=0; i--) {
    printf("%c", name[i]);
  }
  //  printf("%s %s", name, name2);
}
