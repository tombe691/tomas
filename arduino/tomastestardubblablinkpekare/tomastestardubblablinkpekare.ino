
// the setup function runs once when you press reset or power the board
  int a;
  int b;

void setup() {
  // initialize digital pin LED_BUILTIN as an output.
  pinMode(13, OUTPUT);
  pinMode(12, OUTPUT);
  a = 1;
  b = 0;
//  Serial.begin(115200);  //Initialize serial
}

void swap(int &at, int &bt)
{
 int temp = bt;
 bt = at;
 at = temp;
}

// the loop function runs over and over again forever
void loop() {
//  Serial.print("value of a = ");
//  Serial.println((uint16_t)&a,HEX);
//  Serial.print("adress of a = ");
//  Serial.println((uint16_t)&a,HEX);
  swap(a, b);
  digitalWrite(12, a);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(13, b);   // turn the LED on (HIGH is the voltage level)
  delay(5000);                       // wait for a second
}
