
/*
  Uppgift3
  ArrayTools.
  Tomas Berggren, tombe691@gmail.com
  2019-05-08
*/
import java.util.Arrays;
//import java.util.*;

public class ArrayTools {
    // Driver method 
    /*    public static void main(String args[])  
    { 
        int arr[] = createIntArray(3); 

	arr[0] = 45;
	arr[1] = 1;
	arr[2] = 67;

	printIntArray(arr);
	int min = getMinInt(arr);
	System.out.print(min);
	int max = getMaxInt(arr);
	System.out.print(max);
	int find = containsIntElement(arr, 1);
	System.out.print(find);
	} */
  
    public static int[] createIntArray(int l)  
    { 
        // returning  array
	int[] arr = new int[l]; 
        return arr; 
    }

    public static void printIntArray(int[] arr)  
    {
        for (int i = 0; i < arr.length; i++) 
            System.out.print(arr[i]+" "); 
    } 

    public static int getMinInt(int[] arr)  
    {
	int arrcopy[] = arr.clone();
	Arrays.sort(arrcopy);
	return arrcopy[0];
    } 

        public static int getMaxInt(int[] arr)  
    {
	int arrcopy[] = arr.clone();
	Arrays.sort(arrcopy);
	return arrcopy[arrcopy.length-1];
    }
    public static int containsIntElement(int[] arr, int val)  
    {
	int pos = -1;
	for (int i = 0; i < arr.length; i++) {
	    if (val == arr[i]){
		pos = i;
	    }
	}
	return pos;
    } 
}
