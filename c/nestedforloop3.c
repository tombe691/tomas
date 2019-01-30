#include <stdio.h>

int main() {
  int i[10], x;
  int tal = 3;

  for (x=0;x<10;x++) {
    i[x] = x+tal++;
  }
  
  printf("Arrayen: ");
  for (x = 0;x<10;x++) {
    printf("%d ", i[x]);
    if (x %3 == 0){
      printf("\n");
   }
  }

  /*int tal = 2;
    int tal2 = tal*2;
    printf("%d",(tal * tal2)%3);*/
 /*  int sum = 0;
  for(int k=1; k<=4; k++) {
    for(int l=k;l<=5; l++){
      sum = sum+1;
    }
  }
  printf("sum = %d", sum);
  //  */
  int n;// = 15;
  scanf("%d", &n);
  int sum = 0;
  for(int k = 3; k <= 6; k++)
    {
      for(int l = 1; l <= 3; l++)
	sum = sum + 1;
      for(int l = 1; l <= 4; l++)
	sum = sum + 1;
    }
  //kalle();
  printf("sum = %d\n", sum);
  /*
    for(int x1 = 1; x1 <= 10; x1++)
      for(int x2 = 1; x2 <= 10; x2++)
	for(int x3 = 1; x3 <= 10; x3++)
	  printf("oj vad det snurrar");
  */
}
