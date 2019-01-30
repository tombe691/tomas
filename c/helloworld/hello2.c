/**/

#include <stdio.h>

void TEST_Tomas_run(void) {
  printf("Hej Tomas ");
}

void TEST_Berggren_run(void) {
  printf("Hej Berggren");
}

#define MY_FUNC(name) \
    { TEST_##name##_run(); }

int main() {
  MY_FUNC(Tomas);
  MY_FUNC(Berggren);
}
