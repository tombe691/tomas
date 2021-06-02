
int x = 200;
int y = 200;

// b)
int score = 0;
// end of b

void setup(){
  size(400, 400);
  noStroke();
}


void draw(){
  background(0, 0, 0);
  fill( int(random(0, 255)), int(random(0, 255)), int(random(0, 255)) );
  
  x += int(random(-20, 20));
  y += int(random(-20, 20));
  
  //b
  if( (mouseX < (x + 40)) && (mouseX > (x - 40)) && (mouseY < (y + 40)) && (mouseY > (y - 40)) ){
    score += 1;
  }
  
  text("score: "+score, 10, 10);
  //end of b
  
  // c)
   if(x < 0){
    x = 0;
  }
  else if(x > 400){
    x= 400;
  }
  
  if(y < 0){
    y = 0;
  }
  else if(y > 400){
    y = 400;
  }
  //end of c
  
  ellipse(x, y, 40, 40);
}
