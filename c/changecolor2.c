#include<graphics.h>
#include<conio.h>
 
main()
{
   int gd = DETECT, gm, drawing_color;
   char a[100];
 
   initgraph(&gd,&gm,''C:\\TC\\BGI'');
 
   drawing_color = getcolor();
 
   sprintf(a,''Current drawing color = %d'', drawing_color);
   outtextxy( 10, 10, a );
 
   getch();
   closegraph();
   return 0;
}
