#include <stdio.h>

void printWeek(char dagar[][10], int nummer[]){
  for (int day=0; day<7;day++) {
    printf("%d. ", nummer[day]);
    printf("%s ", dagar[day]);
  }
}

int main (){
  int i;
  int b[] = {1, 2, 3, 4, 5, 6, 7};
  char a[7][10] = {"monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday"};

  printf("%c ", a[3][4]);
      printWeek(a, b);
      printf("\n");
      printWeek(a, b);
}
