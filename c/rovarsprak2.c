#include<stdio.h>
#include<string.h>

int main()
{
  char texten[10];
  printf("1\n");
  FILE *ptr_file =fopen("simple/test.txt","r");
  FILE *fp;

fp = fopen("c:/tomas/c/simple/test34.txt", "w+");
//fp = fopen("simple/test2.txt", "r+");
  if (!ptr_file)
    return 1;
  printf("2\n");
  while (fgets(texten,10, ptr_file)!=NULL){
    char vowels[] = "aAeEiIoOuUyYÂ≈‰ƒˆ÷";
    printf("3\n");
    for(int i=0;i<strlen(texten);i++) {
      printf("4\n");
      char c = texten[i];
      if (!strchr(vowels, c)) {
	printf("%co%c", texten[i], texten[i]);
	fprintf(fp, "%co%c", texten[i], texten[i]);
      } else {
	printf("%c", texten[i]);
	fprintf(fp, "%c", texten[i]);
      }
    }
  }
  fclose(ptr_file);
     fclose(fp);

  return 0;
}
