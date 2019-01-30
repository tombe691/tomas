#include <stdio.h>
#include <string.h>
#include <ctype.h>

int main()
{
  char t[] = "kalle";
  printf("längden är %d\n", strlen(t));
  printf("skriv ett tecken: ");
  char ch;
  scanf("%c", &ch);
  if (isdigit(ch)) {
    printf("siffra\n");
  }
  else if (islower(ch)) {
    printf("liten bokstav\n");
  }
  return 0;
}



//printf("%c %c %c %c %c", '\164', '\157', '\155', '\141', '\163');
