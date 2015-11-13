// Filen Persontest.java

import javax.swing.*;

public class Pers {
    public static final int test = 1;
    public static void main(String[] arg) {
	print();
    }
    static String printText(String s) {
	String r = "";
	r = s + s;
	return r;
    }
    static void print() {
	int a = 1;
	JOptionPane.showMessageDialog(null, "Stämmer inte" + (Pers.test+a) + printText("Kalle "));
    }
}
