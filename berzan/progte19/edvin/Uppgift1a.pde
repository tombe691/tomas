import javax.swing.JOptionPane;
void setup(){
  int tal1 = int(JOptionPane.showInputDialog("Ange ett heltal mellan 10 och 20"));
  int tal2 = int(JOptionPane.showInputDialog("Ange ett till heltal mellan 10 och 20"));
  if(tal1+tal2>=2*tal1){
    JOptionPane.showMessageDialog(null, "Du vann");
  }else{
    JOptionPane.showMessageDialog(null, "Du förlorade");
  }
  



}
