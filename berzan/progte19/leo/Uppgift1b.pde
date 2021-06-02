import javax.swing.*;

void setup() {
  size(500, 500);

  int tal1 = int(JOptionPane.showInputDialog("Ange första heltalet mellan 10 och 20"));
  int tal2 = int(JOptionPane.showInputDialog("Ange andra heltalet mellan 10 och 20"));

  if (tal1 > 9 && tal1 < 21) {
    if (tal2 > 9 && tal2 < 21) {
      if (tal1 + tal2 >= 2 * tal1) {
        text("Bra jobbat! Du vann", 250, 250);
      }
      else {
        text("Tyvärr! Du förlorade", 250, 250);
      }
    }
    else {
      text("ERROR", 250, 250);
    }
  }
  else {
    text("ERROR", 250, 250);
  }
}
