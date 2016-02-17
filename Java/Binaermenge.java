/**-------------------------------
Binaermenge.java
@author Jannis Guhl
@version 1.0
Shows entered number as its binary quantity
----------------------------------*/
import java.util.Scanner; //Needed for user input

public class Binaermenge 
{
	public static void main (String [] args) 
	{
		//Decleration of variables
		int zahl = 1;
		int rest;
		Scanner scanner = new Scanner(System.in);

		//Exception handling to catch exceptions
		try
		{
			System.out.println("Bitte geben Sie eine Zahl ein: ");
			zahl = scanner.nextInt();
			
			System.out.print("{");
			
			//Start of for-loop
			for(int i=0; i<=31; i++)
			{
				rest = zahl % 2;
				zahl = zahl / 2;
				
				//When modulo == 1 print value of i
				if(rest == 1)
				{
					System.out.print(i + ",");
				}
			} //End of for-loop
			
			System.out.print("}");
		}
		catch(java.util.InputMismatchException e)
		{
			System.out.println("Bitte geben Sie ausschliesslich Ziffern ein. Buchstaben werden nicht akzeptiert!");
			System.out.println("Sie muessen das Programm nun neu starten. Vielen Dank!");
			System.exit(0); //Quits the program
		}
	}
}
