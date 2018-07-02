#include <stdio.h>
#define MAX(a,b)   ((a) > (b) ? (a) : (b))

int main(void)
{
    int x = 10, y = 15;
    float u = 2.0, v = 3.0;
    double s = 5, t = 5;
    printf("Max of two integers %d and %d is: %d\n", x, y, MAX(x,y));
    printf("Max of two floats %.2f and %.2f is: %.2f\n", u, v, MAX(u,v));
    printf("Max of two doubles %.2lf and %.2lfis: %lf\n", s, t, MAX(s,t));
    return 0;
}
