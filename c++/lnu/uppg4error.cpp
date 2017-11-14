//-----------------------------------------------------------------------
// Object:	This program has logical errors. Find and correct them. 
//			There are miscalculations and the program can't be stopped with 'N'.
//			Document your changes with comments or in log.
//-----------------------------------------------------------------------
// File:    LogicalError.cpp
// Summary: Reads price and number of articles from user. Calculates and prints 
//			number, tax rate and price with tax rate (swedish "moms").
// Version: 1.1
// Owner:   Tommy Löfqvist
//-----------------------------------------------------------------------
// Log: 2005-03-09: Created the file, Mats!
//		2009-08-14: Revised by Tommy. Number of items is now included. 
//					Code for the problem is placed in a separate function 
//					that is iterated in the main function.
//		2012-10-21: Revised by Anne. Converted to English version and VS 2012
//		2014-11-11: Revised by Anne for VS 2013
// 
//-----------------------------------------------------------------------

// Preprocessor directives
#include <iostream>
#include <iomanip>
using namespace std;

//Prototypes
void priceCalculation();

int main()
{
	char answer;
	do
	{
		priceCalculation();
		cout << "One more time? (Y/N): ";
		cin >> answer;
	}while (answer == 'Y' || answer == 'y'); //one =-sign was missing for Y, caused declaration instead of comparison

	return 0;
}

//-----------------------------------------------------------------
// void priceCalculation()
//
// Summary:	Reads price and number of articles from user. Calculates and prints 
//			number of articles, tax rate and price with rate.
// Returns:	-
//-----------------------------------------------------------------

void priceCalculation()
{
	// Define and initialize constants and variables
	const int RATE = 25;		// tax rate in percent

	double price = 0;			// price per piece
	int nrOfArticles = 0;		// number of articles
	double rateSEK = 0;			// tax rate in SEK
	double totalPrice = 0;		// price incl. tax rate

	// 	Read price and number of articles
	cout << "Enter the price excl. the tax rate (swedish moms): ";
	cin >> price;

	cout << "Enter the number of articles: ";
	cin >> nrOfArticles;

	// Calculate total price and tax rate
	rateSEK = price * RATE/100; //totalPrice was 0, times anything stays zero, changed to price * RATE and divided with 100 to get %
	totalPrice = nrOfArticles * price +rateSEK; //since rateSEK was calculated above, I replaced the second rate/calculation with the value already calculated
	// Show result with 2 decimal places
	cout << fixed << showpoint << setprecision(2);

	cout << nrOfArticles << " number of articles cost " << totalPrice << " kr. " 
		 << endl << "Of this " << rateSEK << " kr is the tax rate." << endl;
}
