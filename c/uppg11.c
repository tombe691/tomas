#include <stdio.h>

int main()
{
	double pris = 32;
	int antalSidor = 200;
	char titel[] = "C fran borjan";
 	printf("Titel ar %s\n antal sidor %d, \tpris %.3f\n", titel, antalSidor, pris);
	printf("%c %c %c %c %c", '\0' '\33' '\177' '\266' '\377');

    	return 0;
}
