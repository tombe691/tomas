/*
    Uppgift4
    hitta fel i javakod.
    Tomas Berggren, tombe691@gmail.com
    2019-02-11
*/

public class Uppgift4
{
    public static void main(String[] args)
    {
	double a = 12.0;
	//a number with decimals cannot be int
	double b = 1.3;
	//missing semi colon at end of line
	char d = 'x';
	//variable d cannot be defined twice
	double d2 = a + b;
	//variable c is not defined
	int e = (int)a + (int)d;
	System.out.print (a);
	//lowercase s on System
	System.out.println (b);
	//variabel c is not defined
	System.out.println (d2);
	//missing r in print
	System.out.println (d);
	System.out.println (e);
    }
}
