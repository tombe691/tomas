import javax.swing.*;

public class Ovning57 {
    public static void main (String[] arg) {
        double term = 1,
                sum  = 1;
        int tecken = 1;

        for (int k=2; Math.abs(term)>=1.0e-1; k++) { 	//varför startar med k=2 ???
	    System.out.println("k =" + k);
	    System.out.println("term =" + term);
	    System.out.println("sum =" + sum);

            tecken = -tecken;			                       // varför -tecken ???
            term = tecken * 1.0/k;			              // -1 *1.o/2  ???
            sum = sum + term;
        }
        JOptionPane.showMessageDialog(null, "Summan blir: " + sum);
    }
}
