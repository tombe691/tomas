import javax.swing.JOptionPane;
void setup() {
  size(200,100);
  int tal1 =int(JOptionPane.showInputDialog("Skriv första nummret mellan 10 och 20"));
   while(tal1>20||tal1<10){
   tal1 =int(JOptionPane.showInputDialog("första nummret måste vara mellan 10 och 20")); 
 }
  int tal2 =int(JOptionPane.showInputDialog("Skriv andra nummret mellan 10 och 20"));
    while(tal2>20||tal2<10){
   tal2 =int(JOptionPane.showInputDialog("andra nummret måste vara mellan 10 och 20")); 
 }

  if (tal1+tal2>=2*tal1) {
    fill(250,0,0);
    text("tyvärr! du förlorade",20,20);
    
  }
  else {
    fill(250,0,0);
    text(" du vann!",20,20);
   
}
}
