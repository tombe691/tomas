
/*
  Uppgift2
  Vad är en konstruktor.
  Tomas Berggren, tombe691@gmail.com
  2019-05-02
*/


public class Problem2 {
    // Instance Variables
    int number;
    String name;
    String adress;
    int points;

    public Problem2(int num, String studentName, String studentAdress, int schoolPoints) {
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
        Problem2 student2 = new Problem2(2, "pelle", "stigen", 25);
	System.out.println(student2.getInfo());
    }
}
