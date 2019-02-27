/*
    Uppgift3
    summera tal 1-10 med javakod.
    Tomas Berggren, tombe691@gmail.com
    2019-02-10
*/

public class Uppgift3
{
    public static void main (String[] args)
    {
	int sum = 0;
	int counter = 1;
	//loop to sum up to 10
	while(counter<11){
	    System.out.format("sum = %d, %d + %d = %d\n", sum, sum, counter, (sum+counter));
	    //add value of sum
	    sum += counter;
	    counter++;
	}
	System.out.println("Summan av de adderade talen mellan 1-10 är:"+ sum);
    }
}
