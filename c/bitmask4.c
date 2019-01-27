#include <stdio.h>
#define FIRST_BIT 1
#define SECOND_BIT 2
#define THIRD_BIT 4
#define FOURTH_BIT 8
 
int main(void)
{
   int x2 = FIRST_BIT | THIRD_BIT | FOURTH_BIT;

   if (x2&FIRST_BIT) {
     printf("1 "); 
   }
   if (x2&SECOND_BIT) {
     printf("2 "); 
   }
   if (x2&THIRD_BIT) {
     printf("3 "); 
   }
   if (x2&FOURTH_BIT) {
     printf("4 "); 
   }
   return 0;
}
