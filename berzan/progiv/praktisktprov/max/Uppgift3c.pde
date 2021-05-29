  float x=200;
float y=200;
int score=0;
void setup(){
  size(400,400);
  background(0);
  frameRate(10);
}
void draw(){
  background(0);
  float randomX=random(-20,20);
  float randomY=random(-20,20);
   float r=random(0,170);
  float g=random(0,170);
   float b=random(0,170); 
   x=x+randomX;
  y=x+randomY;
  if(x>=width-20){
    x=width-20;
  }
   if(x<=0+20){
    x=0+20;
  }
  if(y>=width-20){
    y=width-20;
  }
   if(y<=0+20){
    y=0+20;
  }
  fill(r,g,b);
  ellipse(x,y,40,40);
  if(mouseY>=y-20 && mouseY<=y+20 && mouseX>=x-20 && mouseX<=x+20){
  score=score+1;
   // print("hit");
}
fill(255);
textSize(20);
text(score,20,30);
}
