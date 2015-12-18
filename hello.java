// hello.java
import javax.swing.*;
class Hello
{
    public static void print ()
    {
	String hello = "Hello Worldåäö";
	System.out.println (hello.length());
	int number = 11;//ath.rand(1, 200);
	if (number > 9) {
	    System.out.println("At least two digits");
	    if (number > 99)
		System.out.println("Three digits");
	}
	else
	    System.out.println("One digit");
    }
	

   public static void main (String[] args)
    {
	System.out.println("One digit");
	print();
    }
}
