int x = 200;
int y = 200;
int d = 40;

void setup()
{
  size(400,400);
  background(0);
  
}

void draw()
{
  background(0);
  fill(random(0,255),random(0,255),random(0,255));
  ellipse(x,y,d,d);
  
  x += int(random(-20,20));
  y += int(random(-20,20));
}
