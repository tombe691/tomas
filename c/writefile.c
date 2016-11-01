#include <stdio.h>

main() {
   FILE *fp;

   fp = fopen("/simple/test.txt", "w+");
   fprintf(fp, "This is testing for едц fprintf...\n");
   fputs("This is testing for fputs...\n", fp);
   fclose(fp);
}
