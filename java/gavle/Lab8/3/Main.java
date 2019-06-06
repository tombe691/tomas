public class Main {

    public static void main(String[] args) {
        Date date = new Date (2015, 5, 11);
        date.printDate ();
        int[] dateValue = date.getDate ();
        dateValue[2] = 35;
        date.printDate ();
    }
}
