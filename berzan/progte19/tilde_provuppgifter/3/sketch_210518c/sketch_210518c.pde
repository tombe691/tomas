float x= 200;
float y= 200;
int poang = 0;


void setup(){
  size(400,400);
  background(0);
}

void draw(){
  background(0);
  float s = random(-20,20);
  float ss= random(-20,20);
  float r = random(5,255);
  float g = random(5,255);
  float b = random(5,255);
  
  x= x+s;
  y= y+ss;
  
  fill(r,g,b);
  ellipse (x,y,40,40);
  fill(255);
 
  
  if(mouseX>x-10 && mouseX<x+10 && mouseY>y-10 && mouseY<y+10){
    poang+=1;
  }
  
  if(x<=0){
    x=0;
  }
  if(y<=0){
    y=0;
  }
  if(x>=width){
    x=width;
  }
  if(y<=height){
    y=height;
  }
  
  textSize(20);
  text(poang, 20,20);
}
