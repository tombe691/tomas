int xArray[] = {100,50,130,240,350,400,160,500,530,580,500,100,300,180,200};
int yArray[] = {530,500,480,300,180,200,220,180,100,89,500,100,100,50,130};
int dArray[] = {100,80,120,100,200,170,77,130,66,150,100,90,55,130,100};

void ritaCirkel(int x, int y, int d)
{
  int r = int(random(0,255));
  int g = int(random(0,255));
  int b = int(random(0,255));
  fill(r,g,b);
  ellipse(x,y,d,d);
}

void setup()
{
  size(800,800);
  background(0);
  
  for(int i = 0; i < 14; i++)
  {
  ritaCirkel(xArray[i],yArray[i],dArray[i]);
  }
}
