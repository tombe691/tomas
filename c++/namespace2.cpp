#include <stdio.h>
#include <iostream>
using namespace std;

// first name space
namespace first_space {
   void func() {
     printf("Inside first_space\n");
   }
}

// second name space
namespace second_space {
   void func() {
     printf("Inside second_space\n");
   }
}

int main () {
  // Calls function from first name space.
  first_space::func();
  
  // Calls function from second name space.
  second_space::func(); 
  
  return 0;
}
