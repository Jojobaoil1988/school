//Jannis Guhl
//Matr. Nr.: 10021411
//06.04.2011
//Praktische Aufgabe 1: Primfaktorzerlegung von Zahlen
//primData2: 0,359 Sekunden
//primData3: 15,922Sekunden
//8734567890987654327LL : 4,406 Sekunden
#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <string.h>
#define Datei "primData3.txt" //Hier das Inputfile ändern!

void leseLongLong();
long long kTeiler(long long);
void prim(long long);

int main()
{
    leseLongLong();

    printf("--------Ende--------");
    return 0;
}

//Einlesen aus einer Quelldatei:
void leseLongLong()
{
    FILE *Data;
    unsigned long long zahl;
    char zeile[80];

    Data = fopen(Datei,"r");

    if(Data == NULL)
    {
        printf("Datei kann nicht gefunden werden!");
    }
    else
    {
        while(feof(Data) == 0)
        {
            fgets(zeile, 80, Data);
            zahl = atoll(zeile);
            prim(zahl);
        }
    }
    fclose(Data);
}

//Teilerberechnung:
long long kTeiler(long long n)
{
    unsigned long long teiler = 5;//Primzahlen 2 und 3 werden extra überprüft
    unsigned long long wurzel;

    wurzel = sqrt(n);//Zum Nachweis, dass n prim ist, genügt es, alle Zahlen von 2 bis sqrt(n)zu untersuchen.

    if(n%2 == 0)
    {
        return(2);
    }
	if(n%3 == 0)
	{
	    return(3);
    }
    while(n%teiler != 0)
    {
        if(teiler>=wurzel) //wenn die Wurzel von n kleiner ist als der aktuelle Teiler
        {
            teiler = n; //dann ist die n der nächste Teiler
        }
        else
        {
                teiler+=2;
        }
    }
    return teiler;
}

void prim(long long n)
{
    unsigned long long kleinster;

    if(n != 0)
    {
        printf("%I64d = ", n);
        if(n == 1)
        {
            printf("1");
        }

        while(n > 1)
        {
            kleinster = kTeiler(n);
            printf(" %I64d ", kleinster);
            n /= kleinster;
            if(n!=1) //solange n nicht 1 ist, soll ein * angehangen werden
            {
                printf("*");
            }
        }
        printf("\n\n");
    }
}


