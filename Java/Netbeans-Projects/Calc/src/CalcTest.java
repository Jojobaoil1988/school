/**
 * CalcTest.java
 *
 * @author Jannis Guhl
 * @version 1.0 
 * Unit-testing of Calc.java
 */
import java.util.Scanner;

public class CalcTest
{
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        String infix, postfix;
        Notation aNotation = new Notation();
        Calc aCalc = new Calc();
        
        System.out.println("Bitte geben Sie die zu berechnende Formel ein:");
        infix = scanner.next();
        
        postfix = aNotation.getPostfix(infix);
        try
        {
            System.out.println("Ergebnis: " + aCalc.computePostfix(postfix));
        }
        catch (Exception e)
        {
            System.out.println("Dies ist keine " + 
                          "gueltige Rechenoperation!");
        }   
    }
}
