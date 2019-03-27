/*
    Uppgift2
    räkna ut area och diagonal med javakod.
    Tomas Berggren, tombe691@gmail.com
    2019-02-18
*/
import java.util.Scanner;
import java.lang.Math;



public class Uppgift2 {
    public static double ReadInput(String text){
        double side = 0;
	// Create a Scanner object
        Scanner myObj = new Scanner(System.in); 
        System.out.println("Mata in sida "+text+" :");
        if(myObj.hasNext()) {
            if (myObj.hasNextDouble()) {
		// Read user input
                side = myObj.nextDouble();  
		// Output user input
                System.out.println("Sida "+text+" är: " + side);  
            }
            else {
		// Output user input
                System.out.println("Sida "+text+" är inte ett tal, du matade in: " + myObj.nextLine());  
            }
        }
        else {
	    // Output user input
            System.out.println("Felaktig inmatning, returnerar 0");
        }
        return side;
    }
    public static void main (String[] args) {
        int a = 12;
        double side_a, side_b, side_c, area, diagonal;
        side_a = ReadInput("a");
        side_b = ReadInput("b");

        if (side_a * side_b > 0){
            area = side_a*side_b;
            System.out.println("Arean är: "+area);

	    side_c = (side_a*side_a)+(side_b*side_b);
	    diagonal = Math.sqrt(side_c);
            System.out.println("Diagonalen är: "+diagonal);

	    double summa = side_a-side_b;
	    if (Math.abs(summa) < 0.000000001){
		System.out.println("Figuren är en kvadrat");
	    }
	    else {
		System.out.println("Figuren är en rektangel");
	    }
	}
    }
}
