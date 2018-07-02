// smallobj.cpp
// demonstrates a small, simple object
#include <iostream>
using namespace std;
////////////////////////////////////////////////////////////////
class smallobj //define a class
{
private:
public:
  int somedata; //class data
  void setdata(int d) //member function to set data
  { somedata = d; }
  void showdata() //member function to display data
  { cout << "Data is " << somedata << endl; }
};
////////////////////////////////////////////////////////////////
int main()
{
  smallobj s1, s2; //define two objects of class smallobj
  s1.setdata(1066); //call member function to set data
  s2.setdata(1776);
  s1.showdata(); //call member function to display data
  s2.showdata();
  cout << s2.somedata;
  return 0;
}
