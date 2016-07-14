// hello.java
import javax.swing.*;
import java.util.Arrays;

class hello
{
    public static void print ()
    {
	int tal = 7;
	int tal2 = tal + 3;
	System.out.println(tal + tal2);
	String hello = "Hello Worldåäö";

	int [][] array = {{1, 2, 3},
			  {4, 5, 6},
			  {7, 8, 9}};
	System.out.println("2 1 ar " + array[2][1]);

	System.out.println("0 0 ar " + array[0][0]);
	System.out.println("0 1 ar " + array[0][1]);
	System.out.println("1 0 ar " + array[1][0]);


	System.out.println (hello.length());
	int number = 11;//ath.rand(1, 200);
	if (number > 9) {
	    System.out.println("At least two digits");
	    if (number > 99)
		System.out.println("Three digits");
	}
	else
	    System.out.println("One digit");

	int[] arr = new int[10];
	int tal3 = 3;
	for (int x = 0; x < arr.length; x++)
	    arr[x] = x + tal3++;
	
	System.out.println("Arrayen: ");
	for (int x : arr){
	    System.out.print(x + " ");
	    if (x%3 == 0)
		System.out.println();
	}

    }
	

   public static void main (String[] args)
    {
	System.out.println("vilka argument?? "+Arrays.toString(args));
	print();
    }
}
