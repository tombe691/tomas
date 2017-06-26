
import javax.swing.*;


public class Main {
    public static int ParseChoice(String option){
        int chosenProduct = Integer.parseInt(option);
        return chosenProduct;
    }

    public static int ChooseProduct(String introtext){
        String choice = JOptionPane.showInputDialog(introtext+" vad vill du kopa?\n 1.Dator\n" +
                "2.Skrivare\n3.Bildskarm\n4.Minne\n"+
                "Skriv in numret pa det du vill kopa");
        int chosenProduct = ParseChoice(choice);

        return chosenProduct;
    }

    /*Method to set price and name*/
    public static double SetPrice(int chosenProduct) {
        double price = 0;
        if (chosenProduct==1) {
            price = 2995;
        }
        else if (chosenProduct==2){
            price = 1234;
        }
        else if (chosenProduct==3){
            price = 2100;
        }
        else if (chosenProduct==4){
            price = 499;
        }
        return price;
    }
    public static String SetName(int chosenProduct) {
        String product = "";
        if (chosenProduct==1) {
            product = "dator";
        }
        else if (chosenProduct==2){
            product = "skrivare";
        }
        else if (chosenProduct==3){
            product = "skarm";
        }
        else if (chosenProduct==4){
            product = "minne";
        }
        return product;
    }

    //method to calculate totalPrice
    public static double calcTotPrice(double price, double price2){
        double sum = price+price2;
        return sum;
    }
    //method to calculate Vat
    public static double calcPriceMinusVat(double sum){
        sum *=0.75;
        JOptionPane.showMessageDialog(null, "Ditt pris utan moms blir: "+String.format("%.2f", sum));
        return sum;
    }
    //method to calculate discount
    public static double calcPriceAfterDiscount(double sum){
        sum *=0.93;
        JOptionPane.showMessageDialog(null, "Ditt pris efter rabatt blir: "+String.format("%.2f", sum));
        return sum;
    }

    public static void main(String[] args) {
        int chosenProduct = ChooseProduct("Valkommen till datakiosken " + "har finns olika saker att kopa" );
        double price = SetPrice(chosenProduct);
        String product = SetName(chosenProduct);
        int buyMore = JOptionPane.showConfirmDialog(null, "Vill du kopa nagot mer?", "Kopa mer", JOptionPane.YES_NO_OPTION);
        System.out.println(buyMore);
        double price2 = 0;
        String product2 = "";
        if (buyMore==0){
            int chosenProduct2 = ChooseProduct("" );
            price2 = SetPrice(chosenProduct2);
            product2 = SetName(chosenProduct2);
        }
        double sum = calcTotPrice(price, price2);
        String article = "Du har kopt en:\n"+product+" \t\t pris "+price;
        if (price2!=0) {
            article += "\n"+product2+" \t\t pris "+price2;
        }
        JOptionPane.showMessageDialog(null, article+"\nditt pris med moms blir: "+sum);
        int studentDiscount = JOptionPane.showConfirmDialog(null, "Studenter far 7% rabatt, ar du student?", "Rabatt", JOptionPane.YES_NO_OPTION);
        if (studentDiscount==0){
            sum = calcPriceAfterDiscount(sum);
        }
        int showVAT = JOptionPane.showConfirmDialog(null, "Moms ar 25%. Vill du se pris utan moms?", "Moms", JOptionPane.YES_NO_OPTION);
        if (showVAT==0){
            sum = calcPriceMinusVat(sum);
        }
    }
}
/*
import javax.swing.*;

public class Main {
    public static void main(String[] args) {
        // Deklarerade strängvariabler för produkterna som finns.
        // Dessa namn används på 2 ställen i koden, så om vi behöver ändra t ex namnet på en produkt så kan vi göra det här en gång istället för 2 gånger i koden.
        String dator = "Dator";
        String skrivare = "Skrivare";
        String skarm = "Skarm";
        String minne = "Minne";


        String choice = JOptionPane.showInputDialog("Valkommen till datakiosken \n " +
                "har finns olika saker att kopa\n vad vill du kopa?\n 1."+dator+"\n" +
                "2."+skrivare+"\n3."+skarm+"\n4."+minne+"\n"+
                "Skriv in numret pa det du vill kopa");
        int chosenProduct = Integer.parseInt(choice);
        double price = 0;
        String product = "";
        if (chosenProduct==1) {
            price = 2995;
            product = "dator";
        }
        else if (chosenProduct==2){
            price = 1234;
            product = "skrivare";
        }
        else if (chosenProduct==3){
            price = 2100;
            product = "skarm";
        }
        else if (chosenProduct==4){
            price = 499;
            product = "minne";
        }
        int buyMore = JOptionPane.showConfirmDialog(null, "Vill du kopa nagot mer?", "Kopa mer", JOptionPane.YES_NO_OPTION);
        System.out.println(buyMore);
        double price2 = 0;
        String product2 = "";
        if (buyMore==0){
            String choice2 = JOptionPane.showInputDialog("vad vill du kopa?\n 1."+dator+"\n2."+skrivare+"\n3."+skarm+"\n4."+minne+"\nSkriv in numret pa det du vill kopa");
            int chosenProduct2 = Integer.parseInt(choice2);
            if (chosenProduct2==1) {
                price2 = 2995;
                product2 = "dator";
            }
            else if (chosenProduct2==2){
                price2 = 1234;
                product2 = "skrivare";
            }
            else if (chosenProduct2==3){
                price2 = 2100;
                product2 = "skarm";
            }
            else if (chosenProduct2==4){
                price2 = 499;
                product2 = "minne";
            }

        }

        double sum = sum(price, price2);
        String article = "Du har kopt en:\n"+product+" \t\t pris "+price;
        if (price2!=0) {
            article += "\n"+product2+" \t\t pris "+price2;
        }
        JOptionPane.showMessageDialog(null, article+"\nditt pris med moms blir: "+sum);
        int studentDiscount = JOptionPane.showConfirmDialog(null, "Studenter far 7% rabatt, ar du student?", "Rabatt", JOptionPane.YES_NO_OPTION);
        if (studentDiscount==0){
            sum = studentdiscount(sum);
            JOptionPane.showMessageDialog(null, "Ditt pris med moms blir efter rabatt: "+String.format("%.2f", sum));
        }
        int showVAT = JOptionPane.showConfirmDialog(null, "Moms ar 25%. Vill du se pris utan moms?", "Moms", JOptionPane.YES_NO_OPTION);
        if (showVAT==0){
            sum = noVat(sum);
            JOptionPane.showMessageDialog(null, "Ditt pris utan moms blir: "+String.format("%.2f", sum));
        }
    }

    // Metod  för att visa pris utan moms
    public static double noVat(double price){
        // Ändrade värdet från 0.75 till 0.8 eftersom att om varan har 25% moms så räknar man med 0.8x.
        // T e x 100 + moms = 125. 125 - moms = 125 * 0.8 = 100.
        // IntelliJ säger att "The value 0.8 assigned to price is never used, men koden fungerar, så ignorera det.
        return price*=0.8;
    }

    // Metod för att lägga till studentrabbat
    public static double studentdiscount(double price){
        // IntelliJ säger att "The value 0.8 assigned to price is never used, men koden fungerar, så ignorera det.
        return price*=0.93;
    }

    // Metod för att addera 2st priser.
    public static double sum(double one, double two){
        return one + two;
    }



}
*/
