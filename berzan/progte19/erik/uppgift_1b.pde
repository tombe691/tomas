import javax.swing.*;
int tal1r = 0;
int tal2r = 0;

void setup(){
  size(200,200);
  background(255);
  int tal1 = int(JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20"));
  if(tal1>20 || tal1<10){
    int tal1r = int(JOptionPane.showInputDialog("Första talet du angav ligger inte mellan 10 och 20, försök igen"));
  }
  int tal2 = int(JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20"));
  if(tal2>20 || tal2<10){
    int tal2r = int(JOptionPane.showInputDialog("Andra talet du angav ligger inte mellan 10 och 20, försök igen"));
  }
  if(tal1>=10 && tal1<=20 && tal2>=10 && tal2<=20){
    fill(255,0,0);
    if((tal1 + tal2) >= (2*tal1)){
      text("Grattis! Du vann",70,100);
    }
    else{
      text("Tyvärr! Du förlorade",70,100);
    }
  }
  else if(tal1r>=10 && tal1r<=20 && tal2r>=10 && tal2r<=20){
    fill(255,0,0);
    if((tal1r + tal2r) >= (2*tal1r)){
      text("Grattis! Du vann",70,100);
    }
    else{
      text("Tyvärr! Du förlorade",70,100);
    }
  }
}
