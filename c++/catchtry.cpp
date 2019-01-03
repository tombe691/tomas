#include <iostream>
using namespace std;

double division(int a, int b) {
   
   return (a/b);
}

int main () {
   int x = 50;
   int y = 0;
   double z = 0;
   cin >> y;
   try {
      z = division(x, y);
      cout << z << endl;
   } catch (const char* msg) {
     cerr << msg << endl;
   }
   cout << "try again?";
   cin >> y;
   return 0;
}
