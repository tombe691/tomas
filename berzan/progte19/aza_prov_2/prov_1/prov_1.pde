void setup() {
  size (1000, 1000);
}

int [] xkoord = {100, 50, 130, 240, 350, 400, 160, 500, 530, 580, 500, 100, 300, 180, 200};
int [] ykoord = {530, 500, 480, 300, 180, 200, 220, 180, 100, 89, 500, 100, 100, 50, 130};
int [] d = {100, 80, 120, 100, 200, 170, 77, 130, 66, 150, 100, 909, 55, 130, 100};

void ritaCirkel( int x, int y, int d) {
  float t = random(1,1000);
  float a = random(1,1000);
  float b = random(1,1000);
  fill(100,100,100);
  ellipse(x,y,d,t);
  
  
}

void draw() {
for (int i=0; i <15; i++) {
   ritaCirkel( xkoord [i] , ykoord [i], d[i]); 

}
}
 
  
  
