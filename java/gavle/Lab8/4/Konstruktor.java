/*
  Uppgift4
  Vad är en konstruktor.
  Tomas Berggren, tombe691@gmail.com
  2019-05-30
*/


public class Konstruktor {
    // Instance Variables
    int number;
    String name;
    String adress;
    int points;
    // detta är konstruktorn, en metod som skapar en instans av klassen
    // det kan vara en tom klass men det kan också finnas parametrar som
    //sätter värden på något eller flera av de attribut som finns i klassen
    public Konstruktor(int num, String studentName, String studentAdress, int schoolPoints) {
	number = num;
	name = studentName;
	adress = studentAdress;
	points = schoolPoints;
    }

    // method 1
    public String getInfo() {
        return ("Student is: number "+number+" Name is: "+name+" Adress is: "+adress+" points are: "+points);
    }
    

    public static void main(String[] args) {
	// när man anropar konstruktorn skickar man med det som efterfrågas och
	//får tillbaka ett objekt
        Problem2 student2 = new Problem2(2, "pelle", "stigen", 25);
	System.out.println(student2.getInfo());
    }
}
