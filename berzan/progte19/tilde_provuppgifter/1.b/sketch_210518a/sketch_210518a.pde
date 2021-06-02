import javax.swing.*;

int tal1;
int tal2;

void setup(){
  int tal1= int(JOptionPane.showInputDialog("tal 1:Ange ett heltal tal mellan 10 och 20"));
  
  if(tal1<10 || tal1>20){
    tal1= int(JOptionPane.showInputDialog("tal1: Ange ett heltal tal mellan 10 och 20"));
  }
  else{
    int tal2= int(JOptionPane.showInputDialog("tal 2:Ange ett till heltal tal mellan 10 och 20"));
  }
  
  if(tal2<10 || tal2>20){
    tal2= int(JOptionPane.showInputDialog("tal 2:Ange ett till heltal tal mellan 10 och 20"));
  }
    
  
  if(tal1+tal2 >= 2*tal1){
    text("Du vann", 20,20);
  }
  else{
    text("Du förlorade", 20,20);
  }
}
