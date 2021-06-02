float x=200.0;
float y = 200.0;
int d=40;

void setup(){
  
  size(400,400);
  
}


void draw(){
  background(0);
  fill(random(0,255),random(0,255),random(0,255));
  x=x+random(-20,20);
  y=y+random(-20,20);
  ellipse(x,y,d,d);
  
  
}
