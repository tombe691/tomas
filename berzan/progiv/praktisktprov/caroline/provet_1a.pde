import javax.swing.JOptionPane;
void setup () {

String tal1 = JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20");
String tal2 = JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20");

int tal1b = int(tal1);
int tal2b = int(tal2);

if(tal1b + tal2b >=2 *tal1b){
  JOptionPane.showMessageDialog(null,"Du vann");
}
else 
JOptionPane.showMessageDialog(null,"Tyvärr du  förlorar");
}
