int x[] = {100, 50, 130, 240, 350, 400, 160, 500, 530, 580, 500, 100, 300, 180, 200};
int y[] = {530, 500, 480, 300, 180, 200, 220, 180, 100, 89, 500, 100, 100, 50, 130};
int d[] = {100, 80, 120, 100, 200, 170, 77, 130, 66, 150, 100, 90, 55, 130, 100};


void setup() {
  size(500, 500);
  for (int i = 0; i < d.length; i++) {
    float r = random(0, 255);
    float g = random(0, 255);
    float b = random(0, 255);
    ritaCirkel(x[i], y[i], d[i], int(r), int(g), int(b));
  }
}

void ritaCirkel(int x, int y, int d, int r, int g, int b) {
  fill(r, g, b);
  ellipse(x, y, d, d);
}
