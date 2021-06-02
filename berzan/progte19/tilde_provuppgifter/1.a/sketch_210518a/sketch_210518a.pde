import javax.swing.*;

void setup(){
  int tal1= int(JOptionPane.showInputDialog("Ange ett heltal tal mellan 10 och 20"));
  int tal2= int(JOptionPane.showInputDialog("Ange ett till heltal tal mellan 10 och 20"));
  
  if(tal1+tal2 >= 2*tal1){
    text("Du vann", 20,20);
  }
  else{
    text("Du förlorade", 20,20);
  }
}
