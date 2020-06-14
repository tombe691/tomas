#include <iostream>
#include <ctime>
#include "conio.h"
using namespace std;

//void loop();
void loop() {
    bool isRunning = true;
    while (isRunning) {
        int bet;
        string choice;
        cout << "V\x84lj en insats!" << std::endl;
        cin >> bet;

        cout << "V\x84lj en f\x84rg eller ett nummer!" << std::endl;
        cin >> choice;
        cout << choice;

        if (choice.compare("sluta") == 0) {
            isRunning = false;
        }
    }
}

int main() {
    srand(time(0));
    loop();
    int roundNr;
    double time = 1;
    for(int i=0; i<30;i++) {
        cout.flush();
        roundNr = rand() % 36 + 1;
        cout << roundNr << ", ";
        for(int j=0; j<100000000;j++) {
            for(int k=0; k<time;k++) {

            }

        }
        time*=1.1;
        //cout << '\b\b\b\b';
        //cout << endl;
    }
    return 0;
}

