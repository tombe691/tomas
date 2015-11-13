// hello.java
import javax.swing.*;
class Hello
{
    public static void print ()
    {
	UIManager.setLookAndFeel(UIManager.getCrossPlatformLookAndFeelClassName());
	int k;
	for (k=0; k<6;k=k+2) {
	    System.out.println ("10 upphojt till 3 = " + Math.pow(10.0, 3.0));
	    JOptionPane.showMessageDialog(null, "Hello World!");
	    }
    }
    public static void main (String[] args)
    {
	print();
    }
}
