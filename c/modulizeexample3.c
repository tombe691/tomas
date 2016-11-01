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
  int res = (*mathop)(x, y);
  return res;
}


int getinput()
{
  int method;
  printf("1.Add, 2.Sub, 3.Mul, 4.Div\n");
  scanf("%d", &method);
  return method;
}


void print(char a[], int i){
  printf("%s gives %d\n", a, i);
}


int callmathmethod(int method) {
  int result = 666;
  switch (method) {
  case 1:
    result = domath(add, 10, 2);
    break;
  case 2:
    result = domath(subtract, 10, 2);
    break;
  case 3:
    result = domath(multiply, 10, 2);
    break;
  case 4:
    result = domath(divide, 10, 2);
    break;
  default:
    printf("wrong input\n");
  }

  return result;

}

int main() {

  int method = getinput();
  int a, b, c, d;
  char *e[] = {"Tom", "Add", "Subtract", "Multiply", "Divide"};
  int result = callmathmethod(method);
  print(e[method], result);
}
