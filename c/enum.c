#include <stdio.h>
enum day {sunday = 1, myday, tuesday = 5,
          mindag, wednesday, thursday = 6, friday, saturday};
 
int main()
{
    printf("%d %d %d %d %d %d %d", mindag, myday, tuesday,
            wednesday, thursday, friday, saturday);
    return 0;
}
