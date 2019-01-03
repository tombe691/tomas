#include <stdio.h>
#include <string.h>

int main(int argc, char *argv[]) {
  char test[] = "kalle";
  for(int i=1; i<argc; i++) {
    printf("argument is %s \n", argv[i]);
    if (strcmp(argv[i], test) == 0) {
      printf("lika");
    }
    else {
      printf("inte lika");
    }
  }
  printf("\n");
  
  printf("Skriv något!\n");
  int n = 0, c;
  while ( (c = getchar()) != EOF )
    n++;
  printf("Du skrev %d tecken\n", n);  
}
