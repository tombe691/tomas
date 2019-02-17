#include <stdio.h>

int main() {
  float x = 5.8;
  float *q1 = &x;
  float *q2;// = NULL;

  printf("%f\n", *q1);
  //  if (q2 != NULL)
    printf("%f\n", *q2);
}
