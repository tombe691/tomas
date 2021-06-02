import javax.swing.JOptionPane;

void setup(){
  background(0);
  size(250,250);
  int tal1=int(JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20"));
  int tal2=int(JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20"));
  if(tal1>=10 && tal1<=20 && tal2>=10 && tal2<=20){
    if(tal1+tal2>=2*tal1){
      fill(0,255,0);
      text("Du vann!", 125, 125);
    }
    else {
      fill(255,0,0);
      text("Tyvärr! Du förlorade", 125,125);
    }
  }
  else {
    text("Ange ett tal mellan 10 och 20", 125, 125);
  }
}
