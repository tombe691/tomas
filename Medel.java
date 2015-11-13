// Filen Medel.java

import javax.swing.*;

public class Medel {
    public static void main (String[] arg) {
	JOptionPane.showMessageDialog(null, "Medel blir: " + Medel2.medelv(5, 10));
    }
}

class Medel2 {
    public static double medelv (double a, double b) {
	return (a+b)/2;
    }

}
