int x = 200;
int y = 200;
float p = 0;

void setup() {
  size(400, 400);
  background(0);
}


void draw() {
  background(0);
  float xspeed = random(-20, 20);
  float yspeed = random(-20, 20);

  x += xspeed;
  y += yspeed;
  
  float r = random(0, 255);
  float g = random(0, 255);
  float b = random(0, 255);
  
  fill(r,g,b);
  ellipse(x, y, 40, 40);
  int mx = int(mouseX);
  int my = int(mouseY);
  
  while (mx <= x+20 && mx >= x-20 && my <= y+20 && my >= y-20){
  p =+1;
  }
   
  println(p);
    
}
