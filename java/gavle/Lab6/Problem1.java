/*
  Uppgift1
  Skriv ut från metod.
  Tomas Berggren, tombe691@gmail.com
  2019-04-08
*/


public class Problem1 {
    //1 a
    public static void numberLine(){
        int size = 10;
	for(int i=1; i<=size; i++) {
	    System.out.print(i+" ");
	}
    }
    //1 b
    public static void numberLine(int startValue, int size){
	for(int i=startValue; i<(size+startValue); i++) {
	    System.out.print(i+" ");
	}
    }
    //1 c
    // båda metoderna i samma klass med samma namn,
    //överlagrade då de har olika inparametrar
    public static void main (String[] args) {
	numberLine();
	System.out.println();
	numberLine(3, 5);
    }
}
