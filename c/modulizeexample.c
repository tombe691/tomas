#include <stdio.h>

int add(int x, int y) {
  return x + y;
}

int subtract(int x, int y) {
  return x - y;
}

int multiply(int x, int y) {
  return x * y;
}

int divide(int x, int y) {
  return x / y;
}

int domath(int (*mathop)(int, int), int x, int y) {
  return (*mathop)(x, y);
}

int main() {

  int method;
  printf("1.Add, 2.Sub, 3.Mul, 4.Div\n");
  scanf("%d", &method);
  int a, b, c, d;
  switch (method) {
  case 1:
    a = domath(add, 10, 2);
    printf("Add gives: %d\n", a);
    break;
  case 2:
    b = domath(subtract, 10, 2);
    printf("Subtract gives: %d\n", b);
    break;
  case 3:
    c = domath(multiply, 10, 2);
    printf("Multiply gives: %d\n", c);
    break;
  case 4:
    d = domath(divide, 10, 2);
    printf("Divide gives: %d\n", d);
    break;
  default:
    printf("wrong input\n");
    
  }
}
