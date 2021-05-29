float x = 200;
float y = 200;

void setup() {
  size(400, 400);
  frameRate(5);
}
 
void draw() {
  background(0);
  float random1 = random(-20,20);
  float random2 = random(-20,20);
  x += random1;
  y += random2;
  float R =random(0,255);
  float G =random(0,255);
  float B =random(0,255);
  fill(R,G,B);
  ellipse(x, y, 40, 40);
}
