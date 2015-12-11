// Filen TabellOvn.java

import javax.swing.*;

public class TabellOvn {
  public static void main (String[] arg) {
    String s = JOptionPane.showInputDialog("n1?");
    int n1 = Integer.parseInt(s);
    s = JOptionPane.showInputDialog("n2?");
    int n2 = Integer.parseInt(s);
    // Skriv rubriker
    System.out.println("n\tn!");
    System.out.println(); 
    // Skriv tabellraderna
    for (int i=n1; i<=n2; i++) {
      System.out.println(i + "\t" + nfak(i));
    }
  }

  public static double nfak(int n) {
    double r=1;
    for (int i=2; i <=n; i++) {
	System.out.printf("r = %.0f\t\t i = %d\n", r, i);
	r = r*i;
    }
    return r;
  }
}
