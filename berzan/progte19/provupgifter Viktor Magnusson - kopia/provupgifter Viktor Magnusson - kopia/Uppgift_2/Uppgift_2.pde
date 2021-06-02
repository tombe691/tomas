void rita(int x,int y,int d,int r,int g,int b){
  fill(r,g,b);
  ellipse(x,y,d,d);  
}
void setup() {
  size(600,600);
  int[] x_varden = {100,50,130,240,350,400,160,500,530,580,500,100,300,180,200};
  int[] y_varden = {530,500,480,300,180,200,220,180,100,89,500,100,100,50,10};
  int[] D_varden = {100,80,120,100,200,170,77,130,66,150,100,90,55,130,100};
  for (int i = 0;i < x_varden.length; i++){
    rita(x_varden[i],y_varden[i],D_varden[i],int(random(0,254)),int(random(0,254)),int(random(0,254)));
  }
}
