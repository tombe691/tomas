// Hello3.java

import javax.swing.*;

class Confirm {
  public static void main (String[] arg) {
    JOptionPane.showConfirmDialog(null, "Hello World!");
    JOptionPane.showOptionDialog(null, 
        "Sten, sax, påse", 
        "Feedback", 
        JOptionPane.YES_NO_CANCEL_OPTION, 
        JOptionPane.INFORMATION_MESSAGE, 
        null, 
	new String[]{"Sten", "Sax", "Påse"},
        "default");
  }
}
