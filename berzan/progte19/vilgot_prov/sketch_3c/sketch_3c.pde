float x=200.0;
float y = 200.0;
int d=40;
float r;
float g;
float b;
int p=0;


void setup() {

  size(400, 400);
  textSize(20);
}


void draw() {
  background(0);
  r=random(0, 255);
  g=random(0, 255);
  b=random(0, 255);

  fill(r, g, b);
  x+=random(-20, 20);
  if (x<0) {
    x=0;
  } else if (x>width) {
    x=width;
  }
  y+=random(-20, 20);
  if (y<0) {
    y=0;
  } else if (y>height) {
    y=height;
  }
  ellipse(x, y, d, d);

  if (get(mouseX, mouseY)==color(r, g, b)) {
    p++;
  }

  fill(255);
  text(p, 20, 20);
}
