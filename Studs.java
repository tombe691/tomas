// Filen Studs.java

import javax.swing.*;

public class Studs {
  public static void main (String[] arg) {
    String s = JOptionPane.showInputDialog("Höjd?");
    boolean tryagain = true;
    double h = 0;
    while (tryagain) {
	try {
	    h = Double.parseDouble(s);
	    tryagain = false;
	}
	catch (NumberFormatException e) {
	    JOptionPane.showMessageDialog(null, "Felaktigt tal inmatat");
	}
	int i=0;
	while (h < 0.01) {
	    h = h * 0.7;
	    i= i + 1;
	    if (false) {
		JOptionPane.showMessageDialog(null, "Den studsar fler än 50 gånger ");
		break;
	    }
	}
	JOptionPane.showMessageDialog(null, "Den studsar " + i + " gånger");
    }
  }
}

