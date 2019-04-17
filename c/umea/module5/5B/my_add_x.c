#include <stdio.h>
#include <stdlib.h>

int part_b(int argc,char *argv[]) {
  int sum = 0;
  for (int i = 0; i < argc; ++i) { 
    sum += atoi(argv[i]);
  }
  return sum;
}

int main(int argc,char *argv[])
{
  int sum = part_b(argc, argv);
  printf("summan ar: %d", sum);
  return 0;
}
