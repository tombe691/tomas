// Filen Klockan.java
import java.util.*;


public class Klockan {

  public static String klockan() {
    String s = Calendar.getInstance().getTime().toString();
    int i = s.indexOf(':');
    return s.substring(i-2, i+6);
  }

 }
