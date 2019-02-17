#include<stdio.h>
#include<string.h>

int main()
{

  char a[40];
  char firstName[] = "tomas";
  char lastName[] = "berggren";
  strcpy(a, firstName);
  strcat(a, lastName);
  printf("#%s#\n", a);
  int tal, tal2;
  tal = 2;
  tal2 = tal * 2;
  char s2[20];
  printf("%d\n", (tal * tal2)%3);

  //printf("printed sprintf %s\n", s2);
  
  tal = 2;
  tal2 = tal * 2;
  printf("%d", (tal * tal2)%3);
  return 0;
}
