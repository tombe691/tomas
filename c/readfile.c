#include<stdio.h>
#include<stdlib.h>
int main()
{
  FILE *ptr_file;
  char buf[10];

  printf("hello");
  ptr_file =fopen("c:/tomas/c/simple/test5555556567753665.txt","w+");
  if (!ptr_file)
    return 1;

  while (fgets(buf,10, ptr_file)!=NULL){
    printf("%s",buf);
    system("pause");
  }

  fclose(ptr_file);
  return 0;
}
