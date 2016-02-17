/**-------------------------------
Sterne.java
@author Jannis Guhl
@version 1.0
Asks for a number and prints the appropriate amount of lines and stars on StdOut
----------------------------------*/
import java.util.Scanner; //Needed for user input

public class Sterne 
{
	public static void main (String [] args) 
	{
	  //Decleration of variables
		int anzahl, i, n;
		Scanner scanner = new Scanner(System.in);
		
		//Exception handling to catch exceptions
		try
		{
		  //Ask the user for the number of lines
      System.out.println("Bitte geben Sie die Anzahl der Zeilen ein:");
      anzahl = scanner.nextInt();
      System.out.println();
      
      System.out.println("Anzahl der Zeilen: " + anzahl);
      
      //Printing the stars
      for(i=1;i<=anzahl;i++)
      {
        for(n=1;n<=i;n++)
        {
          System.out.print("*");
        }
        System.out.println();
      }
    }
    //Catch the specific exception when a letter is entered
    catch(java.util.InputMismatchException e)
    {
      System.out.println("Bitte geben Sie ausschliesslich ganze Zahlen ein, auch Buchstaben werden nicht akzeptiert!");
      System.out.println("Sie muessen das Programm nun neu starten. Vielen Dank!");
      return;
    }
    
	}
}
