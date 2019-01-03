/**/

#include <stdio.h>
#include <string.h>

void print(char a[]) {
  char b[30];
  strcpy(b, a);
  strcat(b, ", goodbye");
  printf("%s", b);
}


int main() {
  print("hello world");
}
