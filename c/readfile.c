#include<stdio.h>
#include<stdlib.h>
int main()
{
  FILE *ptr_file;
  char buf[10];

  ptr_file =fopen("c:/tomas/c/simple/testutf8.txt","r");   //öppnar fil för läsning
  if (!ptr_file)
    return 1;
  //så länge vi inte kommer till slutet, läs in 10 tecken i taget, observera radbrytningar
  while (fgets(buf,10, ptr_file)!=NULL){      
    printf("%s",buf);
    system("pause");//väntar för att visa rad för rad
  }

  fclose(ptr_file);//glöm inte att stänga    i ansi krävs att man vet vilken teckentabell som ska navändas, annars blir det konstigt med konstiga tecken
  return 0;
}
