#include<stdio.h>
#include<string.h>

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
  //printf("address %d\n", pi2);
  printf("value %d\n", *pi2); //n is not initialized yet
  k = n;
  *pi2 = *pi; //value pi2 = value pi
  //printf("address %d\n", pi2); 
  printf("value %d\n", *pi2);
  return 0;
}
