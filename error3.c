#include <stdio.h>
#include <stdlib.h>

main() {

   int dividend = 20;
   int divisor = 1;
   int quotient;
 
   if( divisor == 0){
      printf(stderr, "Division by zero! Exiting...\n");
      exit(-1);
   }
   
   quotient = dividend / divisor;
   printf(stderr, "Value of quotient : %d\n", quotient );

   exit(0);
}
