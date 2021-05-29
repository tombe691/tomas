float bollx=200;
float bolly=200;
float speedx=0;
float speedy=0;
float r, g, b;
int points=0;

void setup() {
  size(400, 400);
}

void draw() {
  background(0);
  //Skriv ut användarens nuvarande poäng
  fill(255);
  textSize(20);
  text(points, 15, 20);

  //Uppdatera bollens position
  bollx += speedx;
  if (bollx<0) {
    bollx=0;
  } else if (bollx>width) {
    bollx=width;
  }
  
  bolly += speedy;
  if (bolly<0) {
    bolly=0;
  } else if (bolly>height) {
    bolly=height;
  }

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

  //Användaren får poäng om/när muspekaren befinner sig över bollen
  if (get(mouseX, mouseY)==color(r, g, b)) {
    points++;
  }
}
