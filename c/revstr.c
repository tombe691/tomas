#include<stdio.h>
#include<string.h>
#include<stdbool.h>
 
int main() {
   char str[100];
   int i, j = 0;
 
   printf("\nEnter the string :");
   gets(str);
 
   i = 0;
   j = strlen(str) - 1;
   bool lika = true;
   while (i < j && lika) {
     if (str[i] != str[j]) {
       lika = false;
     }
     else {
      i++;
      j--;
     }
   }
   if (lika) {
     printf("palindrom\n");
   }
   else {
     printf("inte lika\n");
   }
   return (0);
}
