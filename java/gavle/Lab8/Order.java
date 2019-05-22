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
    // Fler metoder...
}


/*import java.util.*;  

class Order{  
    private

    //creating arraylist  
	ArrayList<OrderLine> al=new ArrayList<OrderLine>();  
	//Getting Iterator  
	Iterator itr=al.iterator();  
	//traversing elements of ArrayList object  
	while(itr.hasNext()){  
	    OrderLine ol=(OrderLine)itr.next();  
	    System.out.println(ol.articleID+" "+ol.quantity+" "+
			       ol.pricePerPiece+" "+ol.taxRate);  
	}  
    }  
}  
*/
