#include <stdio.h>

int b = 3;

void f() {
  int c = 2;
  static int a;
  a = 0;
  printf("a=%d b=%d c=%d\n", ++a, ++b, ++c);
}

int main()
{
  f();
  ++b;
  f();
}
