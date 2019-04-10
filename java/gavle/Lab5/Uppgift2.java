/*
  Uppgift2
  Skriv ut inmatad text framlänges och baklänges.
  Tomas Berggren, tombe691@gmail.com
  2019-03-31
*/
import java.util.Scanner;

public class Uppgift2 {
    public static String ReadInput(String text){
        String input = "";
	// Create a Scanner object
        Scanner myObj = new Scanner(System.in); 
        System.out.print(text);
        if(myObj.hasNext()) {
            if (myObj.hasNextLine()) {
		// Read user input
                input = myObj.nextLine();  
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
	// read input string
	String text = ReadInput(" Write a text: ");
	// print string char by char from start to end
	for(int i=0;i<text.length();i++) {
	    char c = text.charAt(i);
	    System.out.format("%c", c);
	}
	// print string in reverse order
	for(int i=text.length()-1;i>=0;i--) {
	    char c = text.charAt(i);
	    System.out.format("%c", c);
	}
    }
}
