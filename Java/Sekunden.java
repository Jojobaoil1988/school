/**-------------------------------
Sekunden.java
@author Jannis Guhl
@version 1.0
Calculates the years, days, hours, minutes and seconds out of given seconds
----------------------------------*/
import java.util.Scanner; //Needed for user input

public class Sekunden 
{
	public static void main (String [] args) 
	{
	  //Decleration of variables
		int sek, min, hours, days, years;
		Scanner scanner = new Scanner(System.in);
		
		//Exception handling to catch exceptions
		try
		{
		  //Ask the user for 2 integers
      System.out.println("Bitte geben Sie die Anzahl der Sekunden ein:");
      sek = scanner.nextInt();
      System.out.println();
      
      System.out.println(sek + " Sekunden entsprechen:");
      System.out.println();
      
      //Calculating years, days, hours, minutes and seconds
      years = sek / 31556952;
      System.out.println(years + " Jahren,");
      sek = sek % 31556952;
      days = sek / 86400;
      System.out.println(days + " Tagen,");
      sek = sek % 86400;
      hours = sek / 3600;
      System.out.println(hours + " Stunden,");
      sek = sek % 3600;
      min = sek / 60;
      System.out.println(min + " Minuten und");
      sek = sek % 60;
      System.out.println(sek + " Sekunden.");
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
