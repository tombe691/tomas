#include <stdio.h>

int main(){ 
  int sum = 0;
  for(int k = 3; k <= 5; k++)
    {
      for(int l = 1; l <= 3; l++) {
	sum = sum + 1;
      	for(int l = 1; l <= 2; l++)
	  sum = sum + 1;
      }
    }
  printf("sum = %d\n", sum);
  return 0;
}
