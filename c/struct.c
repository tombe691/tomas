#include <stdio.h>
#include <string.h>
 
struct Person {
   char  firstname[50];
   char  surname[50];
   int  age;
   double   shoesize;
};
 
int main( ) {

   struct Person Person1;        /* Declare Person 1 */
   struct Person Person2;        /* Declare Person 2 */
 
   /* person 1 specification */
   strcpy( Person1.firstname, "Tomas");
   strcpy( Person1.surname, "Berggren"); 
   Person1.age = 46;
   Person1.shoesize = 40.5;

   /* book 2 specification */
   strcpy( Person2.firstname, "Nisse");
   strcpy( Person2.surname, "Hult"); 
   Person2.age = 72;
   Person2.shoesize = 43.7;
 
   /* print Person1 info */
   printf( "Person 1 firstname : %s\n", Person1.firstname);
   printf( "Person 1 surname : %s\n", Person1.surname);
   printf( "Person 1 age : %s\n", Person1.age);
   printf( "Person 1 shoe size : %d\n", Person1.shoesize);

   /* print Person2 info */
   printf( "Person 2 firstname : %s\n", Person2.firstname);
   printf( "Person 2 surname : %s\n", Person2.surname);
   printf( "Person 2 age : %s\n", Person2.age);
   printf( "Person 2 shoe size : %d\n", Person2.shoesize);

   return 0;
}
