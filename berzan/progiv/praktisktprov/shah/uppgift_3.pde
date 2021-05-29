
void setup() {
   size(400, 400);
   background(0);
 
   
}

void draw() {
  float x = random(-200,200);
  float y = random(-200,200);
  ellipse(x,y,40,40);
  float r = random(0,255);
  float g = random(0,255);
  float b = random(0,255);
  fill(r,g,b);
}
