#include <stdio.h>

int main() {
   FILE *fp;

   fp = fopen("c:/tomas/c/simple/test99.txt", "w+");
   fprintf(fp, "This is testasdfasdfasdfing for aao fprintf...\n");
   fputs("This is testing for fputs...\n", fp);
   fclose(fp);
   return 0;
}
