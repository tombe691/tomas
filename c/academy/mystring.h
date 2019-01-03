#include <stdio.h>

void fskip_line(FILE *f);
void skip_line(void);
_Bool remove_nl(char *a);
_Bool fread_line(char *a, int n, FILE *f);
_Bool read_line(char *a, int n); 
int index_of(const char *s, char c);
int last_index_of(const char *s, char c);
int index_of_str(const char *s, const char *part);
void substr(char *to, const char *from, int start, int n);
void trim(char *to, const char *from);
void remove_white(char *to, const char *from); 
void tolower_str(char *to, const char *from); 
void toupper_str(char *to, const char *from);
void replace(char *to, const char *from, char old, char new);
FILE *open_file(const char *text, const char *mode);
