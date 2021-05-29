int[] xvarden = {100, 50, 130, 240, 350, 400, 160, 500, 530, 580, 500, 100, 300, 180, 200};
int[] yvarden = {530, 500, 480, 300, 180, 200, 550, 180, 100, 89, 500, 100, 100, 50, 130};
int[] dvarden = {100, 80, 120, 100, 200, 170, 77, 130, 66, 150, 100, 90, 55, 130, 100};

void setup() {
  size(600, 600);
  background(0);
  int x, y, d;
  for (int i = 0; i < xvarden.length; i++) {
    x = xvarden[i];
    y = yvarden[i];
    d = dvarden[i];

    ritaCirkel(x, y, d);
  }
}


void ritaCirkel(int x, int y, int d) {


 
  float r = random(0, 255);
  float g = random(0, 255);
  float b = random(0, 255);


  fill(r, g, b);
  ellipse(x, y, d, d);
}
