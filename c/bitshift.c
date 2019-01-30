#include <stdio.h>

struct byteBits
{
  unsigned a: 1;
  unsigned b: 1;
  unsigned c: 2;
  unsigned d: 1;
  unsigned e: 3; 
} x;
 
int main(void)
{
  x.a = 1;         //x.a may contain values from 0 to 1
  x.b = 0;         //x.b may contain values from 0 to 1
  x.c = 3;         //x.c may contain values from 0 to 3
  x.d = 1;         //x.d may contain values from 0 to 1
  x.e = 7;         //x.e may contain values from 0 to 7

  printf("x.a = %d\n", x.a);
  printf("x.c = %d\n", x.c);
  printf("x.e = %d\n", x.e);
  
   int x = 1;
   printf ("x << 1 = %d\n", x << 1);
   printf ("x << 1 = %d\n", x << 2);
   printf ("x << 1 = %d\n", x << 3);
   printf ("x << 1 = %d\n", x << 4);
   printf ("x << 1 = %d\n", x << 5);
   printf ("x << 1 = %d\n", x << 6);
   printf ("x << 1 = %d\n", x << 7);
   printf ("x << 1 = %d\n", x << 8);
   //   printf ("x >> 1 = %d\n", x >> 1);
   return 0;
}
