float x= 200;
float y=200;


void setup(){
  size(400,400);
}
void draw(){
  background(0);
  float slump1=random(-20,20);
  float slump2=random(-20,20);
  x+=slump1;
  y+=slump2;
  slumpadfarg();
  ellipse(x,y,40,40);
}


void slumpadfarg(){
  float r= random(0,255);
  float g=random(0,255);
  float b=random(0,255);
  fill(r,g,b);
}
