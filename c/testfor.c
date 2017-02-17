#include <stdio.h>

int main()
{
  int start = 2;
  int numberOfNumbers = 20;
  int maxNumberPerRow = 6;
  int numberofRows = numberOfNumbers / maxNumberPerRow;
  int remainingNumbers;
  int j = 1;
  //chart = 2;
  int result;
  int l=1;
  for(int k = 1; k < numberofRows+1; k++) 
  {
    for (int i = 0; i < maxNumberPerRow; i++)
    {
      l++;
      
      //std::ostringstream result;
      result = (l);
      printf("result is %d k = %d\n", result, k);
    }
  }
  return 0;
}


