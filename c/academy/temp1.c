#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>

const int BUFSIZE = 20;
/*Converts from fahrenheit to celsius*/
double fahrenheitToCelsius(double farenheit) {
	return (farenheit - 32) * 5 / 9;
}

/*clear STDIN buf*/
void clearSTDINBuffer() {
	while (getchar() != '\n');
}

/*Exchange comma to dot, check for letters:
Returns 0 if char found, else 1*/
int checkCommaAndLetter(char input[]) {
	double t;
	for (int i = 0; i < BUFSIZE; i++) {
		if (input[i] == ',' || input[i] == '.') {
			input[i] = '.';
		}
		else if ((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' && 
		input[i] <= 'Z')) {
			return 0;
		}
	}
	return 1;
}

//start of program
int main() {
	double fahrenheitDouble;
	char newReadings = 'J', error;
	char fahrenheitString[BUFSIZE];

	while (toupper(newReadings) == 'J') {
		system("cls");
		printf("FAHRENHEIT - CELCIUS\n");
		printf("====================\n");
		printf("Ange temperatur i Farenheit :");
		fgets(fahrenheitString, BUFSIZE, stdin);
		if (checkCommaAndLetter(fahrenheitString) == 1) {
			fahrenheitDouble = atof(fahrenheitString);
			printf("Temperatur ar : %.1lf\n", 
			fahrenheitToCelsius(fahrenheitDouble));
		}
		else {
			printf("ERROR: Inmatningsfel\n");
		}
		printf("En gang till (J/N)?");
		newReadings = fgetc(stdin);
		clearSTDINBuffer();
	}
	return 0;
}
