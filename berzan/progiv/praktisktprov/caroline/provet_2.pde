int[]x_varden = {100,50,130,240,350,400,160,500,530,580,500,100,300,180,200};
int[]y_varden = {530,500,480,300,180,200,220,180,100,89,500,100,100,50,130};
int[]d_varden = {100,80,120,100,200,170,77,130,66,150, 100,90,55,130,100};

void setup () {
size(700,700);
ritaCirkel(x_varden[0],y_varden[0],d_varden[0],123,123,123);
}
void ritaCirkel(int x, int y, int d, int r, int g, int b){
  ellipse(x,y,d,d);
}
