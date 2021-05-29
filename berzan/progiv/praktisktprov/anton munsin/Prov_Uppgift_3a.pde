int x = 200;
int y = 200;

void setup() {
  size(400, 400);
  background(0);
}


void draw() {
  background(0);
  float xspeed = random(-20, 20);
  float yspeed = random(-20, 20);

  x += xspeed;
  y += yspeed;
  
  float r = random(0, 255);
  float g = random(0, 255);
  float b = random(0, 255);
  
  fill(r,g,b);
  ellipse(x, y, 40, 40);
}
