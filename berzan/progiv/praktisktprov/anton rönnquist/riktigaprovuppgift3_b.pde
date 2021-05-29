float x= 200;
float y=200;
int score=0;
color farg=(0);

void setup(){
  frameRate(50);
  size(400,400);
}
void draw(){
  background(0);
  float slump1=random(-20,20);
  float slump2=random(-20,20);
  x+=slump1;
  y+=slump2;
farg();
  ellipse(x,y,40,40);
  if(get(mouseX,mouseY)==farg){
    score=score +1;
  }
score();
}







void farg(){
   float r= random(0,255);
  float g=random(0,255);
  float b=random(0,255);
  farg= color(r,g,b);
  fill(r,g,b);
}

void score(){
    fill(255);
    textSize(30);
  text(score,30,30);}
