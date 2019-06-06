/*
    Uppgift3
    Förklara resultatet.
    Tomas Berggren, tombe691@gmail.com
    2019-03-31
*/


public class Uppgift3
{
    public static void main(String[] args) {
	// en array med 3 platser, index 0, 1, 2
	int[] numbers = { 5, 0, -23 };
	// byter ut värdet på index 1, dvs 0 till 16
	numbers[1] += 16;
	// skapar en ny array (values) som pekar på adressen till den första arrayen
	// (numbers) hade man använt pekare mer tydligt i java hade det varit tydligare
	// den andra variabeln pekar på samma minnesutrymme
	int[] values = numbers;
	// ändrar värdet på den första adressen till 10, eftersom adressen
	// är samma för båda arrayerna ändras innehållet för båda
	values[0] = 10;
	// multiplicerar den sista positionen med -2 och får 46
	values[2] *= -2;
	// skriver ut den nya och får 10 16 46
	for (int i = 0; i < numbers.length; i++)
	    System.out.println (numbers[i]);
    }
}
