
// the setup function runs once when you press reset or power the board
  byte a;

void setup() {
  // initialize digital pin LED_BUILTIN as an output.
  pinMode(13, OUTPUT);
  pinMode(12, OUTPUT);
  a = 1;
//  Serial.begin(115200);  //Initialize serial
}

// the loop function runs over and over again forever
void loop() {
//  Serial.print("value of a = ");
//  Serial.println((uint16_t)&a,HEX);
//  Serial.print("adress of a = ");
//  Serial.println((uint16_t)&a,HEX);
 if(a&2){
        a = 1;
    }
    else{
        a = 2;
    }

  digitalWrite(12, a&1);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(13, a&2);   // turn the LED on (HIGH is the voltage level)
  delay(5000);                       // wait for a second
}
