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
