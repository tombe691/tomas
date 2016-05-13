import javax.swing.JOptionPane;
import java.text.DecimalFormat;

class Main {
    public static void main (String[] arg) {
        String s = JOptionPane.showInputDialog("Ange en radie:");
        String svar = "";
	//String test = "pi = %8.2f\n", Math.PI;
        JOptionPane.showMessageDialog(null, "Omkretsen ar:" + Double.parseDouble(s) * Math.PI);
	System.out.format("pi = %f\n", Math.PI);
	System.out.format("pi = %8.2f\n", Math.PI);
	double d = 1.234567;
	DecimalFormat df = new DecimalFormat("#.##");
	JOptionPane.showMessageDialog(null, "Your monthly payment is " + df.format(d));
	System.out.println(df.format(d));
	JOptionPane.showMessageDialog(null, String.format("Radius is $%.2f",  Math.PI));
	JOptionPane.showMessageDialog(null,"Radius is " + String.format("%.2f",Math.PI),"Radius",JOptionPane.PLAIN_MESSAGE);


    }
}