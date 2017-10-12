/**/

#include <stdio.h>
#include <string.h>

void print(char* a) {
  char b[30];
  strcpy(b, a);
  strcat(a, ", goodbye");
  printf("%s", a);
}


int main() {
  print("hello world");
}
