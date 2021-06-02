import javax.swing.JOptionPane;
void setup() {
  size(500,500);
  int nr1 = int(JOptionPane.showInputDialog("Skriv första heltal mellan 10 och 20"));
  int nr2 = int(JOptionPane.showInputDialog("Skriv andra heltal mellan 10 och 20"));
  if (nr1 + nr2 >= 2*nr1){
    text("Du vann!",250,250);
  } else {
    text("Du Förlorade :(",250,250);
  }
}
