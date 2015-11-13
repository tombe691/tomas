// Filen Persontest.java

import javax.swing.*;

public class pers2 {
  public static void main(String[] arg) {
      //    int kon = JOptionPane.showConfirmDialog(null, "Är du en kille?",
      //                        "Fråga", JOptionPane.YES_NO_OPTION);
    String s = JOptionPane.showInputDialog("Ditt personnummer?");
    String t = s.substring(s.length()-2, s.length()-1);  // näst sista siffran
    int nr = Integer.parseInt(t)%2;

    switch(nr) {
    case 0:
	JOptionPane.showMessageDialog(null, "du ar kvinna");
	break;
    case 1:
	JOptionPane.showMessageDialog(null, "du ar man");
	break;
    default:
	JOptionPane.showMessageDialog(null, "Stämmer kanske");
    }
  }
}
