int x = 200;
int y = 200;
int d = 40;
int Score = 0;

void setup()
{
  size(400,400);
  background(0);
  frameRate(60);
  
}

void draw()
{
  background(0);
  
  fill(255,255,255);
  textSize(15);
  textAlign(CENTER,CENTER);
  text("Poäng: " + Score,50,20);
  
  fill(random(0,255),random(0,255),random(0,255));
  ellipse(x,y,d,d);
  
  x += int(random(-20,20));
  y += int(random(-20,20));
  
  if(mouseX <= x+ d/2 && mouseX >= x- d/2 && mouseY <= y+ d/2 && mouseY >= y- d/2)
  {
    Score += 1;
  }
  
  
}
