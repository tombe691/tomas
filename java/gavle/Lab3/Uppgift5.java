/*
    Uppgift5
    skriv ut baklänges med javakod.
    5b finns längst ner i undantaget.
    Tomas Berggren, tombe691@gmail.com
    2019-02-24
*/
import java.util.Scanner;


public class Uppgift5 {
    public static String ReadInput(){
        String userText = "";
	// Create a Scanner object
        Scanner myObj = new Scanner(System.in); 
        System.out.print("Mata in en text på 6 tecken: ");
        if(myObj.hasNext()) {
	    // Read user input
	    userText = myObj.next();  
	}
	else {
	    // Output user input
            System.out.println("Felaktig inmatning, returnerar tom sträng");
        }
        return userText;
    }
    public static void main (String[] args) {
        String userText = ReadInput();
	int length = userText.length();
	try {
	    String start = userText.substring(0,3);
	    if (start.toLowerCase().equals("hej")){
		System.out.println("Strängen börjar med hej ");
	    }
	    else {
		System.out.println("Strängen börjar inte med hej ");
	    }
	    if (length != 6) {
		System.out.println("Strängen "+userText+" är inte 6 tecken.");
	    }
	    else {
		for(int i = length-1; i>=0;i--) {
		    System.out.print(userText.charAt(i));
		}
	    }
	    // 5b if string is shorter than 3 chars, the substring will get
	    //index out of bounds, caught with try catch
	} catch (StringIndexOutOfBoundsException e) {
		System.out.println("Index out of bounds, Strängen "+userText+" är inte 6 tecken.");
	} 
    }
}
    
