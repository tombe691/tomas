/*
  Blink
  Turns on an LED on for one second, then off for one second, repeatedly.

  Most Arduinos have an on-board LED you can control. On the UNO, MEGA and ZERO 
  it is attached to digital pin 13, on MKR1000 on pin 6. LED_BUILTIN is set to
  the correct LED pin independent of which board is used.
  If you want to know what pin the on-board LED is connected to on your Arduino model, check
  the Technical Specs of your board  at https://www.arduino.cc/en/Main/Products
  
  This example code is in the public domain.

  modified 8 May 2014
  by Scott Fitzgerald
  
  modified 2 Sep 2016
  by Arturo Guadalupi
  
  modified 8 Sep 2016
  by Colby Newman
*/

#define PIN9 9
#define PIN10 10
#define PIN12 12

// the setup function runs once when you press reset or power the board
void test2() {
  digitalWrite(PIN9, HIGH);   // turn the LED on (HIGH is the voltage level)
  analogRead(A0);
  delay(100);                       // wait for a second
  digitalWrite(PIN9, LOW);    // turn the LED off by making the voltage LOW
  delay(100);                       // wait for a second

  digitalWrite(PIN10, LOW);    // turn the LED off by making the voltage LOW
  delay(100);                       // wait for a second
  digitalWrite(PIN10, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(100);                       // wait for a second
}


void test() {
  digitalWrite(LED_BUILTIN, HIGH);   // turn the LED on (HIGH is the voltage level)
  //test2();
  delay(1000);                       // wait for a second
  digitalWrite(LED_BUILTIN, LOW);    // turn the LED off by making the voltage LOW
test2();
delay(1000);                       // wait for a second
digitalWrite(LED_BUILTIN, HIGH);   // turn the LED on (HIGH is the voltage level)
test2();
delay(1000);                       // wait for a second
  digitalWrite(LED_BUILTIN, LOW);    // turn the LED off by making the voltage LOW
  delay(1000);                       // wait for a second
test2();
digitalWrite(LED_BUILTIN, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(1000);                       // wait for a second
  digitalWrite(LED_BUILTIN, LOW);    // turn the LED off by making the voltage LOW
  delay(1000);  // wait for a second
test2();
digitalWrite(LED_BUILTIN, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(250);                       // wait for a second
  digitalWrite(LED_BUILTIN, LOW);    // turn the LED off by making the voltage LOW
  delay(250);                       // wait for a second
test2();
digitalWrite(LED_BUILTIN, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(250);                       // wait for a second
  digitalWrite(LED_BUILTIN, LOW);    // turn the LED off by making the voltage LOW
  delay(250);                       // wait for a second
test2();
digitalWrite(LED_BUILTIN, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(250);                       // wait for a second
test2();
digitalWrite(LED_BUILTIN, LOW);    // turn the LED off by making the voltage LOW
  delay(250);                       // wait for a second
test2();
digitalWrite(LED_BUILTIN, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(1000);                       // wait for a second
test2();
digitalWrite(LED_BUILTIN, LOW);    // turn the LED off by making the voltage LOW
  delay(1000);                       // wait for a second
test2();
digitalWrite(LED_BUILTIN, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(1000);                       // wait for a second
test2();
digitalWrite(LED_BUILTIN, LOW);    // turn the LED off by making the voltage LOW
  delay(1000);                       // wait for a second
test2();
digitalWrite(LED_BUILTIN, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(1000);                       // wait for a second
test2();
digitalWrite(LED_BUILTIN, LOW);    // turn the LED off by making the voltage LOW
  delay(1000);  // wait for a second
test2();
delay(5000);  // wait for a second
  
  
}
  
void setup() {
  // initialize digital pin LED_BUILTIN as an output.
  pinMode(LED_BUILTIN, OUTPUT);
  pinMode(PIN9, OUTPUT);
  pinMode(PIN10, OUTPUT);
  pinMode(PIN12, OUTPUT);
  pinMode(4, OUTPUT);
  pinMode(A0, INPUT);
  Serial.begin(9600);
}

// the loop function runs over and over again forever
void loop() {
  //test2();
  analogWrite(12, 155);
  for (int i = 0; i<225; i++)
  {
    analogWrite(9, i);
    delay(10);
  }
  analogWrite(10, 250);
  Serial.println(analogRead(A0)/57);
  delay(500);
  analogWrite(10, 15);
  Serial.println(analogRead(A0)/57);
  delay(500);
  analogWrite(4, 155);
  delay(500);
analogWrite(4, 250);
  delay(500);  //Serial.println(analogRead(A1));
}
