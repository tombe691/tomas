float bollx=200;
float bolly=200; 
float r= random(0,255); 
float g= random(0,255); 
float b= random(0,255); 

void setup(){
  size(400,400); 
}

void draw() {
  background(0); 
  float x = random(-20,20);
  float y = random( -20,20); 
  bollx= bollx + x; 
  bolly= bolly + y;
  fill(r,g,b); 
  ellipse(bollx,bolly,40,40); 
}
