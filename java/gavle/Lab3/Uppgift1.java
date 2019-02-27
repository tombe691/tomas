import java.math.BigDecimal;

public class Uppgift1 {

    public static void main (String[] args) {
        int a = 12;
        int b = 25;
        int c = -1;

        int a2 = a;
        int b2 = b;

//        ++b;  //ökar med 1 innan utskrift/beräkning
//        a--;  //minskar med 1 efter utskrift/beräkning
        //System.out.println(++b);
        //System.out.println(a--);
        System.out.println(-1*++b2*a2--);
        c *= ++b * a--;
        if (c % b == a + 2) {
            System.out.println("in if");
            c *= c;
        } else if (b % a == -c % a) {
            System.out.println("in else if b%a = "+ b % a +" -c % a = "+- c % a);
            System.out.println(c /= -1);
            //c /= -1;
        } else {
            System.out.println("in else");
            c += a - b;
        }
        System.out.println ("a: " + a + "; b: " + b + "; c: " + c);
        //a: 11; b: 26; c: 312

        int hundra = 100;
        int tusen = 1000;
        int tiotusen = 10000;
        //hundratusen måste ha en datatyp där alla siffror får plats
	//long är en int som har fler bytes att lagra stora tal i
        long hundratusen = 100000;
	// big decimal kan användas till stora flyttal i java
        BigDecimal hundratusenpunktnoll = new BigDecimal(100000.0);
	//blir fel då 100000 får fel typ
        System.out.println (100 * 1000 * 10000 * 100000);
	//blir rätt då 100000 hanteras på rätt sätt
        System.out.println(hundra * tusen * tiotusen * hundratusen); 
	//blir fel då 100000.0 får fel typ
        System.out.println (100 * 1000 * 10000 * 100000.0);
	//egen metod i klassen för att multiplicera BigDecimal
        System.out.println(hundratusenpunktnoll.multiply(new BigDecimal(hundra * tusen * tiotusen)));
    }
}
