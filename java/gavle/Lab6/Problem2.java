/*
  Uppgift1
  Addera och multiplicera med metoder.
  Tomas Berggren, tombe691@gmail.com
  2019-04-08
*/


public class Problem2 {
    //2 a
    public static int sum(int startValue, int size){
	int sum = 0;
	for(int i=startValue; i<(size+startValue); i++) {
	    sum +=i;
	}
	return sum;
    }
    //2 b
    public static int product(int startValue, int size){
	int product = 1;
	for(int i=startValue; i<(size+startValue); i++) {
	    product *=i;
	}
	return product;
    }
    public static void main (String[] args) {
	int totalSum = sum(4, 6);
	System.out.println(totalSum);
	totalSum = sum(1, 10);
	System.out.println(totalSum);
	totalSum = sum(10, 5);
	System.out.println(totalSum);
	int totalProduct = product(4, 6);
	System.out.println(totalProduct);
	totalProduct = product(1, 10);
	System.out.println(totalProduct);
	totalProduct = product(10, 5);
	System.out.println(totalProduct);
    }
}
