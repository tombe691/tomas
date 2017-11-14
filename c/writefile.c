#include <stdio.h>

int main() {
   FILE *fp;

   fp = fopen("c:/tomas/c/simple/test34.txt", "r+");
   fprintf(fp, "This is testasdfasdfasdfing for едц fprintf...\n");
   fputs("This is testing for fputs...\n", fp);
   fclose(fp);
   return 0;
}
