#include <stdio.h>
#include <stdlib.h>
int main()
{
    int i, howMany;
    int total = 0;
    float average = 0.0;
    int *pointsArray;
    printf("How many students do you want to average? \n");
    scanf("%d", &howMany);
    pointsArray = (int *) malloc(howMany * sizeof(int));    //Allokerar minne för heltal
    printf("Enter the numbers! \n");
    //Fyller array med heltal
    for(i=0; i<howMany; i++){
      printf("total %d\n", total);
        scanf("%d", &pointsArray[i]);
        total += pointsArray[i];    //Sparar alla heltal till "total"
    }
    printf("\n\t%d\n", total);  //Får in ut totala summan
    average = (float)total / (float)howMany;

    printf("Average is %f", average);
    return 0;
}
