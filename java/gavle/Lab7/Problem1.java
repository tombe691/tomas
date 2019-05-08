
/*
  Uppgift1
  Skapa en klass för studenter som
  hanterar så kallade postobjekt.
  Tomas Berggren, tombe691@gmail.com
  2019-05-02
*/


public class Problem1 {
    // Instance Variables
    int number;
    String name;
    String adress;
    int points;

  
    // method 1
    public String getInfo() {
        return ("Student is: number "+number+" Name is: "+name+" Adress is: "+adress+" points are: "+points);
    }
    

    public static void main(String[] args) {
        Problem1 student1 = new Problem1();
        student1.number=1;
        student1.name="nisse";
        student1.adress="gatan";
        student1.points=10;
        System.out.println(student1.getInfo());
    }
}
