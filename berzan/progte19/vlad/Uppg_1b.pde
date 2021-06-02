import javax.swing.JOptionPane;

int tal1;
int tal2;

void setup()
{
  tal1 = int(JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20"));
  while(tal1 < 10 || tal1 > 20)
  {
    tal1 = int(JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20"));
  }
  
  tal2 = int(JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20"));
  while(tal2 < 10 || tal2 > 20)
  {
    tal2 = int(JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20"));
  }
  
  if(tal1 + tal2 >= 2 * tal1)
  {
    JOptionPane.showMessageDialog(null,"Du vann!");
  }
  else
  {
   JOptionPane.showMessageDialog(null,"Tyvärr! Du förlorade"); 
  }
}
