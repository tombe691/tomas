#include <stdio.h>
#include <string.h>
#include <ctype.h>
 
int main() {
   char vokaler[] = "aouåeiyäö";
   char s[100];
   printf("Skriv en text\n");
   fgets(s, 100, stdin); 
   for (int i=0; s[i] != '\0'; i++) {
      putchar(s[i]);
      if (strchr(vokaler, tolower(s[i])) != NULL) 
 	      i = i + 2; // hoppa över två tecken
    }
} 

