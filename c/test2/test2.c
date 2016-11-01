#include <stdio.h>

static int print2(int var0){
  int var1 = 1;
  
  if (var1 == 1){
    int var2 = 2;
  }
  else {
    int var2 = 3; 
  }
  printf("Hello, Worldddd!\n");
  return var0;
}

extern void print(){
  int var0 = 0;
  int var3 = print2(var0);
}
