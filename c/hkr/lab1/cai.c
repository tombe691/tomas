#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <stdbool.h>

// main function
int main() {
    srand(time(NULL));
    int rand_nr_a = rand() % 101;
    int rand_nr_b = rand() % 101;

    int answer;
    bool stop = false;

    while(!stop) {
        printf("How much is %d + %d? \tAnswer = \n", rand_nr_a, rand_nr_b);

        scanf("%d", &answer);
        //printf("answer = %d\n", answer);
        //printf("a + b = %d\n", rand_nr_a + rand_nr_b);
        if (rand_nr_a + rand_nr_b == answer) {
            printf("very good");
            stop = true;
        } else {
            printf("No. Please try again.\n");
        }
    }
    return 0;
