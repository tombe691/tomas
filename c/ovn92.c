#include <stdio.h>
int main() {
    printf("Skriv något!\n");
    int n = 0, c;
    while ( (c = getchar()) != EOF ) {
        n++;
        printf("%c", c);
    }
    printf("Du skrev %d tecken\n", n);
}