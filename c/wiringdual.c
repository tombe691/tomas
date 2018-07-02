#include <wiringPi.h>
//#include <stdio.h>

/*
void digitalWrite(int pin, int state) {
  printf("pin %d state %d\n", pin, state);
}

void delay2(int milisek) {
  int c, d;
 
   for (c = 1; c <= 32767; c++)
       for (d = 1; d <= 32767; d++)
       {}
 
}
*/
int main (void)
{
  wiringPiSetup () ;
  pinMode (0, OUTPUT) ;
  //int HIGH = 1;
  //int LOW = 0;

  for (;;)
  {
    
    digitalWrite(0, HIGH);
    delay2(500);
    digitalWrite(0,  LOW);
    delay2(500);
  }
  return 0 ;
}
