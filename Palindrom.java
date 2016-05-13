// Filen Palindrom.java

import javax.swing.*;

public class Palindrom {
  public static void main (String[] arg) {
    String s = JOptionPane.showInputDialog("Skriv en text");
    int i, j;
    for (i=0, j=s.length()-1; i<j && s.charAt(i)==s.charAt(j); i++, j--){
	System.out.println("i="+i);
	System.out.println("j="+j);
	System.out.println("s char at i="+s.charAt(i));
	System.out.println("s char at j="+s.charAt(j));

	;    // en tom satsE
    }
    if (i>=j)
      JOptionPane.showMessageDialog(null, "Palindrom");
    else
      JOptionPane.showMessageDialog(null, "Inte palindrom");
    Bok b1 = new Bok();
    b1.titel = "Java - steg för steg";
    b1.forfattare = "Jan Skansholm";
    b1.antalSidor = 501;
    b1.pris = 300;

    Bok b2 = new Bok();
    b2.titel = "Portugisisk-Svensk ordbok";
    b2.forfattare = "Alexander Fernandes";
    b2.antalSidor = 367;
    b2.pris = 424;

    System.out.format("%s, %s, %1d sidor, %1.2f kr\n", 
                      b1.titel, b1.forfattare, b1.antalSidor, b1.pris);
    System.out.format("%s, %s, %1d sidor, %1.2f kr\n", 
                      b2.titel, b2.forfattare, b2.antalSidor, b2.pris);
    int [][] array = {{1, 2, 3},
		      {4, 5, 6},
		      {7, 8, 9}};
    System.out.println(array[2][1]);

    int[] arr = new int[10];
    int tal = 3;
    for (int x = 0; x < arr.length; x++)
	arr[x] = x + tal++;
    
    System.out.println("Arrayen: ");
    for (int x : arr){
	System.out.print(x + " ");
	if (x%3 == 0)
	    System.out.println();
    }
    
  }
}

class Bok {
  String titel;
  String forfattare;
  int antalSidor;
  double pris;
}


// Filen BokTest.java


