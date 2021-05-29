int x = 250;
int y = x;
int d = 100;
float R = random(0,255);
float G = random(0,255);
float B = random(0,255);

void setup() {
  background(0);
  size(500, 500);

  cirkel = createShape(ELLIPSE, x, y, d);
  cirkel.setfill(color, R, G, B));
  cirkel.setStroke(false);
}

void draw() {
  shape(cirkel, 25, 25);
}
