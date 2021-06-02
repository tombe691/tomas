float x=200.0;
float y = 200.0;
int d=40;
float r;
float g;
float b;
int p=0;


void setup(){
  
  size(400,400);
  
}


void draw(){
  background(0);
  r=random(0,255);
  g=random(0,255);
  b=random(0,255);
  
  fill(r,g,b);
  x=x+random(-20,20);
  y=y+random(-20,20);
  ellipse(x,y,d,d);
  
  if(get(mouseX,mouseY)==color(r,g,b)){
    p++;
  }
  textSize(20);
  fill(255);
  text(p,20,20);
  
  
  
  
}
