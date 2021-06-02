size(200,200);
import javax.swing.JOptionPane;

int tal1 = int(JOptionPane.showInputDialog("Ange första heltalet mellan 10 och 20"));
int tal2 = int(JOptionPane.showInputDialog("Ange andra heltalet mellan 10 och 20"));

fill(255,0,0);

if(tal1 + tal2 >= 2*tal1){
  text("Du vann",50,50);
  
}  else {
  text("Du förlorade", 50,50);
}
