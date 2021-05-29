float[] xvarden={10,50,130,240,350,400,160,500,530,580,500,100,300,180,200};
float[] yvarden={530,500,480,300,180,200,220,180,100,89,500,100,100,50,130};
float[] dvarden={100,80,120,100,200,170,77,130,66,150,100,90,55,130,100};
float r= random(0,255);
float g= random(0,255);
 float  b= random(0,255);

void setup(){
  size(1000,1000);
  background(0);
  for(int i=0; i<14; i++){
    ritaCirkel(xvarden[i],yvarden[i],dvarden[i],r,g,b);
  }
  
}


void ritaCirkel(float x, float y, float d, float r, float g, float b){
  r= random(0,255);
  g= random(0,255);
  b= random(0,255);
  fill(r,g,b);
  ellipse(x,y,d,d);
}
