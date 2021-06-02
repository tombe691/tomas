int xPos = 200;
int yPos = 200;
int yDir = 0;
int xDir = 0;
void setup(){
  size(400,400);
  
}
void draw(){
  background(0);
  xDir = int(random(-20,20));
  yDir = int(random(-20,20));
  xPos += xDir;
  yPos += yDir;
  int r = int(random(1,255));
  int g = int(random(1,255));
  int b = int(random(1,255));
  fill(r,g,b);
  ellipse(xPos,yPos,40,40);
  

}
