int[] x_value={100,50,130,240,350,400,160,500,530,580,500,100,300,180,200};
int[] y_value={530,500,480,300,180,200,220,180,100,89,500,100,100,50,130};
int[] d_value={100,80,120,100,200,170,77,130,66,150,100,90,55,130,100};

int st=0;
int r;
int g;
int b;


void setup(){
  size(600,600);
  background(0);
  while(st<15){
    r=int(random(0,256));
    g=int(random(0,256));
    b=int(random(0,256));
    ritaCirkel( x_value[st] ,y_value[st] , d_value[st] , r , g , b );
    st++;
  
  }
  
}

void ritaCirkel(int x, int y, int d, int r, int g, int b){
  fill(r,g,b);
  ellipse(x,y,d,d);
  
}
