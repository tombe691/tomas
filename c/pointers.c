#include<stdio.h>
#include<string.h>

int main()
{
  int k = 10, n = 3, temp;
  int *pi, *pi2;
  pi = &k;
  printf("pi = &k %d\n", &k);
  temp = n;
  printf("temp = n %d\n", temp);
  //printf("3value k %d\n", k);
  n = *pi;
  printf("n = *pi %d\n", n);
  n = temp;
  printf("n = temp %d\n", n);
  pi2 = &n;
  printf("pi2 %d\n", pi2);
  //  printf("1 value pi2 %d\n", *pi2);
  //printf("address %d\n", pi2);
  //printf("value pi2 %d\n", *pi2); //n is not initialized yet
  k = n;
  printf("k = n %d\n", k);
  *pi2 = *pi; //value pi2 = value pi
  //printf("address %d\n", pi2); 
  printf("pi2 = *pi %d\n", *pi2);
  return 0;
}
