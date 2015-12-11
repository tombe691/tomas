//OsNamn.java

import javax.swing.*;

public class OsNamn {
  public static void main (String[] arg) {
    JOptionPane.showMessageDialog(null, "Du kor " + 
                  System.getProperty("os.name") + " idag");
    JOptionPane.showMessageDialog(null, "Du heter " + 
                  System.getProperty("user.name") + " idag");
  }
}
