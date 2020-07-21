// Filen AaAeOe.java

import java.io.*;

public class writefile2 { 

  public static void main(String[] arg) throws IOException {

    BufferedReader tangentbord = new BufferedReader
                            (new InputStreamReader(System.in));
    System.out.print("Vad heter filen? "); System.out.flush();
    String namn1 = tangentbord.readLine();
    BufferedReader instream = new BufferedReader
                            (new FileReader(namn1));
    System.out.print("Vad ska den nya filen heta? "); System.out.flush();
    String namn2 = tangentbord.readLine();
    PrintWriter outstream = new PrintWriter
                     (new BufferedWriter
                     (new FileWriter(namn2)));
    System.out.print("Vilken text soker du? "); System.out.flush();
    String txt = tangentbord.readLine();
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