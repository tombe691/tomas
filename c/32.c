#include <stdio.h>
 int main () {
   printf("Pris för årskort? ");
   double arskort;
   scanf("%lf", &arskort);
   printf("Pris för biljett? ");
   double biljett;
   scanf("%lf", &biljett);
   printf("Antal besök? ");
   int antal;
   scanf("%d", &antal);
   if (arskort < antal*biljett)
     printf("Årskort är billigast\n");
   else
     printf("Biljetter är billigast\n");
}
