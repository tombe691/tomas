/*
    Exercise2
    MPG.
    Tomas Berggren, tombe691@gmail.com
    2019-03-18
*/
import java.util.Scanner;


public class exercise2 {
    public static double ReadInput(String text){
        double input = 0;
	// Create a Scanner object
        Scanner myObj = new Scanner(System.in); 
        System.out.println(text);
        if(myObj.hasNext()) {
            if (myObj.hasNextDouble()) {
		// Read user input
                input = myObj.nextDouble();  
		// Output user input
                System.out.println(text+" : " + input);  
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
        return input;
    }
    public static void main (String[] args) {
        double miles;
	double gallons;
	double mpg;
	miles = ReadInput("Input number of miles driven ");
	gallons = ReadInput("Input number of Gallons of gas used ");
	mpg = miles/gallons; 
	String mpgString = String.format("%.2f", mpg);

	System.out.println("The MPG is "+mpgString);
    }
}
