#include<stdio.h>
#include<string.h>

int main()
{
    char texten[10];

    FILE *ptr_file =fopen("/simple/test2.txt","r");
    if (!ptr_file)
        return 1;

    while (fgets(texten,10, ptr_file)!=NULL) {
        char vowels[] = "aAeEiIoOuUyYÂ≈‰ƒˆ÷";

        for(int i=0; i<strlen(texten); i++) {
            char c = texten[i];
            if (!strchr(vowels, c)) {
                printf("%co%c", texten[i], texten[i]);
            } else {
                printf("%c", texten[i]);
            }
        }
    }
    fclose(ptr_file);
    return 0;
}
