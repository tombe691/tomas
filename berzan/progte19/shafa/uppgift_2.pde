  int [] x= {100,50,130,240,350,400,160,500,530,580,500,100,300,180,200};
  int [] y= {520,500,480,300,180,200,220,180,100,89,500,100,100,50,130};
  int [] D= {100,80,120,100,200,170,77,130,66,150,100,90,55,130,100};
  float r= random(255);
  float g= random(255);
  float b=random(255);
void setup(){
  size(600,600);
  background(0);


}


void ritaCirklar(int x, int y, int d, int r, int g, int b){
  for(int i=0; i<14; i++){
    fill(r,g,b);
    ellipse(x,y,d,d);
  }
  
  
}
