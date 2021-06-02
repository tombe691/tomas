import javax.swing.JOptionPane;
  
void setup() {
  size(400, 400); 

  int tal1 = int(JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20"));
  int tal2 = int(JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20"));

  if (tal1 + tal2 >= 2 * tal2) {
    text("Du vinner",200, 200);
  } else {
    text("Tyvärr du förlorar!", 150, 200);
  }
}
