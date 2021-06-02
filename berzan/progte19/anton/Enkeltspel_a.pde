import javax.swing.JOptionPane;

void setup() {
  size(200, 150);
  String tal1 = JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20");
  String tal2 = JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20");
  int talet = int(tal1);
  int taltva = int(tal2);

  if (talet + taltva >= 2 * talet) {
    fill(255,0,0);
    text("Grattis! Du vann", 20, 75);
  }
  else{
    fill(255,0,0);
    text("Tyvärr! Du förlorade", 20, 75);
  }
}
