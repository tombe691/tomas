#include <stdio.h>
int main() {
  int iot17[] = {10, 15, 16, 18, 20, 22, 23, 24};
  int is16[] = {11, 14, 15, 17, 19, 20, 21, 25};
  int all[2][8];
  for (int i=0; i<8;i++){
    all[0][i] = iot17[i];
    all[1][i] = is16[i];
  }
  printf("iot17\t");
  for (int j=0; j<8; j++) {
    printf("%d\t", all[0][j]);
  }
  printf("\n");
  printf("is16\t");
  
  for (int j=0; j<8; j++) {
    printf("%d\t", all[1][j]);
  }
}
