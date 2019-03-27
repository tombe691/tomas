import java.util.Scanner;


public class Uppgift2 {
    public static double ReadInput(String text){
        double side = 0;
        Scanner myObj = new Scanner(System.in);  // Create a Scanner object
        System.out.println("Mata in sida "+text+" :");
        if(myObj.hasNext()) {
            if (myObj.hasNextDouble()) {
                side = myObj.nextDouble();  // Read user input
                System.out.println("Sida "+text+" är: " + side);  // Output user input
            }
            else {
                System.out.println("Sida "+text+" är inte ett tal, du matade in: " + myObj.nextLine());  // Output user input
            }
        }
        else {
            System.out.println("Felaktig inmatning, returnerar 0");  // Output user input

        }
        return side;
    }
    public static void main (String[] args) {
        int a = 12;
        double side_a, side_b, area, diagonal;
        side_a = ReadInput("a");
        side_b = ReadInput("b");

        if (side_a * side_b > 0){
            area = side_a*side_b;
            System.out.println("Arean är: "+area);
        }
    }
}
