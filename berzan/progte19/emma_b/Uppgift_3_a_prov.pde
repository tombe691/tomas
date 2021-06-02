float x = 200;
float y = 200;
float r = random(255);
float g = random(255);
float b = random(255);

void boll(float x, float y){
  ellipse(x, y, 40, 40);
}
void setup(){
  size(400,400);
}

void draw(){
  background(0);
  fill(r,g,b);
  boll(x,y);
  x+= random(-20,20);
  y+= random(-20,20);
  
}
