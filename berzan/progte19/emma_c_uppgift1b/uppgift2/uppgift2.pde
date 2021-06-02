void setup() {
  size(500, 500);
 for (int i=0; i<15; i++){
    ritaCirkel(xvarde[i], yvarde[i],dvarde[i]);
  }
}

int [] xvarde = {
  100, 50, 130, 240, 350, 400, 160, 500, 530, 580, 500, 100, 300, 180, 200
};
int [] yvarde = {
  530, 500, 480, 300, 180, 200, 220, 280, 100, 89, 500, 100, 100, 50, 1340
};
int [] dvarde = {
  100, 80, 120, 100, 200, 170, 77, 130, 66, 150, 100, 90, 55, 130, 100
};

void ritaCirkel(int x, int y, int d) {
  float a = random(1, 255);
  float b = random(1, 255);
  float c = random(1, 255);
  fill(a, b, c);
  ellipse(x, y, d, d);
}
