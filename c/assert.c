// bowling_game_test.c
#include "bowlinggame.h"
#include <assert.h>
#include <stdbool.h>
#include <stdio.h>
static void test_gutter_game() {
 bowling_game_init();
 for (int i=0; i<20; i++)
 bowling_game_roll(0);
 assert(bowling_game_score() == 0 && "test_gutter_game()" );
}

int main() {
 test_gutter_game();
 printf("test");
}
//#include <stdio.h>
//#include <assert.h>

/*int main() {
    printf("Hello, World!\n");
    return 0;
}
*/
