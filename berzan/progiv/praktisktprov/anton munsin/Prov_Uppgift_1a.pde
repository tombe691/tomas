import javax.swing.JOptionPane;
void setup() {
  size(200, 200);
  background(0);
  textSize(15);

  String tal1 = JOptionPane.showInputDialog("Ange ditt första heltal mellan 10 och 20");

  String tal2 = JOptionPane.showInputDialog("Ange ditt Andra heltal mellan 10 och 20");

  int tal1i = int(tal1);
  int tal2i = int(tal2);

  if (tal1i + tal2i >= 2 * tal1i) {
    fill(#1CFF00);
    text("Grattis! Du vann", 20, 50, 180, 180);
  } else {
    fill(#FA0000);
    text("Tyvärr! Du förlorade", 20, 50, 180, 180);
  }
}
