import javax.swing.*; 

String str = JOptionPane.showInputDialog("Ange första heltal mellan 10 och 20");

String str1 = JOptionPane.showInputDialog("Ange andra heltal mellan 10 och 20");

int tal1=int(str);
int tal2=int(str1);

if(tal1 + tal2 >= 2*tal1){
  println("Grattis, du vann!");
}
  else{
  println("Tyvärr, du förlorade!");
  }
