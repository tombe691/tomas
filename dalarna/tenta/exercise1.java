
// Hello3.java

import javax.swing.*;
import java.text.DecimalFormat;

class exercise1 {
    public static void main (String[] arg) {
      String wString = JOptionPane.showInputDialog(null, "enter weight");
      wString = wString.toLowerCase();
      String hString = JOptionPane.showInputDialog(null, "enter height");
      hString = hString.toLowerCase();
      double wDouble = Double.parseDouble(wString);
      double hDouble = Double.parseDouble(hString);
      double bmi = (wDouble) / (Math.pow((hDouble/100), 2));

      String resultString = "";
      if (bmi > 29.9)
	  {
	      resultString = "Overweight";
	  }
      else if (bmi > 24.9)
	  {
	      resultString = "Over weight";
	  }
      else if (bmi >= 18.5)
	  {
	      resultString = "Normal weight";
	  }
      else if (bmi < 18.5)
	  {
	      resultString = "Under weight";
	  }
      
      String bmiString = String.format("%.2f", bmi);
      String result = bmiString+". Your result is : "+resultString;
      JOptionPane.showMessageDialog(null, "Hello your bmi is: " + result);
  }
}
