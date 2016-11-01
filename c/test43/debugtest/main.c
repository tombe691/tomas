#include <stdio.h>
#include <stdlib.h>

void print() {
    printf("new line %d\n", atoi("7"));
}
int main()
{
    int a[4] = {1, 2, 3, 4};
    int i;
    for(i=0;i<4;i++) {
        printf("Hello world! %d\n", a[i]);
        print();
    }
    return 0;
}
