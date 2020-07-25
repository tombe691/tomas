// Filen AaAeOe.java

import java.io.*;

public class readfile { 

  public static void main(String[] arg) throws IOException {

    BufferedReader tangentbord = new BufferedReader
                            (new InputStreamReader(System.in));
    System.out.print("Vad heter filen? "); System.out.flush();
    String namn = tangentbord.readLine();
    BufferedReader instream = new BufferedReader
                            (new FileReader(namn));

    while(true) {
      String s = instream.readLine();
      if (s == null)
        break;
    }
  }
}
