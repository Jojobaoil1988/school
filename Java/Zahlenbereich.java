/**-------------------------------
Zahlenbereich.java
@author Jannis Guhl
@version 1.0
Printing the maximum and minimum values of integer and long
----------------------------------*/

public class Zahlenbereich 
{
	public static void main (String [] args) 
	{
		//Decleration of the variables with max and min values
		int maximum_int = Integer.MAX_VALUE;
		int minimum_int = Integer.MIN_VALUE;
		long maximum_long = Long.MAX_VALUE;
		long minimum_long = Long.MIN_VALUE;
		int maximum_int1 = Integer.MAX_VALUE + 1;
		//Printing the following lines on StdOut
		System.out.println("Der maximale Wert fuer Integer ist: " + maximum_int);
		System.out.println("Der minimale Wert fuer Integer ist: " + minimum_int);
		System.out.println("Der maximale Wert fuer Long ist: " + maximum_long);
		System.out.println("Der minimale Wert fuer Long ist: " + minimum_long);
		System.out.println("Wenn der maximale Integer-Wert ueberschritten wird, sieht das so aus: " + maximum_int1);		
	}

}
