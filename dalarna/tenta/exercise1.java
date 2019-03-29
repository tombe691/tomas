/*
    Exercise1
    Calculate bmi.
    Tomas Berggren, tombe691@gmail.com
    2019-03-28
*/

import javax.swing.*;
import java.text.DecimalFormat;

class exercise1 {
    public static void main (String[] arg) {
	// read user input for weight and height into variables
	String wString = JOptionPane.showInputDialog(null, "enter weight");
	String hString = JOptionPane.showInputDialog(null, "enter height");
	// convert string to double
	double wDouble = Double.parseDouble(wString);
	double hDouble = Double.parseDouble(hString);
	// calculate bmi, divide by 100 to change from cm
	double bmi = (wDouble) / (Math.pow((hDouble/100), 2));
	// string to display bmi weight group
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
	// format for two decimals
	String bmiString = String.format("%.2f", bmi);
	// prepare string for message dialog
	String result = bmiString+". Your result is : "+resultString;
	// display result
	JOptionPane.showMessageDialog(null, "Hello your bmi is: " + result);
    }
}
