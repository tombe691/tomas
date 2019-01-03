#include <stdio.h>
#include <string.h>
#include <stdbool.h>

char* pbool(bool test)
{
  if (test){
    return "true";
  }
  else {
    return "false";
  }
}

int main()
{
   char a1[100], b1[100];
   _Bool test = 0;
   bool test2 = true;
   printf("Enter the string to check if it is a palindrome\n");
   gets(a1);
 
   strcpy(b1,a1);
   strrev(b1);
 
   if (strcmp(a1,b1) == 0)
      printf("Entered string is a palindrome.\n");
   else
      printf("Entered string is not a palindrome.\n");

   //printf("%d %s", test, pbool(test2));
   int x = 30;
   int y = 10;
   int z = 5;

   printf("\n");
   printf("1 %s\n", pbool(x >= 10 && x <= 10));
   printf("2 %s\n", pbool(x < y && y > x));
   printf("3 %s\n", pbool((x == y + z) || (x + 10 < 20)));
   printf("4 %s\n", pbool(x == (y + z)*2));


	double pris = 32;
	int antalSidor = 200;
	char titel[] = "C fran borjan";
 	printf("Titel ar %s\n antal sidor %d, \tpris %.3f\n", titel, antalSidor, pris);


   return 0;
}
