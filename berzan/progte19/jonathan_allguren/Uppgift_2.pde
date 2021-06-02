int[] x = {100,50,130,240,350,400,160,500,530,580,500,100,300,180,200};
int[] y = {530,500,480,300,180,200,220,180,100,89,500,100,100,50,130};
int[] d = {100,80,120,100,200,170,77,130,66,150,100,90,55,130,100};
float r1 = random(255);
int r = int(r1);
float g1 = random(255);
int g = int(g1);
float b1 = random(255);
int b = int(b1);



void setup(){
background(0);
size(600,600);

}

void ritaCirkel(int x, int y, int d, int r, int g, int b){
  for(int i = 0; i >= 14; i++){
    fill(r+i,g+i,b+i);
    ellipse(x+i,y+i,d+i,d+i);
    
  }
  
}
