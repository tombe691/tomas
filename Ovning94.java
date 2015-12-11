// Filen MaxTal2

import java.io.*;

public class Ovning94 { 
  public static void main (String[] arg) throws IOException {
    BufferedReader input = new BufferedReader
                      (new InputStreamReader(System.in));
    String s = input.readLine();
    double störst = Double.parseDouble(s);   // första talet
    while (true) {
      s = input.readLine();
      if (s == null)
        break;
      double tal = Double.parseDouble(s);   // nästa tal 
      if (tal > störst)
        störst = tal;
    }
    System.out.println("Det största talet är " + störst); 
  } 
} 
