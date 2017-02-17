#include<stdio.h>
#include<stdbool.h>

int main()
{
  int k = 15, n = 4, temp;
  int *pi, *pi2;
  bool equal = true;
  pi = &k;
  temp = n;
  printf("value pi %d\n", *pi);
  printf("value k %d\n", k);
  n = *pi;
  n = temp;
  pi2 = &n;
  printf("value pi2 %d\n", *pi2);
  k = n;
  *pi2 = *pi;
  printf("value pi2 %d\n", *pi2);
  return 0;
}
