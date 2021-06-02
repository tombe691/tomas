import javax.swing.JOptionPane;

void setup() {
  size(200, 150);
  String tal1 = JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20");
  int talet = int(tal1);

  while (talet < 10 || talet > 20) {
    tal1 = JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20");
    talet = int(tal1);
  }
  String tal2 = JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20");
  int taltva = int(tal2);

  while (taltva < 10 || taltva > 20) {
    tal2 = JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20");
    taltva = int(tal2);
  }

  if (talet + taltva >= 2 * talet) {
    fill(255, 0, 0);
    text("Grattis! Du vann", 20, 75);
  } else {
    fill(255, 0, 0);
    text("Tyvärr! Du förlorade", 20, 75);
  }
}
