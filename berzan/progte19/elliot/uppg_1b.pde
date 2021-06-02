import javax.swing.JOptionPane;

void setup(){
 int tal1 = int(JOptionPane.showInputDialog("Ange Första heltat mellan 10 och 20"));
  if (tal1<10){
   int tal3 = int(JOptionPane.showInputDialog("NEJ!! Bara mellan 10 OCH 20:d"));
   tal1=tal3;
 }
 if (tal1>20){
   int tal3 = int(JOptionPane.showInputDialog("NEJ!! Bara mellan 10 OCH 20:d"));
   tal1=tal3;
 }
 
 int tal2 = int(JOptionPane.showInputDialog("Ange Andra heltat mellan 10 och 20"));
  if (tal2<10){
   int tal4 = int(JOptionPane.showInputDialog("NEJ!! Bara mellan 10 OCH 20:d"));
   tal1=tal4;
 }
 if (tal2>20){
   int tal4 = int(JOptionPane.showInputDialog("NEJ!! Bara mellan 10 OCH 20:d"));
   tal1=tal4;
 }
 
 
 if (tal1+tal2>2*tal1){
   JOptionPane.showMessageDialog(null, "Du Vann!!!");
 }
 else{
   JOptionPane.showMessageDialog(null, "Bättre Lyckas Nästa gång!!!");
   
 }
}
