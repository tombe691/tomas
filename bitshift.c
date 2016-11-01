
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char **argv) {
   unsigned char c = atoi(argv[1]);
   unsigned char cMSN = c>>4;
   unsigned char cLSN = 0xF & c;
   unsigned char res = (0xF&c)+(c>>4);
   printf("c = 0x%X (%d) -- c[MSN]+c[LSN] = 0x%X + 0x%X = 0x%X (%d)\n", 
          c, c, cMSN, cLSN, res, res);
   return 0;
}
