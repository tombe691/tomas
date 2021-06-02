int x = 200;
int y = 200;
int d = 40;


void setup(){
  background(0);
  size(400, 400);
  frameRate(30);
  
}

void draw(){
  background(0);
  int r = (int)random(1, 255);
  int g = (int)random(1, 255);
  int b = (int)random(1, 255);
  fill(r, g, b);
  ellipse(x, y, d, d);
  int c = (int)random(-20, 20);
  y = y+c;
  int z = (int)random(-20, 20);
  x = x+z;
  
}
