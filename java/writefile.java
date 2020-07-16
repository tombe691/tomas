// Filen SokText.java

import javax.swing.*;
import java.io.*;  

public class writefile { 
  public static void main(String[] arg) throws IOException {
    String namn1 = JOptionPane.showInputDialog("Vad heter den befintliga filen?");
    BufferedReader instream = new BufferedReader
                            (new FileReader(namn1));
    String namn2 = JOptionPane.showInputDialog("Vad skall den nya filen heta?");
    PrintWriter outstream = new PrintWriter
                     (new BufferedWriter
                     (new FileWriter(namn2)));
    String txt = JOptionPane.showInputDialog("Vilken text söker du?");

    while(true) {
      String s = instream.readLine();
      if (s == null)
        break;
      if (s.indexOf(txt) >= 0)
        outstream.println(s); 
    }
    instream.close();
    outstream.close();
  }
}
  