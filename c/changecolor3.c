#include <windows.h>
#include <stdio.h>
void SetColorAndBackground(int ForgC, int BackC);
int main()
{
    SetColorAndBackground(10,1);   //color value range 0 up-to 256
    printf("what is text background color \n");
    SetColorAndBackground(11,1);
    printf("how about this?");
    getch();
    return 0;
}
void SetColorAndBackground(int ForgC, int BackC)
{
     WORD wColor = ((BackC & 0x0F) << 8) + (ForgC & 0x0F);
     SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), wColor);
     return;
}
