import javax.swing.JOptionPane;
int tal1;
int tal2;
void setup(){
  while(true){
     int tal1 = int(JOptionPane.showInputDialog("Ange ett heltal mellan 10 och 20"));
     if(tal1>=10 && tal1 <=20){
       break;
     }
  }
     
  while(true){
    int tal2 = int(JOptionPane.showInputDialog("Ange ett till heltal mellan 10 och 20")); 
    if(tal2>=10 && tal2 <=20){
      break;
    }
  }
  
  if(tal1+tal2>=2*tal1){
        JOptionPane.showMessageDialog(null, "Du vann");
        }else{
          JOptionPane.showMessageDialog(null, "Du förlorade");
        }
  


    
}
