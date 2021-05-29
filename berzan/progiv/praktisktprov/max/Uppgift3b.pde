  float x=200;
float y=200;

void setup(){
  size(400,400);
  background(0);
  frameRate(10);
}
void draw(){
  background(0);
  float randomX=random(-20,20);
  float randomY=random(-20,20);
   float r=random(0,170);
  float g=random(0,170);
   float b=random(0,170);
   x=200+randomX;
  y=200+randomY;
  fill(r,g,b);
  ellipse(x,y,40,40);
}
