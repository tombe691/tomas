import java.util.ArrayList;

public class Order {
    private int orderID;
    private String orderDate;
    private String customerID;
    private String deliveryAddress;

    private ArrayList<OrderLine> orderList = new ArrayList<OrderLine> ();

    public Order (int orderID,
                  String orderDate,
                  String customerID,
                  String deliveryAddress) {
        this.orderID=orderID;
        this.orderDate=orderDate;
        this.customerID=customerID;
        this.deliveryAddress=deliveryAddress;

        // Uppgift: L¨agg till kod f¨or att ¨overf¨ora // v¨ardena fr˚an parametrarna till instansvariablerna
    }
    public void addOrderLine(int articleID,
                             int quantity,
                             double pricePerPiece,
                             double taxRate) {
        OrderLine orderLine = new OrderLine (articleID,
                quantity,
                pricePerPiece,
                taxRate);
        orderList.add (orderLine); // L¨agg till raden till listan
    }
    public void printOrderLines() {
        for (OrderLine line: orderList) {
            System.out.println(line.articleID+" "+line.quantity+" "+
                    line.pricePerPiece+" "+line.taxRate+" Totalprice:"+line.getPrice());
        }

    }
    public void printOrder() {
        System.out.println(this.orderID+" "+this.orderDate+" "+
                    this.customerID+" "+this.deliveryAddress);
        }
    public double getTotalPrice() {
        double price = 0;
        for (OrderLine line: orderList) {
            price+=line.getPrice();
        }
        return price;
    }
    // Fler metoder...
}
