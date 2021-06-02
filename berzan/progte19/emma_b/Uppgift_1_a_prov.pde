import javax.swing.JOptionPane;

void setup(){
  String Str1 = JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20");
  String Str2 = JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20");
  int tal1 = int(Str1);
  int tal2 = int(Str2);
  
  if((tal1 + tal2) >= (2*tal1)){
    text("Grattis! Du vann", 10, 10);
  }
  else {
    text(" Tvyärr! Du förlorade", 10, 10);
  }
}
