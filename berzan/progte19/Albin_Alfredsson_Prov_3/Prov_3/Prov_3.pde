void setup() {

  size(400, 400);
}

void draw() {

  float x=random(-20, 20);
  float y=random(-20, 20);


fill(random(1,255), random(1,255), random(1,255));
  background(0);
  delay(100);
  float xpos=200+x;
  float ypos=200+x;
  
  ellipse(xpos, ypos, 40, 40);
}
