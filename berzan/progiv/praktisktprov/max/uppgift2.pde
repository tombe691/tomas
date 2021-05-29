//int x[] array[]; (100,50,130,240);
//int y[] array[]; (100,50,130,240);
//int d[] array[]; (100,50,130,240);
void setup(){
  background(255);
  size(200,200);
   for(int i =0;i>x.length;i++){
     float r=random(1,100);
  float g=random(1,100);
  float b=random(1,100);
  ritaCirkel(x[i],y[i],d[i],r,g,b);
   }
}

void ritaCirkel(int x,int y,int d,float r,float g, float b){
 fill(r,g,b);
  ellipse(x,y,d,d);
}
