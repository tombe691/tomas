float x = 200;
float y = 200;
float d = 40;

void setup(){
  size(400,400);
  background(0);
  frameRate(20);
  
}


void draw(){
  background(0);
  float r = random(0,255);
  float g = random(0,255);
  float b = random(0,255);
  fill(r,g,b);
  float speedx = random(-20,20);
  float speedy = random(-20,20);
  x = x + speedx;
  y = y + speedy;
  ellipse(x,y,d,d);
  
}
