void setup() {
  size (400,400);

}


void draw() {
  float r = random(1,400);
  float x = random(1,400);
  float y = random(400);
  float a = random(400);
  float t = random(15);
fill(y,a,t);
 ellipse(r,x,40,40);
 noLoop();
}
