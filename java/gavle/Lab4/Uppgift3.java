/*
    Uppgift3
    Fixa logiska fel.
    Tomas Berggren, tombe691@gmail.com
    2019-03-18
*/


public class Uppgift3 {
    public static void main (String[] args) {
	// 3a
	System.out.println ("3a\n");
	int number1 = 8;
	//changed or to and || -> &&
	while (number1 >= 8 && number1 < 16)
	    { System.out.println (number1);
		number1++;
	    }
	// 3b
	System.out.println ("\n3b\n");
	int number2 = 0;
	int k = 0;
	//removed ; at the end of for
	for (int i = 0; i < 5; i++)
	{
	    number2 += ++k;
	}
	System.out.println (number2);
	// 3c
	System.out.println ("\n3c\n");
	double number = 2.0;
	while (true)
	    {
		// double should not be compared with == due to
		// decimal rounding problem
		if(Math.abs(number - 0.5) < 0.000000000001)
		    break;
		number -= 0.1;
		System.out.println (number);
	    }
	System.out.println ("Finished.");
    }
}
