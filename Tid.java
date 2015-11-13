// Filen Tid.java

import java.util.*;
import javax.swing.*;

public class Tid {

  public static String klockan() {
    String s = Calendar.getInstance().getTime().toString();
    int i = s.indexOf(':');
    return s.substring(i-2, i+6);
  }

  // Testprogram
  public static void main (String[] arg) {
    JOptionPane.showMessageDialog(null, "Klockan är: " + klockan());
  }
}