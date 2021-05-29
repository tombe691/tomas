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
  //Skriv ut poängen
  fill(255);
  textSize(20);
  text(points, 15, 20);
  
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
  
  //Användaren får poäng om/när muspekaren befinner sig över bollen
  if(get(mouseX, mouseY)==color(r,g,b)){
    points++;
  }
}
