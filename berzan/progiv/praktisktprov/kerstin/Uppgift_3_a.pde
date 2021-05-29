//"Slumpboll" (Kerstin Hilding 2021-05-20)
//En boll irrar slumpmässigt fram över skärmen
float bollx=200;
float bolly=200;
float speedx=0;
float speedy=0;
float r, g, b;

void setup() {
  size(400, 400);
}

void draw() {
  background(0);
  
  //Uppdatera bollens position
  bollx += speedx;
  bolly += speedy;
  
  //nya slumpmässiga hastigheter
  speedx = random(-20, 20);
  speedy = random(-20, 20);
  
  //ny slumpmässig färg
  r=random(0, 255);
  g=random(0, 255);
  b=random(0, 255);
  
  //rita bollen
  fill(r, g, b);
  ellipse(bollx, bolly, 40, 40);
}
