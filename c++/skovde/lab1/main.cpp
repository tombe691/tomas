#include <iostream>
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
    loop();
    return 0;
}

