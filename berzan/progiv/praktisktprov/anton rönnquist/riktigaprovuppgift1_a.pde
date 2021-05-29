import javax.swing.JOptionPane;


void setup(){
  size(400,400);
  String ett= JOptionPane.showInputDialog("skriv in ett tal mellan 10 och 20");
  String tva= JOptionPane.showInputDialog("skriv in ett tal mellan 10 och 20");
  int tal1= int(ett);
  int tal2= int(tva);
  fill(255,0,0);
  if(tal1+ tal2>=2*tal1){text("du vann",100,100);
  }
  else{text("tyvärr du förlorade",100,100);
}
}
