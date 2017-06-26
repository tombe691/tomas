#include <stdio.h>


int main()
{
  int i;
  for (i=1;i<6;i+=i) {
    switch (i) {
    case 1: printf("%s", "lite"); break;
    case 2: printf("%s", "battre"); break;
    case 3: printf("%s", "samre"); break;
    case 4: printf("%s", "jobb.se"); break;
    case 5: printf("%s", "chef.com"); break;
    case 6: printf("%s", "mycket"); break;
    }
  }
  return 0;
}
