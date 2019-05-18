import java.util.*;  
public class Problem12{
    public static void main(String args[]){  
	//Creating user-defined class objects  
	Order o1=new Order();
	OrderLine o1=new OrderLine(101, 10, 5.5, 25);  
	OrderLine o2=new OrderLine(102, 15, 7.5, 20);  
	OrderLine o3=new OrderLine(103, 20, 8.0, 6);

	o1.al.add(o1);//adding OrderLine class object  
	o1.al.add(o2);  
	o1.al.add(o3);

	Iterator itr=ol.al.iterator();
	while(itr.hasNext()){  
	    OrderLine oli=(OrderLine)itr.next();  
	    System.out.println(oli.articleID+" "+oli.quantity+" "+
			       oli.pricePerPiece+" "+oli.taxRate);  
	}  
    }  
}

class OrderLine{  
    int articleID;  
    int quantity;  
    double pricePerPiece;
    double taxRate;
    
    OrderLine(int articleId, int quantity, double pricePerPiece, double taxRate){  
	this.articleID=articleID;  
	this.quantity=quantity;  
	this.pricePerPiece=pricePerPiece;
	this.taxRate=taxRate;
  }  
}  

class Order{  
    public static void main(String args[]){  
	//Creating user-defined class objects  

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
