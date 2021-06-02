float x = 200;
float y = 200;
float r = random(0, 255);
float g = random(0, 255);
float b = random(0, 255);
int score = 0;

void setup() {
  size(400, 400);
}

void draw() {
  x += random(-20, 20);
  y += random(-20, 20);
  fill(r, g, b);
  background(0);
  text("Poäng " + score, 20, 20); 
  ellipse(x, y, 40, 40);
  color c = get(mouseX, mouseY);
  color d = color(int(r), int(g), int(b));

  if (c==d) {
    score += 1;
  }
}
