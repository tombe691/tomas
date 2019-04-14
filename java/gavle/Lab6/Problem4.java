/*
  Uppgift4
  byt plats på arrayvärden.
  Tomas Berggren, tombe691@gmail.com
  2019-04-10
*/


public class Problem4 {
    //4 a byt plats på l och r
    public static void exchange(int[] intArray, int l, int r){
	int temp;
	if (l < intArray.length && r < intArray.length) {
	    temp = intArray[l];
	    intArray[l]=intArray[r];
	    intArray[r]=temp;
	}
    }
    //printout method
    public static void printArray(int[] intArray){
	System.out.format("\nprint array\n");
	for (int i = 0; i < intArray.length; i++) {
	    System.out.println(intArray[i]);
	}
	System.out.println("end print array");
    }
    //4 b boublesort
    public static void sortArray(int[] intArray){
	boolean swapped = true;
	int end = intArray.length-1;
	int pos = 0;
	while (swapped){
	    swapped = false;
	    pos = 0;
	    while (pos<end) {
		if (intArray[pos]>intArray[pos+1]){
		    exchange(intArray, pos, pos+1);
		    swapped = true;
		}
		pos++;
	    }
	}
    }

    //startmetod
    public static void main (String[] args) {
	int myArray[] = {1, 7, 2, 4, 2, 5, 2, 3, 8, 3, 9, 3, 4};
	printArray(myArray);
	exchange(myArray, 2, 5);
	printArray(myArray);
	sortArray(myArray);
	printArray(myArray);
    }
}
