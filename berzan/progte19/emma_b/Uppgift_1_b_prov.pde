import javax.swing.JOptionPane;

void setup(){
  size(150,150);
  String Str1 = JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20");
  int tal1 = int(Str1);
  
  while(tal1< 10 || tal1>20) {
    Str1 = JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20");
    tal1 = int(Str1);
  }

  if(tal1 >= 10 && tal1 <=20){
     String Str2 = JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20");
     int tal2 = int(Str2);
     while(tal2< 10 || tal2>20){
        Str2 = JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20");
     }
     if(tal2 >= 10 && tal2 <= 20){
       if((tal1 + tal2) >= (2*tal1)){
        text("Grattis! Du vann", 10, 10);
      }
      else {
        text(" Tvyärr! Du förlorade", 10, 10);
      }
    }
  } 
}
