/**/

#include <stdio.h>
#include <string.h>

void TEST_Tomas_run(void) {
  printf("Hej Tomas");
}

void TEST_Berggren_run(void) {
  printf("Hej Berggren");
}

#define MY_FUNC(name) \
    { TEST_##name##_run(); }

#define MY_FUNC2(name) \
    { void TEST_##group##_##name##_run(void);\
      TEST_##group##_##name##_run(); }

void print(char a[]) {
  char b[30];
  strcpy(b, a);
  strcat(b, ", goodbye");
  printf("%s", b);
}


int main() {
  MY_FUNC(Tomas);
  MY_FUNC(Berggren);
  print("hello world");
}
