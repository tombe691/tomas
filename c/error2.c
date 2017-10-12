#include <stdlib.h>
int main(void) {
    asm("pushf\norl $ 0x40000, (%esp)\npopf\n");
    *((int*) (((char*) malloc(5)) + 1)) = 23;
    return 0;
}
