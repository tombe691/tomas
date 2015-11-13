// Filen Simhopp.java

 import javax.swing.*;
 import java.util.*;
 
 public class Simhopp {
   public static void main (String[] arg) {
     String s = JOptionPane.showInputDialog("Antal domare?"); 
	 if (s == null)
       System.exit(0);
	 int n = Integer.parseInt(s);   
	 if (n < 3) {
	   JOptionPane.showMessageDialog(null, "Felaktigt antal domare?");
	   System.exit(0);
	 }	   
     while(true) {
       s = JOptionPane.showInputDialog("Hoppets svårighetsgrad?"); 
       if (s == null)
         break;
       double svårighet = Double.parseDouble(s);
       double sum = 0;
       double minPoäng=10;
       double maxPoäng=0;
	   int i;
	   for (i = 1; i <= n; i++)  {
         s = JOptionPane.showInputDialog("Ange poängen från domare nr " + i);
         if (s == null)
           break; 
	 double domarPoäng = Double.parseDouble(s);
         sum = sum + domarPoäng;
         maxPoäng = Math.max(maxPoäng, domarPoäng);
         minPoäng = Math.min(minPoäng, domarPoäng); 
	 System.out.println(domarPoäng);
	 System.out.println(maxPoäng);
	 System.out.println(minPoäng);
	 System.out.println(i);
	 System.out.println(n);
       }		 
       if (i == n+1) {
         sum = sum - maxPoäng - minPoäng; 
         double hoppPoäng = sum / (n-2) * 3 * svårighet;
         JOptionPane.showMessageDialog(null, "Hoppets poäng: " + hoppPoäng);
       }
       else 
         JOptionPane.showMessageDialog(null, "Domarpoäng saknas");
     }
   }
 }
