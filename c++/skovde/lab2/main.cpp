/*
Files: main.cpp
Summary:  Small card app. Runs in three rounds, highest card wins.

Date: created 2020-07-24
Version: 1.0
Owner: Tomas Berggren
*/

#include <iostream>
#include <ctime>
#include <string>

using namespace std;

// shuffle function where cards get new positions
void shuffledeck(string card[], int nrofcards)
{
    // init random seed
    srand(time(0));
    //going through the positions
    for (int i=0; i<nrofcards ;i++)
    {
        // create a random position of remaining ones
        int randomposition = i + (rand() % (nrofcards -i));
        //using standard method to swap to positions
        swap(card[i], card[randomposition]);
    }
}
//function to rank and compare colours
int getColourRank(char colour, string* colourname)
{
    int rank = 0;
    switch (colour) {
        case 'S' :
            rank = 4;
            *colourname = "spades";
            break;
        case 'H' :
            rank = 3;
            *colourname = "hearts";
            break;
        case 'D' :
            rank = 2;
            *colourname = "diamonds";
            break;
        case 'C' :
            rank = 1;
            *colourname = "clubs";
            break;
        default :
            cout << "Invalid colour" << endl;
    }
    return rank;
}
//function to return winning player for a round
int comparecolours(char player1colour, char player2colour)
{
    string cardcolour;
    int p1rank = getColourRank(player1colour, &cardcolour);
    int p2rank = getColourRank(player2colour, &cardcolour);
    int winningplayer = 0;
    if (p1rank > p2rank){
        winningplayer = 1;
    }
    else if (p1rank < p2rank){
        winningplayer = 2;
    }
    else if (p1rank == p2rank){
        cout << "#### should not happen equal";
    }
    else {
        cout << "### should not happen";
    }
    return winningplayer;
}
//function to compare card values, if equal call colour compare
int comparecards(string player1card, string player2card)
{
    string player1colour = player1card.substr(0, 1);
    string player1nr = player1card.substr(1);
    char p1col = player1colour[0];
    string player2colour = player2card.substr(0, 1);
    string player2nr = player2card.substr(1);
    char p2col = player2colour[0];
    int winningplayer = 0;
    int player1number = stoi(player1nr);
    int player2number = stoi(player2nr);

    if (player1number > player2number){
        winningplayer = 1;
    }
    else if (player1number < player2number){
        winningplayer = 2;
    }
    else if (player1number == player2number){
        winningplayer = comparecolours(p1col, p2col);
    }
    else {
        cout << "should not happen";
    }
    return winningplayer;
}
//debug function to print out the current order of cards
void printallcardsincurrentorder(string cards[]){
    for (int j=0; j<52; j++)
        cout << cards[j] << " ";
    cout << endl;
}
//translate numbers to correct names if number > 10
string printcorrectcardnames(string number){
    string name = "joker";
    switch (stoi(number)) {
        case 14 :
            name = "ace";
            break;
        case 13 :
            name = "king";
            break;
        case 12 :
            name = "queen";
            break;
        case 11 :
            name = "jack";
            break;
        default :
            name = number;
    }
    return name;
}
//print the status for each round
void printcurrentstatus(int player1points, int player2points, int player1wins,
                        int player1losses, int player2wins, int player2losses)
{
    cout << "current score, player 1: " << player1points << ", player 2: " << player2points << endl;
    cout << "player 1 has " << player1wins << (player1wins>1? " wins" : " win") << " and " << player1losses;
    cout << (player1losses>1? " losses" : " loss") << endl;
    cout << "player 2 has " << player2wins << (player2wins>1? " wins" : " win") << " and " << player2losses;
    cout << (player2losses>1? " losses" : " loss") << endl;
    cout << "press c to continue";
}
//print the winner
void printwinner(int player1points, int player2points)
{
    cout << "The best of three winner is:";
    if (player1points>player2points){
        cout << "player 1";
    }
    else if (player1points<player2points){
        cout << "player 2";
    }
}
//the main game loop
void gameloop()
{
    string symbols[] = {"S", "H", "D", "C"};
    string b[52];
    int count = 0;
    for (int colour = 0; colour < 4;colour++) {
        for (int nr=2; nr<15; nr++) {
            b[(nr+count)-2] = symbols[colour]+to_string(nr);
        }
        count +=13;
    }
//    printallcardsincurrentorder(b);
    shuffledeck(b, 52);
    string player1card;
    string player2card;
    string cardcolour;
    int winningplayer = 0;
    int roundnumber = 1;
    int player1points = 0;
    int player2points = 0;
    int player1wins = 0;
    int player1losses = 0;
    int player2wins = 0;
    int player2losses = 0;
    for (int k=0; k<52 && roundnumber<4;) {
        cout << "round: " << roundnumber << endl;
        player1card = b[k];
        getColourRank(player1card[0], &cardcolour);
        //cout << "p1 colour = " << cardcolour << endl;
        cout << "player one's card is ";
        cout << printcorrectcardnames(player1card.substr(1)) << " of " << cardcolour << ", ";
        k++;
        player2card = b[k];
        getColourRank(player2card[0], &cardcolour);
        //cout << "p1 colour = " << cardcolour << endl;
        cout << "player two's card is ";
        cout << printcorrectcardnames(player2card.substr(1)) << " of " << cardcolour << "." << endl;
        k++;
        winningplayer = comparecards(player1card, player2card);
        cout << "Winning player this round is: player " << winningplayer << endl;
        if (winningplayer==1){
            player1points+=1;
            player1wins+=1;
            player2losses+=1;
        }
        else if (winningplayer==2){
            player2points+=1;
            player2wins+=1;
            player1losses+=1;
        }
        printcurrentstatus(player1points, player2points, player1wins,
                           player1losses, player2wins, player2losses);
        string next;
        cin >> next;
        cin.ignore();
        roundnumber++;
    }
    printwinner(player1points, player2points);
}
//main function
int main()
{
    gameloop();
    return 0;
}
