#include <stdio.h>
 int main () {
   printf("Tryck på en knapp ");
   int knapp;
   scanf("%d", &knapp);
   int value = 3;
   switch (knapp) {
   case 0:
     value = 2;
     break;
   case 1 ... 6:
     value = 4;
     break;
   default:
     value = 8;
   }
   
   printf("value is %d, knapp = %d", value, knapp); 
 }
