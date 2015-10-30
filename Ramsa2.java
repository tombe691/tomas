// Filen Ramsa.java

import javax.swing.*; 

public class Ramsa2 {
  public static void main (String[] arg) {
    String a, b;
    a = "Programspråk";
    b = a.substring(4, 8) + a.charAt(5); 
    JOptionPane.showMessageDialog(null, b);
  }
}
