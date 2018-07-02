/**********************************************************************/
// File:	debug.cpp
// Summary:	Practice file for Lab 1, Step 1
//			The program reads a string of characters. Prints all
//			occurrences of letters and numbers, sorted in alphabetical
//			and numerical order. Letters will be converted to uppercase.
//			Other characters are filtered out, while number of white
//			spaces are counted.
// Version: Version 1.2 - 2018-03-17
// Author:	Anne Norling
// Bugfixer:Tomas Berggren
// -------------------------------------------
// Log:	2003-08-11	Created the file. Anne
//		2013-03-17	Uppdate  Version 1.1 by Anne.
//					Converted to English and VS 2012
//		2015-03-05	Revised by Anne. Converted to VS 2013
//      2018-03-17  Tomas Berggren removed errors
/**********************************************************************/

#include <stdio.h>
#include <string.h>
#include <ctype.h>

const int SIZE = 100;


int main()
{
    char *pStr;
    char str[SIZE];
    // = "",
    char newStr[SIZE];
    // = "",
    char ch;
    int count, i = 0, j = 0;

    printf("%s\n", "Enter a number of mixed characters: ");
    //scanf("%s", str);
    gets(str);
    pStr = str;
    printf("pStr %s len %d str %s len %d\n", pStr, strlen(pStr), str, strlen(str));
    while (*pStr != '\0')
    {
        if (isalnum(*pStr)) {
            ch = toupper(*pStr);
            newStr[i++] = ch;
        }
        if (*pStr == ' ') {
            count++;
        }
        pStr++;
    }
    newStr[i] = '\0';
    printf("%d %s %s %d %s\n", strlen(str) - strlen(newStr), " characters were filtered out,",
         " out of which ", count, " whitespaces were encountered.");

    int temp;
    for (i = 0; i < strlen(newStr); i++)//removed -1 tombe
    {
        for (j = i + 1; j < strlen(newStr); j++)
        {
            if (newStr[j] < newStr[i])	// sorts in alphabetical
            {						// and numerical order
                temp = newStr[i];
                newStr[i] = newStr[j];
                newStr[j] = temp;
            }
        }
    }
      printf("%s %s\n", "New sorted string: ", newStr);

    return 0;
}
