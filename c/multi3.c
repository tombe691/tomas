#include<stdio.h>
#include<conio.h>
void multi_table(int x,int n)
{
	int i,y=x;
	for(i=1;i<=n;i++)
	{
		printf("\n\t%d * %d = %d\n",x,i,y);
		y+=x;
	}
}
void main()
{
	int num,limit;
	//	clrscr();
	printf("\nEnter number\t: ");
	scanf("%d",&num);
	printf("\nEnter the limit\t: ");
	scanf("%d",&limit);
	printf("\n    Multiplication table\n");
	multi_table(num,limit);
	getch();
}

