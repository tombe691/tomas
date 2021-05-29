#include<stdio.h>
#include<stdlib.h>
int main()
{
  FILE *ptr_file;
  char buf[50];

  ptr_file =fopen("c:/tomas/c/simple/test99.txt","r");   //�ppnar fil f�r l�sning
  if (!ptr_file)
    return 1;
  //s� l�nge vi inte kommer till slutet, l�s in 10 tecken i taget, observera radbrytningar
  while (fgets(buf,50, ptr_file)!=NULL){      
    printf("%s",buf);
    system("pause");//v�ntar f�r att visa rad f�r rad
  }

  fclose(ptr_file);//gl�m inte att st�nga    i ansi kr�vs att man vet vilken teckentabell som ska nav�ndas, annars blir det konstigt med konstiga tecken
  return 0;
}
