// Filen Kommentarer.java
import java.io.*;
import javax.swing.*;

public class Ovning101 {
 public static void main(String[] arg) throws IOException {
    String filnamn = JOptionPane.showInputDialog
                     ("Vad heter filen med Javaprogrammet?");
    BufferedReader inström = new BufferedReader
                            (new FileReader(filnamn));
    int n = 0,    // totala antalet rader i filen
        k = 0;    // antalet rader med kommentarer
    while (true) {
      String rad = inström.readLine();
      System.out.println(rad);
      if (rad == null)  // är filen slut?
        break;   // ja!
      n++;   // nej
      if (rad.indexOf("//") >= 0)
        k++;   // kommentar finns på raden
    }
    JOptionPane.showMessageDialog
       (null, 100.0*k/n + " % av raderna innehåller kommentarer");
  }       
}
