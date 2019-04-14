/*
  Uppgift5
  kolla om arrayen är sorterad.
  Tomas Berggren, tombe691@gmail.com
  2019-04-10
*/


public class Problem5 {
    //printout method
    public static void printArray(int[] intArray){
	System.out.format("\nprint array\n");
	for (int i = 0; i < intArray.length; i++) {
	    System.out.println(intArray[i]);
	}
	System.out.println("end print array");
    }
    //5 method checking if sorted
    public static int isSorted(int[] intArray){
	int result = 0;
	int end = intArray.length-1;
	int pos = 0;
	boolean found = false;
	while (pos<end) {
	    if (intArray[pos]<intArray[pos+1]){
		result = 1;
	    }
	    else {
		result = 0;
		break;
	    }
	    pos++;
	}
	if (result==1) {
	    found = true;
	}
	else {
	    pos = 0;
	    while (pos<end) {
		if (intArray[pos]>intArray[pos+1]){
		    result = -1;
		}
		else {
		    result = 0;
		    break;
		}
		pos++;
	    }
	}
	System.out.println(result);
	return result;
    }

    //startmetod
    public static void main (String[] args) {
	int myArray1[] = {1, 7, 2, 4, 2, 5, 2, 3, 8, 3, 9, 3, 4};
	int myArray2[] = {1, 2, 3, 4, 5, 6, 7, 8, 9};
	int myArray3[] = {9, 8, 7, 6, 5, 4, 3, 2, 1};
	int sorted;
	sorted = isSorted(myArray1);
	sorted = isSorted(myArray2);
	sorted = isSorted(myArray3);
    }
}
