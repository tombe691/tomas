// hello.java
import javax.swing.*;
class Hello
{
    public static void print ()
    {
	int[] arr = new int[10];
	int tal = 0;
	for (int x = 20; x > arr.length; x--) {
	    
	    int tal2 = x - tal++;
	    System.out.println(tal2);
	    arr[x-11] = tal2;
	}
	System.out.println("Arrayen: ");
	System.out.println(arr[0]);
	System.out.println(arr[9]);
	for (int x : arr){

	    System.out.print(x + " ");
	    if (x%2 == 0)
		System.out.println();
	}
	String hello = "Hello Worldåäö";
	//System.out.println (hello.length());
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
