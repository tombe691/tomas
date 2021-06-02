import javax.swing.JOptionPane;

void setup(){
 int tal1 = int(JOptionPane.showInputDialog("Ange Första heltat mellan 10 och 20"));
 int tal2 = int(JOptionPane.showInputDialog("Ange Första heltat mellan 10 och 20"));
 
 if (tal1+tal2>2*tal1){
   JOptionPane.showMessageDialog(null, "Du Vann!!!");
 }
 else{
   JOptionPane.showMessageDialog(null, "Bättre Lyckas Nästa gång!!!");
   
 }
}
