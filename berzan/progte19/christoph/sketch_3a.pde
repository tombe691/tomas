float x = 200;
float y = 200;
float d = 40;
float speedx = 0;
float speedy = 0;


void setup(){
  size(400, 400);
  background(0);
  
}

void draw() {
  background(0);
  float r= random(0,255);
  float g= random(0,255);
  float b= random(0,255);
  
  float speedx=random(-20, 20);
  float speedy=random(-20,20);
  x=x+speedx;
  y=y+speedy;
  fill(r,g,b);
  ellipse(x,y,d,d);
}
