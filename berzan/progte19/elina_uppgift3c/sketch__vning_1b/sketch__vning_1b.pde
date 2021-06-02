import javax.swing.*; 
void setup(){ 
  size(250,250);
  String str= JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20");
  int tal1= int(str);
    
  if( tal1>=10 && tal1<=20){
    String str1= JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20");  
    int tal2= int(str1); 
  
    if( tal2>=10 && tal2<=20){
      if(tal1 + tal2 >= 2*tal1){
        textSize(25); 
        fill(255,0,0); 
        text("Du vann",20,50); 
      }else{
        textSize(25); 
        fill(255,0,0);
        text("Tyvärr du förlorade",15,50); 
      }
    }
  }
}
