#include<stdio.h>
#include<string.h>

int main()
{
  int k = 15, n;
  int *pi, *pi2;
  pi = &k;
  printf("address k %d\n", pi);
  printf("value k %d\n", *pi);
  pi2 = &n;
  printf("address %d\n", pi2);
  printf("value %d\n", *pi2); //n is not initialized yet
  *pi2 = *pi; //value pi2 = value pi
  printf("address %d\n", pi2); 
  printf("value %d\n", *pi2);
  return 0;
}
