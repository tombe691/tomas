#include <iostream>
#include <vector>
using namespace std;

template <typename T>
void write_vector(const vector<T>& V)
{
   cout << "The numbers in the vector are: " << endl;
  for(int i=0; i < V.size(); i++)
    cout << V[i] << " ";
}

int main()
{
  int input;
  vector<int> V1;
  vector<int> V2;
  cout << "Enter your numbers to be evaluated: " << endl;
  while (cin >> input)
    V1.push_back(input);

  V2 = V1;
  write_vector(V2 );
  return 0;
}
