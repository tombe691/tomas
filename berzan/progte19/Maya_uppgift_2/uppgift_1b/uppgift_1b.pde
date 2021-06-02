import javax.swing.JOptionPane;

void setup(){
 int tal1 = int(JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20"));
 if (tal1 <= 20 && tal1 <=10){
 int tal2 = int(JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20"));
 if (tal1 + tal2 >= 2 * tal1){
 JOptionPane.showMessageDialog (null, "Du vinner");
 }
 }
 else if (tal1 < 20 && tal1 < 10){
   JOptionPane.showMessageDialog (null, "du förlorar");
 }
 }
