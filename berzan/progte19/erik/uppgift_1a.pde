import javax.swing.*;
void setup(){
  size(200,200);
  background(255);
  int tal1 = int(JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20"));
  int tal2 = int(JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20"));
  fill(255,0,0);
  if((tal1 + tal2) >= (2*tal1)){
    text("Grattis! Du vann",70,100);
  }
  else{
    text("Tyvärr! Du förlorade",70,100);
  }
}
  
