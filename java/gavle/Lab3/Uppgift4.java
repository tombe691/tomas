/*
    Uppgift4
    Kasta tärning med javakod.
    Tomas Berggren, tombe691@gmail.com
    2019-02-19
*/
import java.util.Scanner;


public class Uppgift4 {
    public static void main(String[] args) {
	System.out.println("Tärning kastas:");
	// Simulera ett tarningskast:
	int points1 = (int) (Math.random () * 6) + 1;
	System.out.format("Det blev %d\n", points1);
 	String resultString;
	switch (points1) {
	case 1: 
	case 2:  resultString = "borgare";
	    break;
	case 4:  resultString = "adlig";
	    break;
	case 5:  resultString = "bonde";
	    break;
	case 3:
	case 6:
	    resultString = "kung";
	    break;
	default: resultString = "Invalid points";
	    break;
	}
	System.out.println("Du blev "+resultString);
    }
}
