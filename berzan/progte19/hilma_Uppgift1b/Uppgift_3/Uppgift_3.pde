float bollx=200;
float bolly=200;
float rx = random(-20,20);
float ry = random(-20,20);



void setup(){
  size(400, 400);
}

void draw(){
  background(0);
  fill(random(0,255), random(0,255),random(0,255));
  ellipse(bollx, bolly, 40, 40);
bollx+=rx;
bolly+=ry;
}
