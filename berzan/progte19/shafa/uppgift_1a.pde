import javax.swing.JOptionPane; 

void setup(){
  size(400,400);
  background(0);
}


void draw(){
  int tal1= int(JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20")); 
  int tal2= int(JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20"));
  if(tal1+tal2>=2*tal1){
    textSize(40);
    fill(255,0,0);
    text("Grattis! Du vann", 20,60);
  }
  else text("Tyvärr! Du förlorade", 20,20); 
  
}
