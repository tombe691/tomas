#include <stdio.h>

// function prototypes
int add(int x, int y);
int subtract(int x, int y);
int domath(int (*mathop)(int, int), int x, int y);

// add x + y
int add(int x, int y) {
  return x + y;
}

// subtract x - y
int subtract(int x, int y) {
  return x - y;
}

// run the function pointer with inputs
int domath(int (*mathop)(int, int), int x, int y) {
  return (*mathop)(x, y);
}

// calling from main
int main() {

  // call math function with add
  int a = domath(add, 10, 2);
  printf("Add gives: %d\n", a);

  // call math function with subtract
  int b = domath(subtract, 10, 2);
  printf("Subtract gives: %d\n", b);
}
