#include<stdio.h>
int main()
{
  int k = 15, n;
  int *pi, *pi2;
  pi = &k;
  pi2 = &n;
  *pi2 = *pi;
  printf("value %d\n", *pi2);
  return 0;
}
