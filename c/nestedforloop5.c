#include <stdio.h>

void test(int i) {
  for (int j=0; j<4; j++)
    {
      printf("%d, %d\n",i ,j);
    }
}

int main()
{
   for (int i=0; i<2; i++)
   {
     for (int j=0; j<4; j++)
       {
	 printf("%d, %d\n",i ,j);
       }
     test(i);
   }
   return 0;
}


//0, 1, 2, 3
//0, 1, 2, 3
