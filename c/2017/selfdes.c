#include <stdio.h>
int main()
{
  char c;
  printf("Would you like your computer to explode?");
  int a = 10;
  char d = '1';
  c=getchar();
  printf("next");
  //d=getchar();
  if(c=='G' || c==  'g' && d=='0') 
    {
      printf("%c", c);
      printf(" %c", d);
      printf("\nOkay. Whew!\n");
    }
  else
    {
      printf("OK: Configuring computer to explode now.\n");
      printf("Bye!\n");
    }
  return(0);
} 
