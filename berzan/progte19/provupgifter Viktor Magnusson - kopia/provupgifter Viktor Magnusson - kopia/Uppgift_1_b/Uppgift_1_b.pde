import javax.swing.JOptionPane;
void setup() {
  size(500,500);
  int nr1 = 0;
  int nr2 = 0;
  while (!(nr1 <=20 && nr1 >= 10)){
  nr1 = int(JOptionPane.showInputDialog("Skriv FÖRSTA heltal mellan 10 och 20"));
  }
  while (!(nr2 <=20 && nr2 >= 10)){
  nr2 = int(JOptionPane.showInputDialog("Skriv ANDRA heltal mellan 10 och 20"));
  }
  if (nr1 + nr2 >= 2*nr1){
    text("Du vann!",250,250);
  } else {
    text("Du Förlorade :(",250,250);
  }
}
