/*************************************************************
*
*         Program to print area an volume
*         Author:
*         Version:
*         Date:
***************************************************************/

#include <stdio.h>
#include <math.h>

double getWeight() {
    double weight;
    printf("skriv in vikt med . som separator :");
    scanf("%lf", &weight);
    return weight;
}

double getHeight() {
    double height;
    printf("skriv in langd i meter med . som separator : ");
    scanf("%lf", &height);
    return height;
}

double calculateBmi(double weight, double height){
    double h2 = pow(height, 2);

    return weight/h2;
}
int main() {
    double weight, height, bmi;
    weight = getWeight();
    height = getHeight();
    bmi = calculateBmi(weight, height);
    printf("du har ett bmi pa %f", bmi);
    return 0;
}