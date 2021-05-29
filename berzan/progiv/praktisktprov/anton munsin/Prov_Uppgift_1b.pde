import javax.swing.JOptionPane;
void setup() {
  size(200, 200);
  background(0);
  textSize(15);

  String tal1 = JOptionPane.showInputDialog("Ange ditt första heltal mellan 10 och 20");
  int tal1i = int(tal1);
 
  while (tal1i < 10 || tal1i > 20){
    String tal1b = JOptionPane.showInputDialog("Ditt tal MÅSTE vara mellan 10 och 20");
    int tal1bi = int(tal1b);
    tal1i = tal1bi;
  }
  
  
  
String tal2 = JOptionPane.showInputDialog("Ange ditt Andra heltal mellan 10 och 20");
int tal2i = int(tal2);

while (tal2i < 10 || tal2i > 20){
    String tal2b = JOptionPane.showInputDialog("Ditt tal MÅSTE vara mellan 10 och 20");
    int tal2bi = int(tal2b);
    tal2i = tal2bi;
  }



  if (tal1i + tal2i >= 2 * tal1i) {
    fill(#1CFF00);
    text("Grattis! Du vann", 20, 50, 180, 180);
  } else {
    fill(#FA0000);
    text("Tyvärr! Du förlorade", 20, 50, 180, 180);
  }
}
