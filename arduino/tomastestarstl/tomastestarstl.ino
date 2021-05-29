#include <ArduinoSTL.h>
using namespace std;
int a = 0;
list<int> myList = new list<int>;
void setup() {
  Serial.begin(9600);
 
  // put your setup code here, to run once:

}

void loop() {
  list.push_back(a);
  // put your main code here, to run repeatedly:
  //cout << a << endl;
  Thingspeak.Write(a);
  a++;
  delay(1000);
}
