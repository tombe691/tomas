#include <stdio.h>
double sum(double n);

int main()
{
  int monthly = 100;
  double result;
    
    result = sum(monthly);

    printf("sum=%f", result/12);
}

double sum(double num)
{
  static int count = 1;
  double res = num;
  if (res<=1000000) {
    count++;
    printf("num = %f, count = %d\n", num, count/12);
    if (count%12==0){
      res = res * 1.02;
    }
    res = res + sum(res+100); // sum() function calls itself
    return res;
  }
  else {
    return num;
  }
}
