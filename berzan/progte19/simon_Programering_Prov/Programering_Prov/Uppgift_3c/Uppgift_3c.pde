int bolls = 40;
int bollx = 200;
int bolly = 200;
int points = 0;

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
  if (bollx < 0){
    bollx = 0;
  }
  if (bollx > width){
    bollx = width;
  }
  if (bolly < 0){
    bolly = 0;
  }
  if (bolly > height){
    bolly = height;
  }
  if (mouseX < bollx + 20 && mouseX > bollx - 20 && mouseY < bolly + 20 && mouseY > bolly - 20){
    points += 1;
  }
  fill (255, 255, 255);
  text (points, 10, 10);
}
