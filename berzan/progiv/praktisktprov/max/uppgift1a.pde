import javax.swing.JOptionPane;

int talOne=int(JOptionPane.showInputDialog("välj ett tal mellan 10 och 20"));
//if(talOne<10 || talOne>20){
//  print("du valde ett tal större än 20 eller mindre än 10");
 // noLoop();
//}
int talTwo=int(JOptionPane.showInputDialog("välj ett till tal mellan 10 och 20"));
//if(talTwo<10 || talTwo>20){
//  print("du valde ett tal större än 20 eller mindre än 10");
 // noLoop();
//}
int talBoth=talOne+talTwo;
if(talBoth>=talOne*2){
  print("Du vann");
}
else{
  print("Du förlorade");
}
