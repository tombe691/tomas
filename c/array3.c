#include <stdio.h>
int main() {
  char name[] = {'T','o','m','a','s'};
  char name2[] = "Berggren";

  for (int i=5; i>=0; i--) {
    printf("%c", name[i]);
  }
  //for (int i=8; i>=0; i--) {
    printf("%c", name2[4]);
    //}
  //  printf("%s %s", name, name2);
}
