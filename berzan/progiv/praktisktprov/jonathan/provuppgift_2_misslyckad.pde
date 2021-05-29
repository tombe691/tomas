import javax.swing.*;

int [] x_varden = {100,50,130,240,350,400,160,500,530,580,500,100,300,180,200};
int [] y_varden = {530,500,480,300,180,200,220,180,100,89,500,100,100,50,130};
int [] D_varden = {100,80,120,100,200,170,77,130,66,150,100,90,55,130,100};
float r = random(0,255);
float g = random(0,255);
float b = random(0,255);

void setup(){
    size(400,400);
    
    ritaCirkel(x_varden[0],y_varden[0],D_varden[0],int(r),int(g),int(b));
 }
 


void draw(){
  
  
}





void ritaCirkel(x,y,d,r,g,b){
  
  


  
  for(int i=0; i < x_varden.length; i++){
    
     fill(r,g,b);
     ellipse(x_varden[i],y_varden[i],D_varden[i],D_varden[i]);
     
  }
  
  
  
  
  
}
