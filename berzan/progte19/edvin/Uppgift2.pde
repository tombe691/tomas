int[] xvarden = { 100,50,130,240,350,400,160,500,530,580,500,100,300,180,200 };
int[] yvarden = { 530,500,480,300,180,200,220,180,100,89,500,100,100,50,130 };
int[] dvarden = { 100,80,120,100,200,170,77,130,66,150,100,90,55,130,100 };
float r;
float g;
float b;

void cirkel(int x,int y,int d,int r,int g, int b){
  fill(r,g,b);
  ellipse(x,y,d,d);  
}
void setup(){
  size(500,500);
  for(int i=0;i<=14;i++){
    r = random(1,255);
    g = random(1,255);
    b = random(1,255);
    int R = int(r);
    int G = int(g);
    int B = int(b);
    cirkel(xvarden[i], yvarden[i], dvarden[i], R, G, B);
  }
  
}
