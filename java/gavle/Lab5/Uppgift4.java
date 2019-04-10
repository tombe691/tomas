/*
  Uppgift4
  Läs in dynamiskt antal värden tärningar till array och sortera + 
  räkna ut medel och median.
  Tomas Berggren, tombe691@gmail.com
  2019-03-31
*/
import java.util.Scanner;
import java.util.Arrays;


public class Uppgift4 {
    public static long ReadInput(String text){
        long input = 0;
	// Create a Scanner object
        Scanner myObj = new Scanner(System.in); 
        System.out.print(text+" : ");
        if(myObj.hasNext()) {
            if (myObj.hasNextLong()) {
		// Read user input
                input = myObj.nextLong();  
            }
            else {
		// Output user input
                System.out.println("Inmatningen för "+text+" är inte ett tal, du matade in: " +
				   myObj.nextLine());  
            }
        }
        else {
	    // Output user input
            System.out.println("Felaktig inmatning, returnerar 0");
        }
	// limit size to better fit data type
	if (input > 100000000){
	    System.out.println("Kan inte hantera så stort tal,\n returnerar 0");
	    input = 0;
	}
        return input;
    }
    public static void main (String[] args) {
	// using long to handle higher values
        long size, sum = 0;
	// read number of values
	size = ReadInput("Hur många värden ska registreras?\nAnge ett heltal");
	// create array with the size given
	long myArray[] = new long[(int)size];
	int number = 0;
	long number0 = 0;
	long number1 = 0;
	long number2 = 0;
	long number3 = 0;
	long number4 = 0;
	long number5 = 0;
	long number6 = 0;
	// filling dynamic array with random dice numbers (1-6)
	for(int i=0; i<size; i++) {
	    number = (int) (Math.random () * 6) + 1;
	    sum += number;
	    myArray[i] = number;
	    // switch to count accurance of each side
	    switch (number) {
	    case 1:
		number1++;
		break;
	    case 2:
		number2++;
		break;
	    case 3:
		number3++;
		break;
	    case 4:
		number4++;
		break;
	    case 5:
		number5++;
		break;
	    case 6:
		number6++;
		break;
	    default:
		// error handling
		number0++;
		break;
	    }
	}
	// sort array to be able to find median
	Arrays.sort(myArray);
	// print number of tries
	System.out.format("Antal försök: %d\n", size);
	// count average
	System.out.format("\nGenomsnitt: %.2f\n", (double)sum/size);
	// find median
	double median;
	long medianIndex = (size/2);
	//System.out.format("Medianindex: %d\n", medianIndex);
	// if number of items are equal, sum the two in the middle and divide by 2
	if (size%2==0) {
	    median = (myArray[(int)medianIndex-1] + myArray[(int)medianIndex])/2.0;
	}
	else {
	    median = myArray[(int)medianIndex];
	}
	// print output
	System.out.format("\nMedian: %.2f\n", median);
	System.out.format("Antal kast som gav:\n");
	System.out.format("Det blev %d ettor\n", number1);
	System.out.format("Det blev %d tvåor\n", number2);
	System.out.format("Det blev %d treor\n", number3);
	System.out.format("Det blev %d fyror\n", number4);
	System.out.format("Det blev %d femmor\n", number5);
	System.out.format("Det blev %d sexor\n", number6);
    }
}
