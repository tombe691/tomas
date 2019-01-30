#include <stdio.h>
#define FIRST_BIT 1 (0x1)
#define SECOND_BIT (0x2)
#define THIRD_BIT (0x4)
#define FOURTH_BIT (0x8)
#define FIFTH_BIT (0x16)
#define SIXTH_BIT (0x32)
#define SEVENTH_BIT (0x64)
#define EIGTH_BIT (0x128)

 
int main(void)
{
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
