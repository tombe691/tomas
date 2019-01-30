#include <stdio.h>
int b = 4;
void f() {
  int c = 3;
  static int a;
  a = 1;
  printf("a=%d b=%d c=%d\n", ++a, ++b, ++c);
}
int main()
{
  f();
  ++b;
  f();
}
