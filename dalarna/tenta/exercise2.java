/*
    Exercise2
    MPG.
    Tomas Berggren, tombe691@gmail.com
    2019-03-18
*/

import java.util.Scanner;

public class exercise2 {
    // own method to read input with simple error handling
    public static double ReadInput(String text){
	// return value variable
        double input = 0;
	// Create a Scanner object
        Scanner myObj = new Scanner(System.in);
	// display input text
	System.out.println(text);
	// check that there is anything 
        if(myObj.hasNext()) {
	    // check that input is a double
            if (myObj.hasNextDouble()) {
		// Read user input into variabel
                input = myObj.nextDouble();  
            }
            else {
		// Output user input if not a number
                System.out.println("Inmatningen för "+text+" är inte ett tal, du matade in: " + myObj.nextLine());  
            }
        }
        else {
	    // Output user input if other input
            System.out.println("Felaktig inmatning, returnerar 0");
        }
	// return user input 
        return input;
    }
    
    public static void main (String[] args) {
	// define variables for the program
        double miles;
	double gallons;
	double mpg;
	// get input into variables
	miles = ReadInput("Input number of miles driven ");
	gallons = ReadInput("Input number of Gallons of gas used ");
	// calculate miles per galon
	mpg = miles/gallons;
	// format result with 2 decimals
	String mpgString = String.format("%.2f", mpg);
	// print result
	System.out.println("The MPG is "+mpgString);
    }
}
