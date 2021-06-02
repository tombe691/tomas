float x = 200;
float y = 200;

int s = 0;
int speedx = 7;



void setup() {
 size(400,400);

}

void draw(){
  background(50);
  ellipse(x, y, 25,25);


x = x + speedx;
y = y + speedx;

if(s > width || (x <=0)){
speedx = speedx * -1;
}

//if(y > height || speedx <=0);
//speedx = speedx * -1;
//}
}
