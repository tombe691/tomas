#include <stdio.h>
#include <string.h>

/* define simple structure */
struct {
  unsigned int statusPin1;
  unsigned int statusPin2;
  unsigned int statusPin3;
  unsigned int statusPin4;
  unsigned int statusPin5;
  unsigned int statusPin6;
  unsigned int statusPin7;
  unsigned int statusPin8;
} status1;

/* define simple structure */
struct {
  int statusPin1;
  int statusPin2;
  int statusPin3;
  int statusPin4;
  int statusPin5;
  int statusPin6;
  int statusPin7;
  int statusPin8;
} status2;

/* define a structure with bit fields */
struct {
  unsigned int statusPin1 : 1;
  unsigned int statusPin2 : 1;
  unsigned int statusPin3 : 1;
  unsigned int statusPin4 : 1;
  unsigned int statusPin5 : 1;
  unsigned int statusPin6 : 1;
  unsigned int statusPin7 : 1;
  unsigned int statusPin8 : 1;
} status3;
 
int main( ) {
  int a = 1;
  printf( "Memory size occupied by status1 : %d\n", sizeof(status1));
  printf( "Memory size really by status2 : %d\n", sizeof(status2));
  printf( "Memory size really by status3 : %d\n", sizeof(status3));
  printf( "Memory size really by status3 : %d\n", sizeof(a));

  return 0;
}
