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
  }
}
