float bollx=200;
float bolly=200; 
float r = random(0,255); 
float g = random(0,255); 
float b = random(0,255); 
int poang = 0; 

void setup(){
  size(400,400);
}

void draw() {
  background(0); 
  float x = random(-20,20);
  float y = random( -20,20); 
  
  bollx = bollx + x; 
  bolly = bolly + y;
  
  fill(r,g,b); 
  ellipse(bollx,bolly,40,40); 
  
  if( mouseX <= bollx+20 && mouseX >= bollx-20 && mouseY >= bolly-20 && mouseY <= bolly+20){
    poang++;
  } 
  textSize(25); 
  fill(255); 
  text(poang,15,25); 
}
