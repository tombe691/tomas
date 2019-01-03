
/*Detta program är en räknare som kan användas för ellära med enbart växelspänningar och växelströmmar. Räknaren
tar upp räkning med spänningar i volt(U), resistanser upp till 20 000/ohm(R).
Ström upp till 440 Ampere(I), effekter P i watt(W). 3 faser upp till 400V mellan faserna.
Även tar denna upp Skenbar effekt vid 3-fas och enfas, aktiv effekt vid 3-fas och enfas där cosinus fi/cosinus() används
som effektfaktorn som är mindre än 1 och inte mindre än 0.
Frekvenser i (Hz):  och totala motståndet i parallellkopplade kretsar med max 3 motstånd.

50 Hertz(Hz) Finns det i våra uttag i sverige Vid 50 Hz byter ­spänningen polaritet och strömmen riktning 100 gånger per
sekund. Spänningen i svenska eluttag pendlar upp och ner från -325 V till +325 V. Att vi talar om 230 V beror på att det
är spänningens(växelström ~) effektivvärde eller roten ur. Spänningen V(U)=Toppvärdet/sqrt(2)=325V/sqrt(2).

OHMS LAG: Spänning i volt(U)=Resistans i ohm(R)*Ström i ampere(I)
RESISTANSTOTAL PARALLELLA RESISTANSER: Rtot=1/R1R2R3
EFFEKTLAGEN ENKEL för likström: Effekt i watt(P)=U*I
SKENBAR EFFEKT ENFAS ~: Skenbar(S/VA)=U*I
AKTIV EFFEKT/MEDELEFFEKT ENFAS ~:P=U*I*cos()
SKENBAR EFFEKT 3-FAS ~: Skenbar S/VA=U*I*sqrt(3)
AKTIV EFFEKT 3-FAS ~: P=U*I*sqrt(3)*cos()

*/
#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <limits.h>
#include <stdbool.h>
//#include "funktioner.h"

double ohms_lag(double r, double i){

    double u = i * r;

    return u;
}

double res_tot(double r1, double r2, double r3){


    double rtot= (1/r1) + (1/r2) + (1/r3);
    rtot= 1/rtot;

    return rtot;
}

double eff_enk(double u, double i){

    double p = u * i;

    return p;
}

double sken_eff(double u, double i){

    double s = u * i;

    return s;

}

double aktiv_eff(double u, double i, double cos){

    double p = u * i * cos;

    return p;

}

double sken_3fas(double u, double i){

    double s = u * i * sqrt(3);

    return s;
}

double aktiv_3fas(double u, double i, double cos){

    double p = u * i * sqrt(3) * cos;

    return p;
}

void PrintTryAgain(){
  printf("För högt värde, försök igen: \n");
}

double GetValue(double limit) {
  double value;
  scanf("%lf", &value);

  if (value>limit) {
    PrintTryAgain();
    GetValue(limit);
  }
  return value;
}

void FirstCase()
{
  printf("Ohms lag spänningen(volt/V) betäckning U lika med Resistansen(Ohm) betäckning R \n");
  printf("gånger Strömmen(Ampere) med betäckningen I. Kort U=R*I. \n\n");

  printf("Skriv resistans R < 20 000ohm: \n ");
  
  double r, i;
  r = GetValue(20000);
  
  printf("Skriv ström I < 440 Ampere: \n");
  i = GetValue(440);
  
  printf("%f V\n", ohms_lag(r, i));
  
}


void SecondCase(){
  printf("Resistans sammankopplade i parallella kretsar är lika med 1 delat Resistans R total är lika med\n");
  printf("Resistans 1/R1 + 1/R2 + 1/R3 då vi högst använder tre resistanser.\n\n");
  double r1,r2,r3;
  printf("Skriv resistans R1 < 20 000ohm: \n ");
  r1 = GetValue(20000);

  printf("Skriv resistans R2 < 20 000ohm: \n ");
  r2 = GetValue(20000);

  printf("Skriv resistans R3 < 20 000ohm: \n ");
  r3 = GetValue(20000);
  printf("%f Ohm\n", res_tot(r1, r2, r3));
}

void ThirdCase() {
  printf("Effektlagen enkel för likström är effekten P i Watt (W) lika med spänningen U i volt(V)\n");
  printf("gånger strömmen I i Ampere(A): \n\n");

  double u, i;
  u = GetValue(20000);
  printf("Skriv ström Ampere I < 440A: \n");
  i = GetValue(440);
  printf("%f W\n", eff_enk(u, i));

}


void FourthCase(){
  printf("Skenbar effekt enfas räknas med storheten VA(VoltAmpere) som är lika med spänningen U i volt(V)\n");
  printf("gånger strömmen I i ampere(A)\n\n");
  double u, i;
  printf("Skriv Spänningen U i volt: \n ");
  u = GetValue(20000);
  printf("Skriv ström Ampere I < 440A: \n");
  i = GetValue(440);
  printf("%f VA\n", sken_eff(u, i));

}

void FifthCase() {
  printf("Aktiv medelefdekt enfas är lika med effekt P i watt(W) lika med spänningen U i volt(V) gånger strömmen I \n");
  printf("i Ampere gånger cosinus fi/efkektfaktor < 1:\n\n");
  double u, i, cos;
  u = GetValue(20000);
  printf("Skriv ström I: \n");
  i = GetValue(440);
  printf("Skriv in effektfaktorn cos > 0 && cos < 1:\n");
  u = GetValue(1);
  printf("%f W\n", aktiv_eff(u, i, cos));
  
}

void SixthCase(){
  printf("3-fas skenbar effekt är växelspänning är skenbar effekt S i voltampere(VA) lika med spänningen U i volt(V) \n");
  printf("gånger strömmen I i ampere(A) gånger roten ur 3 SQRT(3).\n\n");
  double u, i;
  printf("Skriv spänning U i volt(V) < 400V: \n ");
  u = GetValue(400);

  printf("Skriv ström I i ampere < 440: \n");
  i = GetValue(440);
  printf("%f VA\n", sken_3fas(u, i));

}

void SeventhCase(){
  printf("3-fas aktiv effekt är effekten P i Watt(W) lika med spänningen U i volt(V) gånger strömmen I i ampere(A)\n");
  printf("gånger cos < 1 && cos > 0 gånger roten ur 3 SQRT(3).\n\n");
  double u, i, cos;
            printf("Skriv Spänningen U i volt(V): \n ");
	    u = GetValue(400);
            printf("Skriv ström I i ampere(A): \n");
	    i = GetValue(440);

            printf("Skriv in effektfaktorn cos > 0 && cos < 1: \n");
	    cos = GetValue(1);
            printf("%f W\n", aktiv_3fas(u ,i, cos));

}

int choice(){
        printf("\n");
        int val;

        printf("Välj vilka storheter du vill beräkna:\n");
        printf("Välj 1 för: OHMS LAG\n");
        printf("Välj 2 för: Rtot\n");
        printf("Välj 3 för: EFFEKTLAGEN ENKEL\n");
        printf("Välj 4 för: SKENBAR EFFEKT ENFAS\n");
        printf("Välj 5 för: AKTIV EFFEKT/MEDELEFFEKT ENFAS\n");
        printf("Välj 6 för: SKENBAR EFFEKT 3-FAS\n");
        printf("Välj 7 för: AKTIV EFFEKT 3-FAS\n");
        printf("Välj 0 för: FÖR ATT AVSLUTA\n");

        scanf("%d", &val);
	return val;
}
  
int main()
{
    system("chcp 1252");
    system("cls");
    bool exit = false;
    int val;
    do
    {
        val = choice();

	switch(choice()) {
	case 1:
	  FirstCase();
	  break;
	case 2:
	  SecondCase(); 
	  break;
	case 3:
	  ThirdCase();
	  break;
	case 4:
	  FourthCase();
	  break;
	case 5:
	  break;
	  FifthCase();
	case 6:
	  SixthCase();
	  break;
	case 7:
	  SeventhCase();
	  break;
	case 0:
	  break;
	default:
	  printf("Fel alternativ försök igen!: \n");
	  break;
        }
    } while (val !=0);
    
    return 0;
}
