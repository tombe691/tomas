
// Hello3.java

import javax.swing.*;

class exercise1 {
  public static void main (String[] arg) {
      String s = JOptionPane.showInputDialog(null, "enter weight");
      s = s.toLowerCase();
      String t = JOptionPane.showInputDialog(null, "enter height");
      t = t.toLowerCase();
      int days = 5;
      switch (s) {
      case "april": case "june": case "september": case "november":
	  days = 30;
	  break;
      case "february":
	  days = 28;
	  break;
      case "january": case "march": case "may": case "july": case "august": case "october": case "december":
	  days = 31;
      break;
      default:
	  throw new IllegalArgumentException("Invalid month: " + s);

      }
      JOptionPane.showMessageDialog(null, "Hello World!" + days);
  }
}
