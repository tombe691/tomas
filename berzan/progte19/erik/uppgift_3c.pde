float x = 200;
float y = 200;
float d = 40;
int point = 0;
color mus = (0);
color ball = (0);

void setup(){
  size(400,400);
  background(0);
  frameRate(35); 
}

void draw(){
  background(0);
  float r = random(0,255);
  float g = random(0,255);
  float b = random(0,255);
  fill(r,g,b);
  float speedx = random(-20,20);
  float speedy = random(-20,20);
  x = x + speedx;
  y = y + speedy;
  if(x<0){
    x=0;
  }
  if(y<0){
    y=0;
  }
  if(x>width){
    x=width;
  }
  if(y>width){
    y=width;
  }
  
  ellipse(x,y,d,d);
  ball = get(int(x),int(y));
  mus = get(mouseX,mouseY);
  
  if(mus==ball){
    point+=1;
  }
  fill(255);
  text(point,10,20);
  
}
