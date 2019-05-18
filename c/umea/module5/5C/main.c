#include <stdio.h>
#include <stdlib.h>
#include "my_add.h"

void add_with_args(int argc,char *argv[]) {
    if (argc == 3){
      printf("tal 1: %d plus tal 2: %d  = %d\n",atoi(argv[1]), atoi(argv[2]),
	     add(atoi(argv[1]), atoi(argv[2])));
    }
    else {
        printf("wrong number of arguments, start program and add two integers, a.exe 1 2");
    }
}

int main(int argc,char *argv[])
{
    add_with_args(argc, argv);
    return 0;
}
