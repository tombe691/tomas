import javax.swing.*;
int tal1;
int tal2;

void setup(){
  size(200,200);

}

void draw(){
  talforsta();
  talandra();
  
  if(tal2>=10 && tal2 <=20 && tal1>=10 && tal1 <=20 ){
     if(tal1+tal2>=2*tal1){
       text("du vann",20,20);
       noLoop();
    }
    else {
        text("du förlorade",20,20);
        noLoop();
    }
  }
   
  
}

void talforsta(){
  
    String forstatal = JOptionPane.showInputDialog("Ange första heltal mellan 0 och 20");
    tal1 = int(forstatal); 
      
    while (tal1<10 || tal1 >20) {
      forstatal = JOptionPane.showInputDialog("Ange första heltal mellan 0 och 20");
      tal1 = int(forstatal); 
    }
  
}
void talandra(){
  
    String andratal = JOptionPane.showInputDialog("Ange andra heltal mellan 0 och 20");
    tal2 = int(andratal);
   while (tal2<10 || tal2 >20) {
      andratal = JOptionPane.showInputDialog("Ange andra heltal mellan 0 och 20");
      tal2 = int(andratal); 
    }
  
  //debugging
  println(tal1, tal2);
}
