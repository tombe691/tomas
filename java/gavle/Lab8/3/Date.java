class Date {
    private static int[] ymd = new int[3];
    protected Date (int year, int month, int day) {
        this.ymd[0] = year;
        this.ymd[1] = month;
        this.ymd[2] = day;
    }
    // Kod borttaget
    protected int[] getDate () {
        return this.ymd;
    }
    public void printDate () {
        System.out.println (ymd[0] + "-" + ymd[1] + "-" + ymd[2]);
    }
}
/*
När programmet körs skrivs följande ut:

2015-5-11
2015-5-35

Det som är problemet är att det är fritt fram att modifiera datum efteråt, dag 35 finns inte.

Eftersom klassen är public och innehållet synligt kan i princip all använding av klassen också ändra den. För att hindra detta behöver den skyddas genom att sättas som private och bara kunn accessa den genom get och set-metoder.
*/
