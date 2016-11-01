#include <stdio.h>
#include <stdlib.h>
int main()
{
    int i, howMany;
    float total;
    float average = 0.0;
    float *pointsArray;
    printf("How many students do you want to average? \n");
    scanf("%d", &howMany);
    pointsArray = (float *) malloc(howMany * sizeof(float));    //Allokerar minne för heltal
    printf("Enter the numbers! \n");
    //Fyller array med heltal
    for(i=0; i<howMany; i++){
        scanf("%f", &pointsArray[i]);
        total += pointsArray[i];    //Sparar alla heltal till "total"
    }
    printf("total är \n\t%f\n", total);  //Får in ut totala summan
    average =  total / howMany;
    printf("Average is %f", average);
    return 0;
}
