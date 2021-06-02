int x [] = {100, 50, 130, 240, 350, 400, 160, 500, 530, 580, 500, 100, 300, 180, 200};
int y [] = {530, 500, 480, 300, 180, 200, 220, 180, 100, 89, 500, 100, 100, 50, 130};
int D [] = {100, 80, 120, 100, 200, 170, 77, 130, 66, 150, 100, 90, 55, 130, 100};



void setup() {
  size(500, 500);
background(0);
}

void ritaCirkel(int x, int y, int D) {
  ellipse(x, y, D, D);
}

void draw() {
 for (int i = 0; i < D.length; i++) {
int  r = (int)random(1,256);
int  g = (int)random(1,256);
int  b = (int)random(1,256);
    ellipse(x[i], y[i], D[i], D[i]);
fill(r, g, b);
}
}
