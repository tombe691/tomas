float x = 200;
float y = 200;
float r = random(0, 255);
float g = random(0, 255);
float b = random(0, 255);

void setup() {
  size(400, 400);
}

void draw() {
  x += random(-20, 20);
  y += random(-20, 20);
  fill(r,g,b);
  background(0);
  ellipse(x, y, 40, 40);
}
