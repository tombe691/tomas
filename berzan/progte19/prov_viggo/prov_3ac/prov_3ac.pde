void setup(){
  size(400,400);
}
void draw(){
  background(0);
  int x=200;
  int y=200;
  int r= int(random(-20,20));
  int b= int(random(-20,20));
  //ellipse(x,y,40,40);
  x=x-r;
  y=y-b;
  ellipse(x,y,40,40);
  
    if(y==400){
    y = -y;
   
  }
    if(y==0){
   y =-y; 
   
  }
//  if(bollx>=height){
 // speedx=.5;
  
//}
if(x==400){
  x=-x;
}
if(x==0){
  x=-x;
}

  
}
