import javax.swing.JOptionPane;
textSize(50);
background(255);
size(500,500);
int talOne=int(JOptionPane.showInputDialog("välj ett tal mellan 10 och 20"));
if(talOne<10 || talOne>20){
  print("du valde ett tal större än 20 eller mindre än 10");
  noLoop();
}
int talTwo=int(JOptionPane.showInputDialog("välj ett till tal mellan 10 och 20"));
if(talTwo<10 || talTwo>20){
  print("du valde ett tal större än 20 eller mindre än 10");
  noLoop();
}
int talBoth=talOne+talTwo;
if(talBoth>=talOne*2){
  fill(0,255,0);
 text("Du vann",width/2-150,height/2);
}
else{
    fill(0,255,0);
text("Du förlorade",width/2-150,height/2);
}
