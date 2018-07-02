#include<stdio.h>

int multi_table(int x,int n)
{
  int i,y=x;
  for(i=1;i<=n;i++)
    {
      printf("\n\t%d * %d = %d\n",x,i,y);
      y+=x;
    }
  printf("hej");
  return y;
}


void main()
{
  int a = multi_table(3, 10);
	printf("a%d", a);
}


