#include <stdio.h>
#define FIRST_BIT (0x1)
#define SECOND_BIT (0x2)
#define THIRD_BIT (0x4)
#define FOURTH_BIT (0x8)

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
  printf("x %d bb %x tot %d\n", x, x, (x.a+x.c+x.e));
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


/* Increase by for each bit, *2 each time, 
   0x prefix means they're specified via a hex value */

   int x2 = FIRST_BIT | THIRD_BIT | FOURTH_BIT;
   printf("x2 %d\n", x2);
   int isSet = x2&SECOND_BIT;
   printf("isset %d\n", isSet);

   if (x2&FIRST_BIT) {
     printf("1 is set \n"); 
   }
   if (x2&SECOND_BIT) {
     printf("2 is set \n"); 
   }
   if (x2&THIRD_BIT) {
     printf("3 is set \n"); 
   }
   if (x2&FOURTH_BIT) {
     printf("4 is set \n"); 
   }

   return 0;
}
