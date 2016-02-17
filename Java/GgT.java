/**-------------------------------
GgT.java
@author Jannis Guhl
@version 1.0
Reading 2 different Integers and determine the greatest common divisor
----------------------------------*/
import java.util.Scanner; //Needed for user input

public class GgT 
{
	public static void main (String [] args) 
	{
	  //Decleration of variables
		int zahl1, zahl2, dummy;
		Scanner scanner = new Scanner(System.in);
		
		//Exception handling to catch exceptions
		try
		{
		  //Ask the user for 2 integers
      System.out.println("Bitte geben Sie die erste natuerliche Zahl ein:");
      zahl1 = scanner.nextInt();
      System.out.println();
      System.out.println("Vielen Dank, nun bitte die zweite Zahl:");
      zahl2 = scanner.nextInt();
      System.out.println();
      
      System.out.println("Der groesste gemeinsame Teiler der beiden Zahlen ist:");
      System.out.println();
      
      //Determine the GgT
      while(zahl2 != 0)
      {
        if(zahl1>zahl2)
        {
          zahl1 = zahl1 - zahl2;
        }
        else
        {
          zahl2 = zahl2 - zahl1;
        }
      }
      
      //Print the GgT on StdOut
      System.out.println(zahl1);
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
