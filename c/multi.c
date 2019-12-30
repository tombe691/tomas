#include <stdio.h>
#include <stdbool.h>
#include <math.h>
void bubble_sort(int list[], int n)
{
  int c, d, temp;
 
  for (c = 0 ; c < ( n - 1 ); c++)
  {
    for (d = 0 ; d < n - c - 1; d++)
    {
      if (list[d] > list[d+1])
      {
        temp      = list[d];
        list[d]   = list[d+1];
        list[d+1] = temp;
      }
    }
  }
}

double average(int list[], int n)
{
  double sum = 0;
  for (int i=0; i<8;i++){
    sum = sum + list[i];
  }
  return sum/n;
}


double median(int list[], int n)
{
  bool even = (n %2 == 0);

  if (even) {
    return ((list[n/2-1]+list[n/2])/2.0);
  }
  else {
    int m = ceil(n/2.0);
    return (list[m-1]); 
  }
}

int main() {
  int a[] = {20, 15, 26, 18, 30, 22, 23, 24};
  int b[] = {11, 24, 15, 27, 19, 30, 21, 25};

  bubble_sort(a, 8);
  bubble_sort(b, 8);
  int all[4][2];
  all[0][0] = average(a, 8);
  all[0][1] = average(b, 8);
  all[1][0] = median(a, 8);
  all[1][1] = median(b, 8);
  all[2][0] = a[0];
  all[2][1] = b[0];
  all[3][0] = a[8-1];
  all[3][1] = b[8-1];

  printf("\tA\tB");
  printf("\n");
  printf("average\t");
  for (int j=0; j<2; j++) {
    printf("%d\t", all[0][j]);
  }

  printf("\nmedian\t");
  for (int j=0; j<2; j++) {
    printf("%d\t", all[1][j]);
  }

  printf("\nmin\t");
  for (int j=0; j<2; j++) {
    printf("%d\t", all[2][j]);
  }

  printf("\nmax\t");
  for (int j=0; j<2; j++) {
    printf("%d\t", all[3][j]);
  }
}
