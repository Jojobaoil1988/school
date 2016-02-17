/**-------------------------------
Zahlenraten.java
@author Jannis Guhl
@version 1.0
A game where the user must guess the right number
----------------------------------*/
import java.util.Scanner; //Needed for user input

public class Zahlenraten
{ 
	public static void main(String args[]) 
	{
		int i = 0; //Counter variable
		int meine_zahl = (int) (99 * Math.random() + 1); //The secret number
		int deine_zahl = 0; //Variable for user entered number 
		Scanner scanner = new Scanner(System.in); //Needed to read from StdIn

		System.out.println("Willkommen beim Zahlenraten.");    
		System.out.println("Ich denke mir eine Zahl zwischen 1 und 100. Rate diese Zahl!");
		System.out.println();
		
		//Start of the do-while-loop
		do
		{	
			//Exception handling to catch exceptions
			try
			{
				i++; //Increase the try counter
				System.out.println("Bitte geben Sie eine Zahl zwischen 1 und 100 ein.");
				System.out.print(i + ". Versuch: ");
				deine_zahl = scanner.nextInt(); //Read user input from StdIn
				
				//If my number is not equal to guessed number:
				if(meine_zahl != deine_zahl)
				{
					if(meine_zahl < deine_zahl)
					{
						System.out.println("Die geratene Zahl ist zu gross! Versuch es noch einmal.");
						System.out.println();
					}
					else
					{
						System.out.println("Die geratene Zahl ist zu klein! Versuch es noch einmal.");
						System.out.println();
					}
				}
				else
				{
					System.out.println();
					System.out.println( "Du hast meine Zahl beim " + i + ". Versuch erraten!" );
				}				
			}
			catch(java.util.InputMismatchException e)
			{
				System.out.println("Bitte geben Sie ausschliesslich Ziffern ein. Buchstaben werden nicht akzeptiert!");
				System.out.println("Sie muessen das Programm nun neu starten. Vielen Dank!");
				System.exit(0); //Quits the program
			}
		} while (meine_zahl != deine_zahl);
	}
}
