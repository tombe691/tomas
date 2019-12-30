#include <stdio.h>
#define FIRST_BIT 1
#define SECOND_BIT 2
#define THIRD_BIT 4
#define FOURTH_BIT 8
#define FIFTH_BIT 16
#define SIXTH_BIT 32
#define SEVENTH_BIT 64
#define EIGTH_BIT 128

 
int main(void)
{
/* Increase by for each bit, *2 each time, 
   0x prefix means they're specified via a hex value */

   int x2 = FIRST_BIT | SECOND_BIT | THIRD_BIT;
   printf("x2 %d\n", x2);
//////////////////////////////////////////////////////////////////////////////
   int is1Set = x2&FIRST_BIT;
   printf("is 1 set %d\n", is1Set);

   int is2Set = x2&SECOND_BIT;
   printf("is 2 set %d\n", is2Set);
   
   int is3Set = x2&THIRD_BIT;
   printf("is 3 set %d\n", is3Set);

   int is4Set = x2&FOURTH_BIT;
   printf("is 4 set %d\n", is4Set);
   
   //   x2 = FIRST_BIT | SECOND_BIT | FOURTH_BIT;

   int c = x2 << 1;        
   printf("c 14 %d\n", c);
   is2Set = x2&SECOND_BIT;
   printf("is 2 set %d\n", is2Set);

   is3Set = x2&THIRD_BIT;
   printf("is 3 set %d\n", is3Set);

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
   if (x2&FIFTH_BIT) {
     printf("5 is set \n"); 
   }
   if (x2&SIXTH_BIT) {
     printf("6 is set \n"); 
   }
   if (x2&SEVENTH_BIT) {
     printf("7 is set \n"); 
   }
   if (x2&EIGTH_BIT) {
     printf("8 is set \n"); 
   }
   

   return 0;
}
