#include<stdio.h>
#include<string.h>

int main()
{
  float f[4];
  float *pd;
  
  f[0] = 0;
  f[1] = 1;
  f[2] = 2;
  f[3] = 3;
  pd = &f[0]; //pd = f

  printf("%f", *pd);
  printf("%f", *pd+2);
  pd++;
  printf("%f", *pd);

  return 0;
}
