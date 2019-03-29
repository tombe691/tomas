/*
    Exercise4
    Determine numbers.
    Tomas Berggren, tombe691@gmail.com
    2019-03-28
*/

import javax.swing.*;
import java.util.Arrays;

class exercise4 {
    public static void main (String[] arg) {
	// define string and int arrays
	String[] inputStrArr = new String[5];
	int inputIntArr[] = new int[5];
	// read string input
	inputStrArr[0] = JOptionPane.showInputDialog(null, "enter first number:");
	inputStrArr[1] = JOptionPane.showInputDialog(null, "enter second number:");
	inputStrArr[2] = JOptionPane.showInputDialog(null, "enter third number:");
	inputStrArr[3] = JOptionPane.showInputDialog(null, "enter fourth number:");
	inputStrArr[4] = JOptionPane.showInputDialog(null, "enter fifth number:");
	// convert string input into integer and add to Int-array
	inputIntArr[0] = Integer.parseInt(inputStrArr[0]);	
	inputIntArr[1] = Integer.parseInt(inputStrArr[1]);	
	inputIntArr[2] = Integer.parseInt(inputStrArr[2]);	
	inputIntArr[3] = Integer.parseInt(inputStrArr[3]);	
	inputIntArr[4] = Integer.parseInt(inputStrArr[4]);	
	// sort int-array, not needed but make it easier to display result during test
	Arrays.sort(inputIntArr);
	// define output variables
	int negative = 0;
	int positive = 0;
	int zero = 0;
	// for-loop to go through array and count accurance of each sort
	for (int i = 0; i < 5;i++) {
	    if (inputIntArr[i] < 0) {
		negative++;
	    }
	    else if (inputIntArr[i] > 0) {
		positive++;
	    }
	    else if (inputIntArr[i] == 0) {
		zero++;
	    }
	}
	// display resulut
	JOptionPane.showMessageDialog(null, "Of the numbers inputed, \n" +
				      negative +" negative, \n "+positive+" positive and \n "+zero+" zero");
    }
}
