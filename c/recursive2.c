#include <stdio.h>
int sum(int n);

int main()
{
  int monthly = 100, result;
    
    result = sum(monthly);

    printf("sum=%d", result);
}

int sum(int num)
{
  static int count = 1;
  if (num<=1000000) {
    count++;
    printf("num = %d, count = %d\n", num, count);
    return num + sum(num+100); // sum() function calls itself
  }
  else {
    return num;
  }
}
