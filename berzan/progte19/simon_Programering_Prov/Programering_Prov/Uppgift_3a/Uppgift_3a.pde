int bolls = (40);
int bollx = (200);
int bolly = (200);

void setup(){
  size(400, 400);
}

void draw(){
  fill (0, 0, 0);
  rect (0, 0, 400, 400);
  fill (random(0, 255), random(0, 255), random(0, 255));
  ellipse(bollx, bolly, bolls, bolls);
  bollx += random(-20, 20);
  bolly += random(-20, 20);
}
