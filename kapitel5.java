// Filen Summa2.java

import javax.swing.*;

public class Kapitel5 {  // Beräkning av summan 1+2+3+ .. + n
  public static void main (String[] arg) {
    String s = JOptionPane.showInputDialog("n?");
    int n = Integer.parseInt(s);
    int summa, k;
    for (k=1, summa=0; k <= n; k=k+1) 
      summa = summa + k;
    JOptionPane.showMessageDialog(null, "Summan blir " + summa);
  }
}