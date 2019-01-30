/* 
Textäventyrsspel från grupp 1.

Testat och kommenterat av grupp 2:
Daniel, Johan, Tak-Loon, Mazen, Robert

Kommentarer som inleds med stjärna (*) är från grupp 2.
Det är saker vi har reagerat på, ändringar som skulle kunna göras, eller annan feedback 

Vissa av våra kommentarer har vi redigerat i programmet vissa har vi inte redigerat
*/
#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

/* 
	*deras <windows.h> behöver ej inkluderas - 
	används inte i programmet, antagligen hade de tänkt 
	använda biblioteket för någon funktion som inte implementerades 
*/

int main()
{	
	
    setlocale(LC_ALL, "");        //Svenska bokstäver
    int omspel, val, completed=0; 
/* 
	* Variabeln "completed" hade kunnat vara en _Bool, 
	Eventuellt skulle det endast behövas en enda variabel för inmatning av spelarens val, 
	detta sätt med a b c d -variabler kan dock göra koden mer överskådlig 
*/

    while(completed==0)
		
/* 
	*Spelet kör automatiskt om från början tills man "vinner", 
	kanske kunde man ha lagt in en fråga om spelaren vill starta om istället, vid en förlust 
*/
    {
        system("cls");
        printf("\nDu vaknar upp en tisdagsmorgon klockan 08:50 på tågperongen till Linköpings Resecentrum och är hungrig.\n");
        printf("Gårdagen minns du inte mycket av, men Slack påminner dig snabbt om vart du ska, nämligen Länsmuseet.\n\n");
        printf("Tryck 1 för att gå till bussen. \nTryck 2 för att gå till Pressbyrån\n\nSvar: ");
        do //* Snyggt med do-satserna!
        {
            scanf("%d", &val);
        }while(val<0 || val>2 );	

/* 	
	*Inmatningen upprepas vid fel inmatning, dock får spelaren ingen feedback om att denne matat in 
	fel värde, eler att spelet förväntar sig ny inmatning 
*/
		if (val==1)       //Val 1 -- Bussen direkt eller Pressbyrån
        {
			val = 0;
			
            system("cls"); 
            printf("\nDu somnade på bussen och vaknade upp i Motala, GAME OVER!\n\n");    //Fel
            
			printf("Tryck 1 för att spela om och 2 för att avsluta\n");
			
			scanf("%d", &omspel);
			if(omspel == 1){
				system("pause");
			}
			else{
				completed = 1;
			}			
        }
        else if (val==2)
        {
			val = 0;
			
            system("cls");
            printf("\nDu går till pressbyrån och ställer dig vid kassan, varpå en sur gubbe bakom disken frågar dig vad du vill ha. \n");      //Rätt
            printf("Du får följande val: \n\nTryck 1 för kaffe+macka. \nTryck 2 för en Snickers.\n\nSvar:");
            do
            {
                scanf("%d", &val);
            }while(val<0 || val>2 );
        }
        if(val==1)        //Val 2 -- Kaffe+macka eller snickers
        {
			val = 0;
			
            system("cls");
            printf("\nDu känner dig pigg och mätt från din noggrant utvalda frukost, när du går mot bussarna.\n");      //Rätt
            printf("Du tittar på busstabellen som hänger på sniskan.\n\nTryck 1 för att gå på buss nr.12. \nTryck 2 för att gå på buss nr.13. \nTryck 3 för att gå.\n\nSvar: ");
            //* Långa texter i printf-funktionerna emellanåt, skulle gå att korta ned raderna genom att använda två printf
			do
            {
                scanf("%d", &val);
            }while(val<0 || val>3 );        
		}
        else if(val==2)
        {
			val = 0;
			
            system("cls");
            printf("\nDu är nötallergiker, varför valde du en Snickers?! GAME OVER\n\n");     //Fel
            
			
			printf("Tryck 1 för att spela om och 2 för att avsluta\n");
			
			scanf("%d", &omspel);
			if(omspel == 1){
				system("pause");
			}
			else{
				completed = 1;
			}
        }
        if(val==1)        //Val 3 -- Buss 12 eller buss 13
        {
			val = 0;
			
            system("cls");
            printf("\nBuss 12 går rätt väg och du går av vid hållplats Länsmuséet, därifrån är det lätt att hitta.\n\a");     //Rätt

            completed=1;
        }
        else if(val==2)
        {
			val = 0;
			
            system("cls");
            printf("\nBussen svänger tvärt av och fortsätter åt helt fel håll, GAME OVER!\n\n");        //Fel
            
			printf("Tryck 1 för att spela om och 2 för att avsluta\n");
			
			scanf("%d", &omspel);
			if(omspel == 1){
				system("pause");
			}
			else{
				completed = 1;
			}
        }
        else if (val==3)
        {
			val = 0;
			
            system("cls");
            printf("\nDu har valt att gå. Du beger dig av på gångbanan längs Järnvägsavenyn\n");
            printf("Du står nu vid ett rödljus, där Järnvägsavenyn övergår till Vasavägen. \n\nTryck 1 för att vänta en minut och gå mot grönt. \nTryck 2 för att chansa mot rött.\n\nSvar: ");
            do
            {
                scanf("%d", &val);
            }while(val<0 || val>2 );

            if(val==1)
            {
				val = 0;
				
                system("cls");
                system("color 0A "); //*kan lägga in en system(color) för att byta tillbaka till vitt
                printf("\nDu litade blint på det gröna ljuset och blev påkörd av buss nr.12 i korsningen, GAME OVER!\n\n");
				
                system("pause");
				system("color 0F ");
				printf("Tryck 1 för att spela om och 2 för att avsluta\n");
			
				scanf("%d", &omspel);
				if(omspel == 1){
					system("pause");
				}
				else{
					completed = 1;
				}
            }
            else if (val==2)
            {
				val = 0;
				
                system("cls");
                system("color 0C");
                printf("\nDu går lugnt uppför Vasavägen, korsar till andra sidan och är framme om tre minuter. Grattis!\n\a");
				system("pause");
/* 
	*Det skulle kanske vara bra att lägga in en system(color) för att byta 
	tillbaka till vitt innan spelet avslutas helt
*/
				system("color 0F ");
                completed=1;
            }
        }
    }
	return 0;
}
