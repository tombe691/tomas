#include <stdio.h>
#include <math.h>

int convertBinaryToDecimal(long n)
{
    int decimalNumber = 0, i = 0, remainder;
    while (n!=0)
    {
        remainder = n%10;
        n /= 10;
        decimalNumber += remainder*pow(2,i);
        ++i;
    }
    return decimalNumber;
}

int main()
{
  long long b1 = 1000111;
  long long b2 = 1001001;
  long long b3 = 1001100;
  long long b4 = 1001100;
  long long b5 = 1000001;
  long long b6 = 1010010;
  
  int d1 = convertBinaryToDecimal(b1);
  int d2 = convertBinaryToDecimal(b2);
  int d3 = convertBinaryToDecimal(b3);
  int d4 = convertBinaryToDecimal(b4);
  int d5 = convertBinaryToDecimal(b5);
  int d6 = convertBinaryToDecimal(b6);
  printf("%c%c%c%c%c%c\n", d1, d2, d3, d4, d5, d6);

  return 0;
}

