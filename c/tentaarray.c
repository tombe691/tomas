#include<stdio.h>
#include<string.h>

int main()
{
  int i[10], x;
  int tal = 3;

  for (x=0;x<10;x++)
    i[x] = x+tal++;

  
  printf("Arrayen: ");
  for (x = 0;x<10;x++) {
    printf("%d ", i[x]);
    if (x %3 == 0)
      printf("\n");
  }

  return 0;
}
