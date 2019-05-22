public class Main {

    public static void main(String[] args) {
        System.out.println("Hello World!");
        Order order1 = new Order(1, "123", "345", "adress");
        order1.addOrderLine(1234, 1, 10, 25);
        order1.addOrderLine(2345, 3, 13, 20);

        order1.printOrder();
        order1.printOrderLines();
        System.out.println("total "+order1.getTotalPrice());
    }
}
