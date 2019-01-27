#include <iostream>

int func(int n1, int& value)
{
  value = n1*2;
  return n1;
}

int main(){
  int n1 = 2, n2 = 3;
  int n = func(n1, n2);
  std::cout << n << ", " << n1 << ", " << n2;
}
