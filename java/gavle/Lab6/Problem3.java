/*
  Uppgift3
  Hur värden lämnas över till metoder.
  Tomas Berggren, tombe691@gmail.com
  2019-04-08
*/


public class Problem3 {
    //3 a ett värde lämnas här över "by value", dvs det som kommer
    //in är ett tal som är en kopia på det värde som skickades in
    //ett alternativ som flera andra språk använder är "by reference"
    //då skickas minnesadressen till variabeln in istället och de
    //ändringar som görs påverkar även utanför metoden
    public static int sum(int startValue, int size){
	int sum = 0;
	for(int i=startValue; i<(size+startValue); i++) {
	    sum +=i;
	}
	return sum;
    }
    //3 b parameter skickas in till den här metoden när den
    //anropas från main, argument är det som tas emot, dvs
    //samma värde men det ena skickas och det andra tas emot
    public static int product(int startValue, int size){
	int product = 1;
	for(int i=startValue; i<(size+startValue); i++) {
	    product *=i;
	}
	return product;
    }
    //3 c koden måste veta om den ska skicka tillbaka något och i
    // så fall vilken typ. mainmetoden i det här fallet är void eftersom den
    //inte returnerar något. Metoden sum och product är i den här
    //uppgiften av typen int och returnerar då ett heltal som tas
    //emot där metoden anropas
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
