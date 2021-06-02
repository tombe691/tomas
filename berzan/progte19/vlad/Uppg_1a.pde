import javax.swing.JOptionPane;

int tal1;
int tal2;

void setup()
{
  tal1 = int(JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20"));
  tal2 = int(JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20"));
   
  if(tal1 + tal2 >= 2 * tal1)
  {
    JOptionPane.showMessageDialog(null,"Du vann!");
  }
  else
  {
   JOptionPane.showMessageDialog(null,"Tyvärr! Du förlorade"); 
  }
}
