#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

int main() {
    int answer;
    bool stop = false;
    while(!stop) {
        printf("Enter the size of the table:\t");
        scanf("%d", &answer);
        printf("X | ");
        for (int i = 1; i<11; i++)
        {
            printf("\t%d", i);
        }
        printf("\n");
        for (int i = 1; i<43; i++)
        {
            printf("_ ");
        }
        printf("\n");
	for (int i = 1; i<=answer; i++)
        {
            printf("%d |\t%d\t%d\t%d\t%d\t%d\t%d\t%d\t%d\t%d\t%d\n",
		   i, i, i*2, i*3, i*4, i*5, i*6, i*7, i*8, i*9, i*10);
        }
    }
    return 0;
}
