import javax.swing.JOptionPane;

void setup(){
  int tal1 = int(JOptionPane.showInputDialog("Skriv första talet:"));
  int tal2 = int(JOptionPane.showInputDialog("Skriv andra talet:"));
  if (tal1 > tal2){
    fill(0, 200, 0);
    text("Du van :)", 10,15);
  } else if (tal2 > tal1){
    fill(255, 0, 0);
    text("Du förlorade :(", 10, 15);
  } else {
    fill(100, 100, 100);
    text("Oavgjort!", 10, 16);
  }
}
