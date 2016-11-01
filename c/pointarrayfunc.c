#include<stdio.h>
#include<string.h>
#include<stdbool.h>
#include<stdlib.h>
int pbool(bool test) {
  return 1;
}

char* pbool2(bool test) {
    char char1= 't';
    char char2= 'r';
    char char3= 'u';
    char char4= 'e';
    char char5= 'f';
    char char6= 'a';
    char char7= 'l';
    char char8= 's';
    char char9= 'e';

    char *str = malloc(6 * sizeof(char));
    if(str == NULL) return NULL;
    if (test) {
      str[0] = char1;
      str[1] = char2;
      str[2] = char3;
      str[3] = char4;
      str[4] = '\0';
    }
    else {
      str[0] = char5;
      str[1] = char6;
      str[2] = char7;
      str[3] = char8;
      str[4] = char9;
      str[5] = '\0';
    }
    return str;
}


void skriv(const char *pp[], int i) {
  printf("%s", pp[i]);
}

void print(float a[], bool test) {
  printf("a = %f %d\n", a[2], pbool(test));
}

void print2(float *a, bool test) {
  printf("a2 = %f %s\n", a[2], pbool2(test));
}


void skriv2(int i) {
  printf("%d ", i);
}


void kvad(int i) {
  printf("%d ", i*i);
}


/*void test(void (*f)(int)) {
  const int *p = 5;
  f(*p);
}
*/

int main()
{
  float f[4];
  float *pd;
  _Bool even = 0;
  bool odd = false;
  char txt[50];
  char namn[] = "Sara";
  char *p = namn;
  const char *medd[4] = {"sträng 1", "sträng 2", "sträng 3", "sträng 4"};
  double *p2 = malloc(5 * sizeof (double));
  f[0] = 0;
  f[1] = 1;
  f[2] = 2;
  f[3] = 3;
  pd = &f[0]; //pd = f
  print(f, odd);
  print2(f, odd);
  printf("%f", *pd);
  printf("%f", *pd+2);
  pd++;
  printf("%f", *pd);
  printf("%s\n", medd[2]);
  //skriv2(medd, 2);
  // test(skriv);
  //test(kvad);
  return 0;
}
