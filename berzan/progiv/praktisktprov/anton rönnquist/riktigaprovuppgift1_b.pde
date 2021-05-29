import javax.swing.JOptionPane;


void setup(){
  size(400,400);
    String ett= JOptionPane.showInputDialog("ange det första talet mellan 10 och 20");
    int tal1= int(ett);
      while(tal1<10||tal1>20){
      String nyttvarde= JOptionPane.showInputDialog("ange det första talet mellan 10 och 20");
      tal1=int(nyttvarde);
  }
  String tva= JOptionPane.showInputDialog("ange det andra talet mellan 10 och 20");
  int tal2= int(tva);
    while(tal2<10||tal2>20){
      String nyttvarde2= JOptionPane.showInputDialog("ange det andra talet mellan 10 och 20");
      tal2=int(nyttvarde2);
  }
  fill(255,0,0);
  if(tal1+ tal2>=2*tal1){text("du vann",100,100);
  }
  else{text("tyvärr du förlorade",100,100);
}
}
