#include <stdio.h>

int a=0;

void f() {
int b= 0;
static int c;
c = 0;
printf("a=%d b=%d c=%d\n",++a,++b, ++c);
}

int main()
  {
         f();
	  ++a; //asdfg
  f();
}
