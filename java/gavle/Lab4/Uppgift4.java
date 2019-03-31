/*
  Uppgift4
  Räkna förekomster.
  Tomas Berggren, tombe691@gmail.com
  2019-03-30
*/
import java.util.Scanner;

public class Uppgift4 {
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
	String text = ReadInput(" Write a text: ");
	String lcText = text.toLowerCase();
	//	String vowels = "aAeEiIoOuUyYåÅäÄöÖ";
	int countCons = 0;
	int countVow = 0;
	int countPunc = 0;

	for(int i=0;i<lcText.length();i++) {
	    if (lcText.charAt(i) == 'a' || lcText.charAt(i) == 'e' || lcText.charAt(i) == 'i'
		|| lcText.charAt(i) == 'o' || lcText.charAt(i) == 'u' || lcText.charAt(i) == 'y')
		{
		    countVow++;
		}
	    if (lcText.charAt(i) == 'b' || lcText.charAt(i) == 'c' || lcText.charAt(i) == 'd'
		|| lcText.charAt(i) == 'f' || lcText.charAt(i) == 'g' || lcText.charAt(i) == 'h'
		|| lcText.charAt(i) == 'j' || lcText.charAt(i) == 'k' || lcText.charAt(i) == 'l'
		|| lcText.charAt(i) == 'm' || lcText.charAt(i) == 'n' || lcText.charAt(i) == 'p'
		|| lcText.charAt(i) == 'q' || lcText.charAt(i) == 'r' || lcText.charAt(i) == 's'
		|| lcText.charAt(i) == 't' || lcText.charAt(i) == 'v' || lcText.charAt(i) == 'w'
		|| lcText.charAt(i) == 'x' || lcText.charAt(i) == 'z')
		{
		    countCons++;
		}
	    if (lcText.charAt(i) == '.' || lcText.charAt(i) == '!' || lcText.charAt(i) == '?'
		|| lcText.charAt(i) == ',' || lcText.charAt(i) == ';' || lcText.charAt(i) == ':'
		|| lcText.charAt(i) == '-' || lcText.charAt(i) == ' ')
		{
		    countPunc++;
		}
	}
	System.out.format("Number of consonants:\t "+countCons);
	System.out.format("\nNumber of vowels:\t "+countVow);
	System.out.format("\nNumber of punctuations:\t "+countPunc);
    }
}
