#include <iostream>
#include <string>


int main(){
  std::string msg;
  msg = "Donald Duck is poor";
  msg.replace(7, 4, "rich");
  std::cout << msg;
}

