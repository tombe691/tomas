#include<stdio.h>
//då behöver vi använda pekare
void swap(int *a, int *b) {
  int temp = *a;
  *a = *b;
  *b = temp;
}


int main()  //vi vill byta plats på de värden som finns i a och b, sid 244
{
  int a = 1;
  int b = 2;
  printf("%d %d\n", a, b);
  swap(&a, &b);
  printf("%d %d\n", a, b);

 return 0;
}
