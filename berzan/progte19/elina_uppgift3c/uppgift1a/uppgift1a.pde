import javax.swing.*; 
void setup(){ 
  size(300,200);
  background(255);
  String str= JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20"); 
  String str1= JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20"); 
  int tal1= int(str); 
  int tal2= int(str1); 
  
  if(tal1 + tal2 >= 2*tal1){
    textSize(25); 
    fill(255,0,0); 
    text("Du vann!",20,100); 
  }
  else{
    textSize(25); 
    fill(255,0,0);
    text("Tyvärr! Du förlorade",20,100); 
  }
}
