int [] x = {100, 50, 130, 240, 350, 400, 160, 500, 530, 580, 500, 100, 300, 180, 200};
int [] y = {530, 500, 480, 300, 180, 200, 220, 180, 100, 89, 500, 100, 100, 50, 130};
int [] D = {100, 80, 120, 100, 200, 170, 77, 130, 66, 150, 100, 90, 55, 130, 100};

void ritaCirklar (float x, float y, float D1, float D2, int b, int a){
  int m = int  (random (1, 255));
  int n = int (random(1,255));
  int o = int (random (1,255));
  fill(m, n, o);
ellipse (x, y, D1, D2);
}

void draw(){
  background(0);
 size(400, 400);
 if (
}
