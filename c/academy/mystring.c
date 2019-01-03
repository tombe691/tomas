#include "mystring.h"
#include <string.h>
#include <ctype.h>
#include <locale.h>
#include <stdlib.h>

void fskip_line(FILE *f) {
  int c;
  while ( (c = fgetc(f)) != '\n' && c != EOF )
    ;  
}
 
void skip_line(void) {
  fskip_line(stdin); 
}

_Bool remove_nl(char *a) {
  int i = strlen(a)-1;
  if (a[i] == '\n') {
    a[i] = '\0';
	return 1;
  }
  return 0;
}

 _Bool fread_line(char *a, int n, FILE *f) {
  if (fgets(a, n, f) == NULL)
    return 0;
  if (!remove_nl(a)) 
	fskip_line(f);
  return 1;  
}

 _Bool read_line(char *a, int n) {
  return fread_line(a, n, stdin);
}

int index_of(const char *s, char c) { 
  char *p = strchr(s, c);
  if (p == NULL)
    return -1;
  else 
    return p-s;
}

int last_index_of(const char *s, char c) { 
  char *p = strrchr(s, c);
  if (p == NULL)
    return -1;
  else 
    return p-s;
}

int index_of_str(const char *s, const char *part) {
  char *p = strstr(s, part);
  if (p == NULL)
    return -1;
  else 
    return p-s;
}

void substr(char *to, const char *from, int start, int n) {
  strncpy(to, from+start, n);;
  to[n] = '\0';
}

void trim(char *to, const char *from) {
  int i = 0, j = strlen(from)-1;
  while(isspace(from[i]))
      i++;
  while(j >= 0 && isspace(from[j]))
      j--;
  if (j >= i)
    strncpy(to, from+i, j-i+1);
  to[j+1] = '\0';
}

void remove_white(char *to, const char *from) {
  int j = 0;
  for (int i =0; from[i] != '\0'; i++)
    if (!isspace(from[i]))
      to[j++] = from[i];
   to[j] = '\0'; 
}

void tolower_str(char *to, const char *from) {
  setlocale(LC_ALL, "");
  int i = 0;
  for (; from[i] != '\0'; i++)
    to[i] = tolower(from[i]);
  to[i] = '\0';
}

void toupper_str(char *to, const char *from) {
  setlocale(LC_ALL, "");
  int i = 0;
  for (; from[i] != '\0'; i++)
    to[i] = toupper(from[i]);
  to[i] = '\0';
}

void replace(char *to, const char *from, char old, char new) {
  int i = 0;
  for (; from[i] != '\0'; i++)
	if (from[i] == old)
      to[i] = new;
    else
	  to[i] = from[i];
  to[i] = '\0';
}

FILE *open_file(const char *text, const char *mode) {
  char name[100];
  printf("%s ", text);
  read_line(name, 100);
  FILE *f = fopen(name, mode); 
  if (f == NULL) {
    printf("Kan inte öppna filen %s", name);
    exit(1);
  }
  return f;
} 
