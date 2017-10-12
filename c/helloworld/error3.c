#include <stdio.h>
#include <stdlib.h>

main() {

   int dividend = 20;
   int divisor = 0;
   int quotient;
 
   if( divisor == 0){
      printf("Division by zero! Exiting...\n");
      exit(-1);
   }
   
   quotient = dividend / divisor;
   printf("Value of quotient : %d\n", quotient );

   exit(0);
}


