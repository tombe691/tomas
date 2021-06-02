int x= 20;
int y=20;


void setup(){
  size(400,400);
  
}



void draw(){
  while(x<width && x>0){
    float x=random(20,-20);
    fill(0);
    ellipse(200,200,40+x,40+y);
     
  }
  while(y<height && y>0){
    float y=random(20,-20);
    fill(0);
    ellipse(200,200,x,y);
    
  }
  
}
