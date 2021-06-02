int x = 200;
int y = 200;
int d = 40;
String R = float(0);

void setup(){
  background(0);
  size(400, 400);
  frameRate(30);
 
  fill(#FFFFFF);
  text(10, 10, R);
}

void draw(){
  background(0);
   float n = mouseX;
   float m = mouseY;
  
  int r = (int)random(1, 255);
  int g = (int)random(1, 255);
  int b = (int)random(1, 255);
  fill(r, g, b);
  ellipse(x, y, d, d);
  int c = (int)random(-20, 20);
  y = y+c;
  int z = (int)random(-20, 20);
  x = x+z;
  if (n && m == r, g, b)
   R++;
}
  
}
