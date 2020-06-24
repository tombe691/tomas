#include <iostream>
#include <ctime>
#include "conio.h"
using namespace std;

//void loop();

int placeBet() {
    int bet;
    cout << "V\x84lj en insats!" << std::endl;
    cin >> bet;
    return bet;
}
string placeNrOrColour() {
    string choice;
    cout << "V\x84lj en f\x84rg eller ett nummer!" << std::endl;
    cin >> choice;
    cout << choice;
    return choice;
}

void loop(string choice, int winningNr) {
    bool isRunning = true;
    while (isRunning) {


        if (choice.compare("sluta") == 0) {
            isRunning = false;
        }
        else if (choice.compare(to_string(winningNr)) == 0) {
            cout << "win!!";
            isRunning = false;
        }
        else {
            cout << "loose!!";
        }
    }
}

int main() {
    srand(time(0));
    int bet = placeBet();
    string choice = placeNrOrColour();

    int winningNr;
    double time = 1;
    for(int i=0; i<30;i++) {
        cout.flush();
        winningNr = rand() % 36 + 1;
        cout << winningNr << ", ";
        for(int j=0; j<100000000;j++) {
            for(int k=0; k<time;k++) {

            }

        }
        time*=1.1;
        //cout << '\b\b\b\b';
        //cout << endl;
    }
    loop(choice, winningNr);
    return 0;
}

