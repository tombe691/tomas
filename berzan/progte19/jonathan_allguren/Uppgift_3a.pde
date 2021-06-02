float x;
float y;



void setup(){
  size(400,400);
 
}

void draw(){
float rand1 = random(-20,20);
float rand2 = random(-20,20);


    x = x+rand1;
    y = y+rand2;


  
 fill(255,0,0);
 noStroke();
  background(0);
 ellipse(200+x,200+y,40,40); 
  
}
