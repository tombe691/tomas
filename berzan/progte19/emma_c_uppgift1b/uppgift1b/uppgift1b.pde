import javax.swing.JOptionPane;
  
void setup() {
  size(400, 400);
  int tal2 = 0;

  int tal1 = int(JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20"));
  while(tal1<10 || tal1>20){
     tal1 = int(JOptionPane.showInputDialog("Ange nytt första heltal mellan 10 och 20"));
  }
  if(tal1>10 & tal1<20){
  tal2 = int(JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20"));
    while(tal2<10 || tal2>20){
     tal2 = int(JOptionPane.showInputDialog("Ange nytt andra heltal mellan 10 och 20"));
    }
  }
  
  if (tal1 + tal2 >= 2 * tal2) {
    text("Grattis! Du vinner",200, 200);
  } else {
    text("Tyvärr du förlorar!", 200, 200);
  }
}
