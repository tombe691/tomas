#include<stdio.h>
int main()
{
  int k = 15, n = 4, temp;
  int *pi, *pi2;
  pi = &k;
  temp = n;
  printf("value pi %d\n", *pi);
  printf("value k %d\n", k);
  n = *pi;
  n = temp;
  pi2 = &n;
  printf("value %d\n", *pi2);
  k = n;
  *pi2 = *pi;
  printf("value %d\n", *pi2);
  return 0;
}
