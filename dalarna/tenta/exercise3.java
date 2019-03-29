/*
    Exercise3
    Sort array.
    Tomas Berggren, tombe691@gmail.com
    2019-03-28
*/

import javax.swing.*;
import java.util.Arrays;


class exercise3 {
    public static void main (String[] arg) {
	// define an array to store input
	String[] input = new String[3];
	// read input into the array
	input[0] = JOptionPane.showInputDialog(null, "enter first country:");
	input[1] = JOptionPane.showInputDialog(null, "enter second country:");
	input[2] = JOptionPane.showInputDialog(null, "enter third country:");
	// sort array
	Arrays.sort(input);
	// print sorted result
	JOptionPane.showMessageDialog(null, "Sorted order: "+"\n " + input[0]+"\n "+input[1]+"\n "+input[2]);
    }
}
