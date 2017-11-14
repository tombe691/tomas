#include <stdio.h>
#include <stdlib.h>
#include <math.h>

struct Point {
    int x, y;
};


double getDistance(struct Point a, struct Point b)
{
    double distance;
    distance = sqrt((a.x - b.x) * (a.x - b.x) + (a.y-b.y) *(a.y-b.y));
    return distance;
}



int main()
{
    struct Point a, b;
    printf("Enter coordinate of point a: ");
    scanf("%d %d", &a.x, &a.y);
    printf("Enter coordinate of point b: ");
    scanf("%d %d", &b.x, &b.y);
    printf("Distance between a and b: %lf\n", getDistance(a, b));


    return 0;
}
