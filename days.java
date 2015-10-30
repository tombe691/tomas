// days.java
import java.util.Scanner;
class Days
{
    public static void print ()
    {
	System.out.print("Skriv in en månad: ");
	Scanner user_input = new Scanner( System.in );
	String month;
	month = user_input.next( );
	if (month.equals("november") || month.equals("april") || 
	    month.equals("juni") || month.equals("september"))
	    System.out.println (month + " has " + 30);
	else if (month.equals("februari"))
	    System.out.println (month + " has " + 28);
	else if (month.equals("januari") || month.equals("mars") || 
	    month.equals("maj") || month.equals("juli") || 
		 month.equals("augusti") || month.equals("oktober") || 
		 month.equals("december"))
	    System.out.println (month + " has " + 31);
	else
	    System.out.println ("något är fel med namnet " + month);
    }
    public static void main (String[] args)
    {
	print();
    }
}
