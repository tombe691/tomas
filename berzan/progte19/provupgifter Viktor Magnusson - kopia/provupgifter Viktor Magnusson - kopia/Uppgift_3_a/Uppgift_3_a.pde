float x = 200;
float y = 200;
void setup() {
  size(400,400);
  ellipse(x,y,40,40);
}
void draw() {
  fill(int(random(0,254)),int(random(0,254)),int(random(0,254)));
  background(0);
  x = x + random(-20,20);
  y = y + random(-20,20);
  ellipse(x,y,40,40);
}
