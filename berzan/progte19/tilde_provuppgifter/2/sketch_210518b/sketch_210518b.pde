int [] x_varden = {100,50,130,240,350,400,160,500,530,580,500,100,300,180,200};
int [] y_varden = {530,500,480,300,180,200,220,180,100,89,500,100,100,50,130};
int [] D_varden = {100,80,120,100,200,170,77,130,66,150,100,90,55,130,100};


void setup(){
size(700,700);
background(0);
  for(int i=0; i<x_varden.length; i++){
    int x= x_varden [i];
    int y= y_varden [i];
    int d= D_varden [i];
    ritaCirkel(x,y,d);
    }
}

void ritaCirkel(int x, int y, int d){
  float r = random(0,255);
  float g = random(0,255);
  float b = random(0,255);
  fill(r,g,b);
  ellipse(x,y,d,d);
}
