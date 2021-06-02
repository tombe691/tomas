void setup(){
  size(800,800);
  int[] x_varden= {100,50,130,240,350,400,160,500,530,580,500,100,300,180,200};
  int[] y_varden={530,500,480,300,180,200,220,180,100,89,500,100,100,50,130};
  int[] d_varden={100,80,120,100,200,170,77,130,66,150,100,90,55,130,100};
  int r= int(random(255));
  int g= int(random(255));
  int b= int(random(255));
  ritaCirkel(x_varden,y_varden,d_varden,r,g,b);
  }
  
  void ritaCirkel(int [] x_varden, int [] y_varden, int [] d_varden, int r, int g, int b){
    while(true){

  for (int i = 0; i < x_varden.length; i++){
    
  ellipse(x_varden[i], y_varden[i], d_varden[i], d_varden[i]);
  fill(r,g,b);
}}}
  
  
  ///skulle kunna sätta in int rgb i void ritacirkel men då kan jag inte kalla ritacirkel funktionen enligt uppgift.
