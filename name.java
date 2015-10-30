// name.java
import java.util.Scanner;
class Name
{
    public static void main (String[] args)
    {
	System.out.print("Vad heter du? ");
	Scanner user_input = new Scanner( System.in );
	String name;
	name = user_input.next( );
	System.out.println ("Hej " + name);
    }
}
