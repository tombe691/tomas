/*
    Uppgift2
    Gissa tal.
    Tomas Berggren, tombe691@gmail.com
    2019-03-18
*/
import java.util.Scanner;


public class Uppgift4 {
    public static String ReadInput(String text){
        String input = "";
	// Create a Scanner object
        Scanner myObj = new Scanner(System.in); 
        System.out.println(text);
        if(myObj.hasNext()) {
            if (myObj.hasNextLine()) {
		// Read user input
                input = myObj.nextLine();  
		// Output user input
		//                System.out.println(text+" : " + input);  
            }
            else {
		// Output user input
                System.out.println("Inmatningen för "+text+" är inte text, du matade in: " + myObj.nextLine());  
            }
        }
        else {
	    // Output user input
            System.out.println("Felaktig inmatning, returnerar 0");
        }
        return input;
    }
    public static void main (String[] args) {
	String text = ReadInput(" skriv in en text");
	System.out.println("Bra jobbat, spelet är slut "+text);
    }
}
