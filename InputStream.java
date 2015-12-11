import java.io.*;
import java.util.*;
import javax.swing.*;

public class InputStream {

  public static void main (String[] arg) throws IOException {

      BufferedReader input = new BufferedReader(new InputStreamReader(System.in));
      System.out.println("Vad heter textfilen?");
      String firstName = input.readLine();

      JFileChooser fc = new JFileChooser();
      int resultat = fc.showOpenDialog(null);
      String filename = fc.getSelectedFile().getAbsolutePath();
      System.out.println("Filen heter " + filename);

      Scanner sc = new Scanner(System.in);
      
      String sureName;
      sureName = sc.next( );
      System.out.printf("Hej %s %s", firstName, sureName);
      
  }
}
