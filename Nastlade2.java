// Filen Nastlade2.java

import javax.swing.*;

public class Nastlade2 {
  public static void main (String[] arg) {
      int n = 5;
    String txt = "";
    for (int i=0; i<n; i++) {
	System.out.println("i="+i);
	for (int j=1; j<=i; j++) {
	    System.out.println("  j="+j);
	    txt = txt + '+';
	}
      txt = txt + '\n';
    }
    JOptionPane.showMessageDialog(null, txt);
  }
}
