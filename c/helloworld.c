#include <stdio.h>


int main()
{
  char a = 'H';
  char b = 'e';
  char c = 'l';
  char d = 'l';
  char e = 'o';
  char f = ' ';
  char g = 'w';
  char h = 'o';
  char i = 'r';
  char j = 'l';
  char k = 'd';
  char l = '\n'; 

  char text[20] = "3 Hello World\n";

  printf("1 Hello world\n");
  printf("2 %c%c%c%c%c%c%c%c%c%c%c%c", 
	 a, b, c, d, e, f, g, h, i, j, k, l);
  printf("%s", text);
  return 0;
}
