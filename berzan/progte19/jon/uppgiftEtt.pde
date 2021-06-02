// Uppgift 1 - enkelt exempel
// a)
import javax.swing.*;

int tal1;
int tal2;

// b)
boolean goodToGo;
// end of b

void setup() {
  size(1000, 1000);
  
  String str = JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20");
  tal1 = int(str);
  
  String str2 = JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20");
  tal2 = int(str2);
  
  // b)
  if ( (10 < tal1) && (10 < tal2) ){
    if ( (20 > tal1) && (20 > tal2) ){
      goodToGo = true;
    }
    else{
      goodToGo = false;
    }
  }
  else{
    goodToGo = false;
    }
  // end of b
  
  
  
  
  if((tal1 + tal2) >= (2 * tal1)){
    if(goodToGo){
    text("Grattis! Du vann", 100, 100);
    }
    else{
      text("Börja om", 100, 100);
    }
  }
  else {
    if(goodToGo){
      text("Tyvärr! Du förlorade", 100, 100);
    }
    else{
      text("Börja om", 100, 100);
    }
  }
}
