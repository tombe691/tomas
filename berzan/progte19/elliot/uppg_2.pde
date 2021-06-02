int x[] = {100, 50, 130, 240, 350, 400, 160, 500, 530, 580, 500, 100, 300, 280, 200};
int y[] = {530, 500, 480, 300, 180, 200, 220, 180, 100, 89, 500, 100, 100, 50, 130};
int d[] = {100, 80, 120, 100, 200, 170, 77, 130, 66, 150, 100, 90, 55, 130, 100};

void ritaCirkel(float x, float y, float d1, float d2){
  int R = (int)(random(1, 255));
  int G = (int)(random(1, 255));
  int B = (int)(random(1, 255));
  fill(R, G, B);
  ellipse(x, y, d1, d2);
}


void setup(){
  background(0);
  size(600, 600);
  for (int i=0; i<x.length; i++){
    ritaCirkel(x[i], y[i], d[i], d[i]);
  
  }
}
