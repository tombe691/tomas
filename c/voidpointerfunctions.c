#include <stdio.h>

void func1(const char *str)
{
    puts(str);
}

void func1b(const char *str)
{
  printf("####printed by func 1b ####\n%s\n", str);
}

void func2(void (*fp)(const char *), const char *str)
{
    fp(str);
}

int main(void)
{
    const char *str = "Hello world.";
    const char *str2 = "Goodbye world.";

    func2(func1, str);
    func2(func1b, str2);

    return 0;
}
