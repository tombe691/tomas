#include <stdio.h>
#include <conio.h>
float insatt(float insatt_belopp, float kapital) {
  return kapital+insatt_belopp;
}
float uttag(float uttaget_belopp, float kapital) {
  if (kapital-uttaget_belopp<0) {
    printf("Försök till för stort uttag\n");
    return kapital;
  }
  else
    return kapital-uttaget_belopp;
}
float ranta(float rantefot, float kapital) {
  return kapital*(1+rantefot/100);
}
void kontostallning(float kapital) {
  printf("Kontostallning %.2f kr\n",kapital);
}
int main(void) {
  float kapital;
  kapital=insatt(1000,0);
  kapital=uttag(500,kapital);
  kontostallning(kapital);
  kapital=ranta(8,kapital);
  kontostallning(kapital);
  kapital=uttag(10000,kapital);
  getch();
}
