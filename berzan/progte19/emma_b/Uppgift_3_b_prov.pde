int x = 200;
int y = 200;
float r = random(255);
float g = random(255);
float b = random(255);
int point=0;

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
  x+= int(random(-20,20));
  y+= int(random(-20,20));
  if(x>width || x<0){
    x-= random(-20,20);
  }
  if(y>height || y<0){
    y-= random(-20,20);
  }
  println("x " + x+"y " +y);
  println("mx " + mouseX+"my " +mouseY);
  ellipse(mouseX, mouseY, 20, 20);
  if((mouseX-x <40) && (mouseY-y<40)){
    point++;
  }
fill(255);
text(point,10, 10);
}
