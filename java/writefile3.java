
import java.io.*;

public class writefile3 { 

  public static void main(String[] arg) throws IOException {

    BufferedReader tangentbord = new BufferedReader
                            (new InputStreamReader(System.in));
    System.out.print("Vad ska den nya filen heta? "); System.out.flush();
    String namn2 = tangentbord.readLine();
    PrintWriter outstream = new PrintWriter
                     (new BufferedWriter
                     (new FileWriter(namn2)));
    System.out.print("Vilken text vill du skriva? "); System.out.flush();
    String txt = tangentbord.readLine();
    outstream.println(txt); 
    outstream.close();
  }
}