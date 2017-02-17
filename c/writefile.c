#include <stdio.h>

main() {
   FILE *fp;

   fp = fopen("c:/tomas/c/simple/test23.txt", "w+");
   fprintf(fp, "This is testing for едц fprintf...\n");
   fputs("This is testing for fputs...\n", fp);
   fclose(fp);
}
