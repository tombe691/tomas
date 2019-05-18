import java.util.*;  

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
