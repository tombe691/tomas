/*
    Uppgift5
    summera tal k-k+9 med javakod.
    Tomas Berggren, tombe691@gmail.com
    2019-02-11
*/

public class Uppgift5
{
    public static void main (String[] args)
    {
	int sum = 0;
	int start = 5;
	int counter = start;
	//loop to sum up to k+9
	int line = 1;
	//loop to check that counter is not higher than start+9
	while(counter<start+10){
	    System.out.format("%d. sum = %d, %d + %d = %d\n", line,
			      sum, sum, counter, (sum+counter));
	    //add value of sum
	    sum += counter;
	    counter++;
	    line++;
	}
	System.out.format("Summan av de adderade talen mellan %d-%d är:"+
			  sum, start, start+9);
    }
}
