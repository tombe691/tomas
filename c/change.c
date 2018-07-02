#include <stdio.h>
//#include <stdlib.h>
void change(int* a, int* b) {
  int temp = *a;
  *a = *b;
  *b = temp;
}

void  myfuturedatabase() {
  system("c:/temp/test.xlsx");
}


int main(){
  int a = 5;
  int b = 10;

  printf("1 a %d b %d\n", a, b);
  change(&a, &b);
  printf("3 a %d b %d\n", a, b);

  myfuturedatabase();
  //  system("c:/temp/test.xlsx");
}


