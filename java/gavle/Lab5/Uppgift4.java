/*
  Uppgift1
  Läs in dynamiskt antal värden till array och sortera.
  Tomas Berggren, tombe691@gmail.com
  2019-03-31
*/
import java.util.Scanner;
import java.util.Arrays;
//import java.util.*;


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
		// Output user input
                //System.out.println(text+" : " + input);  
            }
            else {
		// Output user input
                System.out.println("Inmatningen för "+text+" är inte ett tal, du matade in: " + myObj.nextLine());  
            }
        }
        else {
	    // Output user input
            System.out.println("Felaktig inmatning, returnerar 0");
        }
	if (input > 100000000){
	            System.out.println("Kan inte hantera så stort tal,\n returnerar 0");
		    input = 0;
	}
        return input;
    }
    public static void main (String[] args) {
        long size, next, sum = 0;
	// read number of values
	size = ReadInput("Hur många värden ska registreras?\nAnge ett heltal");
	// create array with the size given
	long myArray[] = new long[(int)size];
	int number = 0;
	long number1 = 0;
	long number2 = 0;
	long number3 = 0;
	long number4 = 0;
	long number5 = 0;
	long number6 = 0;
	for(int i=0; i<size; i++) {
	    number = (int) (Math.random () * 6) + 1;
	    sum += number;
	    myArray[i] = number;
	    //System.out.format("Det blev %d\n", number);
 	String resultString;
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
	default: resultString = "Invalid points";
	    break;
	}
	}
	    System.out.format("Antal försök: %d\n", size);
	    System.out.format("\nGenomsnitt: %.2f\n", (double)sum/size);
	    System.out.format("Det blev %d ettor\n", number1);
	    System.out.format("Det blev %d tvåor\n", number2);
	    System.out.format("Det blev %d treor\n", number3);
	    System.out.format("Det blev %d fyror\n", number4);
	    System.out.format("Det blev %d femmor\n", number5);
	    System.out.format("Det blev %d sexor\n", number6);


    }
}
