int xPos = 200;
int yPos = 200;
int points = 0;
void setup(){
  size(400,400);
  textSize(20);
}
void draw(){
  background(0);
  fill(255);
  text(points,10,20);
  xPos += int(random(-20,20));
  yPos += int(random(-20,20));
  int r = int(random(1,255));
  int g = int(random(1,255));
  int b = int(random(1,255));
  fill(r,g,b);
  if(((mouseX <= (xPos+20)) && mouseX >= (xPos -20))&&((mouseY <= (yPos+20)) && mouseY >= (yPos -20))){
    points++;
  }
  ellipse(xPos,yPos,40,40);
  

}
