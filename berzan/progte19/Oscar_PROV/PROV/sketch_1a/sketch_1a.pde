import javax.swing.JOptionPane; 

int tal1 = int(JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20"));
int tal2 = int(JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20"));

void setup(){

  size(500,500);
  background(0);
  textSize(24);
  
}

void draw(){

  if(tal1+tal2 >= tal1*2){
  
     text("du vann", 200, 250); 
    
  }
  
  else{
    
    text("du förlorade", 200, 250);
  
  }
  
}
