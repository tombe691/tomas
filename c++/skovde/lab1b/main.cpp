/*
Files: main.cpp
Summary:  Small roullette app. Place bet, spin wheel, win or loose.

Date: created 2020-07-07
Version: 1.0
Owner: Tomas Berggren
*/

#include <iostream>
#include <ctime>
#include <vector>
#include <algorithm>

using namespace std;
//check for invalid input by comparing with valid alternatives
bool checkValidInput(string input) {
    bool valid = false;
    vector<string> validInput;
    for (int i = 0; i<=36; i++) {
        validInput.push_back(to_string(i));
    }
    validInput.push_back("red");
    validInput.push_back("black");
    validInput.push_back("q");

    for (int j=0;j<validInput.size();j++){
        valid = validInput[j].compare(input)==0;
        if (valid){
            break;
        }
    }
    return valid;
}

//to see if user betting on colour won or not
string checkColour(int x) {
    string colour = "pink";
    switch(x)
    {
        case 1:
        case 2:
        case 3:
        case 5:
        case 7:
        case 9:
        case 12:
        case 14:
        case 16:
        case 18:
        case 19:
        case 21:
        case 23:
        case 25:
        case 27:
        case 30:
        case 32:
        case 34:
        case 36:
            colour = "red";
            break;
        case 4:
        case 6:
        case 8:
        case 10:
        case 11:
        case 13:
        case 15:
        case 17:
        case 20:
        case 22:
        case 24:
        case 26:
        case 28:
        case 29:
        case 31:
        case 33:
        case 35:
            colour = "black";
            break;
        case 0:
            colour = "green";
            break;
        default:
            cout << "not a valid number";
    }
    return colour;
}

//function to place valid bet
int placeBet(int* balance, bool* isRunning) {
    int bet;
    cout << "Pick a bet! (100 kr, 300 kr or 500 kr)" << std::endl;
    cin >> bet;
    while (cin.fail() || (bet!=100 && bet!=300 && bet!=500))
    {
        cin.clear(); // clear the input stream
        cin.ignore(INT_MAX, '\n'); // ignore remaining input
        cout << "You can only enter 100, 300 eller 500.\n";
        cout << "Try again, pick a bet! \n";
        cin >> bet;
    }
    if (bet > *balance) {
        cout << "insufficient funds, you need more money.";
        cout << "game over";
        *isRunning = false;
    }
    else {
        *balance -= bet;
    }
    return bet;
}

//input function for number or colour
string placeNrOrColour(bool* isRunning) {
    bool valid = false;
    string choice;
    while(!valid) {
        cout << "Pick \na colour (red or black)\n q to quit or \na number (0-36)!" << std::endl;
    cin >> choice;
    while (cin.fail())
    {
        cin.clear(); // clear the input stream
        cin.ignore(INT_MAX, '\n'); // ignore remaining input
        cout << "You can only enter 0-36, red or black.\n";
        cout << "Try again, pick a colour or a number! \n";
        cin >> choice;
    }
    transform(choice.begin(), choice.end(), choice.begin(), ::tolower);
    valid = checkValidInput(choice);
        if (choice.compare("q") == 0) {
            *isRunning = false;
        }
    }
    return choice;
}

//check if the bet should return 10 times, 2 times or nothing
int calculateReturn(string choice, int winningNr, int bet) {
    //nr win
    if (choice.compare(to_string(winningNr)) == 0) {
        cout << "you win 10 times the bet on nr!!" << endl;
        bet *= 10;
        cout << "the winning amount is " << bet << endl;
    }
    //colour win
    else if (checkColour(winningNr).compare(choice) == 0) {
         cout << "you win 2 times the bet on colour!!" << endl;
         bet *= 2;
         cout << "the winning amount is "<<bet<<endl;
    }
    //all other cases loose
    else {
         cout << "you loose the bet of " << bet << endl;
         bet = 0;
    }
    return bet;
}

//spin the wheel
int spin(){
    int winningNr;
    double time = 1;
    cout << "the wheel is spinning..!" << endl;
    for(int i=0; i<30;i++) {
        cout.flush();
        winningNr = rand() % 36 + 1;
        cout << winningNr << " ";
        for(int j=0; j<80000000;j++) {
            for(int k=0; k<time;k++) {
                //creating delay waiting for the ball to stop
            }
        }
        //decreasing speed
        time*=1.1;
    }
    cout << endl;
    return winningNr;
}

//main method
int main() {
    int balance = 1000;
    int* balancePointer;
    balancePointer = &balance;
    srand(time(0));
    int bet;
    string choice = "";
    string winningColour;
    int winningNr;
    bool isRunning = true;
    bool* isRunningPointer = &isRunning;
    while (isRunning) {
        bet = placeBet(balancePointer, isRunningPointer);
        if (isRunning==false){
            break;
        }
        choice = placeNrOrColour(isRunningPointer);
        if (isRunning==false){
            break;
        }
        winningNr = spin();
        winningColour = checkColour(winningNr);
        cout << "the winning nr is " << winningNr << " and the colour is " << winningColour << endl;
        balance += calculateReturn(choice, winningNr, bet);
        cout << "new balance: " << balance << endl;
    }
    return 0;
}

