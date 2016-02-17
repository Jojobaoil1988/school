//Jannis Guhl
//Matr. Nr.: 10021411
//17.05.2011
//Praktische Aufgabe 2: Der kleinste Energiewert einer binären Folge der Länge n mit den Elementen{+1;-1} soll berechnet werden
#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <limits.h>

// Prototypen
void folge_erstellen(int);
int berechnen(int, int[], int);

int main()
{
    int i;

    for(i=4;i<29;i++)
    {
        folge_erstellen(i);//
    }
    return(0);
}

//Energiewert einer übergebenen Folge berechnen:
int berechnen(int laenge, int folge[], int e_max)
{
    int j,k;
    int ck, e = 0;

    for(k=1; k<laenge-1; k++)
    {
        ck = 0;
        for(j=0; j<laenge-k; j++)
        {
            ck += folge[j]*folge[j+k];//berechnen von ck (siehe 1. Formel)
        }
        e += ck*ck; //Aufsummieren der cks² in E (siehe 2. Formel)

        if(e_max<=e)
        {
            return e_max;
        }
    }
    return e;
}

void folge_erstellen(int n)
{
    int a, b, c, e_alt;//Hilfs-, Zählvariablen
    int i = (1 << n)/4; //pow(2,n-2) //Es reicht 1/4 der Folgen zu erstellen, da die "Spiegelbilder" und "Orthogonalen" weggelassen werden können.
    int folge[n];
    int ergebnis = INT_MAX;//großer Anfangswert um vergleichen zu können

    for(a=0;a<i;a++)
    {
        c = a;//a muss durch c ersetzt werden, da sonst die Schleife nicht funktioniert
        for(b=0;b<n;b++)
        {
            //z binär betrachten
            if( (c & 1) == 0)
            {
                folge[b] = 1;
            }
            else
            {
                folge[b] = -1;
            }
            c = c >> 1;//Bitshifting um ein Bit nach rechts
        }
        e_alt = ergebnis;
        ergebnis = berechnen(n, folge, e_alt);//tmp wird zum Ergebnis von berechnen
    }
    printf("Der kleinstmoegliche Energiewert fuer %3d betraegt:\t %4d \n", n, ergebnis+1);
}
