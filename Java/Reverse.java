/**
 * Reverse.java
 *
 * @author Jannis Guhl
 * @version 1.0 reads a given sentence and prints it reversed
 */
import java.util.Scanner;
import java.util.StringTokenizer;

public class Reverse
{
    /**
     * Inverts given sentence
     * @param bTokenizer sentence to be inverted
     */
    public static void invert(StringTokenizer bTokenizer)
    {
        if(bTokenizer.hasMoreElements())
        {
            String nextToken;
            
            nextToken = bTokenizer.nextToken();
            invert(bTokenizer);
            System.out.print(nextToken + " ");
        }
    }
    
    
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        //scanner.useDelimiter();
        StringTokenizer aTokenizer;
        String sentence;
        
        System.out.println("Geben Sie einen Satz ein:");
        sentence = scanner.nextLine();
        aTokenizer = new StringTokenizer(sentence);

        invert(aTokenizer);
    }
    
}
