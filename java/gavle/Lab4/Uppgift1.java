/*
    Uppgift1
    skriv ut multiplikationstabell.
    Tomas Berggren, tombe691@gmail.com
    2019-03-28
*/
import java.util.Scanner;


public class Uppgift1 {
    public static int ReadInput(String text){
        int input = 0;
	// Create a Scanner object
        Scanner myObj = new Scanner(System.in); 
        System.out.println("Mata in ett "+text+" :");
        if(myObj.hasNext()) {
            if (myObj.hasNextInt()) {
		// Read user input
                input = myObj.nextInt();  
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
        int table, size;
        table = ReadInput("vilken tabell");
        size = ReadInput("hur långt");
	System.out.print(" x |");
	int h;
	for (h = 1; h <=table; h++){
	    System.out.format(" %3d | ", h);
	}
	System.out.println("");
	for (h = 1; h <=table; h++){
	    System.out.format("_ _ _ _");
	}
	System.out.println("");

	for (int i = 1; i <=size; i++){
	    System.out.format("%2d |", i);
	    for (int j = 1; j <=table; j++){
		System.out.format(" %3d | ", j*i);
	    }
	    System.out.println("");
	}
    }
}
