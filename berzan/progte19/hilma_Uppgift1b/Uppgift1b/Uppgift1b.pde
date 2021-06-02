import javax.swing.*; 

String str = JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20");

int tal1=int(str);

if( tal1<10 || tal1 >20){
  String str2 = JOptionPane.showInputDialog("Talet måste vara mellan 10 och 20");
}

String str1 = JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20");

int tal2=int(str1);

if( tal2<10 || tal2 >20){
  String str3 = JOptionPane.showInputDialog("Talet måste vara mellan 10 och 20");
}

if(tal1 + tal2 >= 2*tal1){
  println("Du vann!");
}
  else{
  println("Tyvärr, du förlorade!");
  }
