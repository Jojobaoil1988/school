/**
 * TestStack.java
 * @author Jannis Guhl
 * @version 1.1
 * Class to test methods implemented in Stack- and Queue-Classes with exceptions
 */
import java.util.Scanner; //Needed for user input

public class TestStack
{
    static Scanner scanner = new Scanner(System.in);
    
    /**Main-Method to choose between testing stack- or queue-class*/
    public static void main (String [] args)
    {
        int i;
        
        System.out.println("Wollen Sie eine Queue oder einen Stack testen?");
        System.out.println("1: Stack");
        System.out.println("2: Queue");
        i = scanner.nextInt();
        if(i==1)
        {
            choseStack();
        }
        else if(i==2)
        {
            choseQueue();
        }
        else
        {
            System.out.println("Sie haben keine gültige Auswahl getroffen. " + 
                               "Das Programm wird daher jetzt beendet!");
        }
    }
    
    /**GUI for testing the stack-class*/
    static void choseStack()
    {
        int call;
        boolean quit = false;
        Object item;
        
        while(quit==false)
        {
            System.out.println("Bitte waehlen Sie einen Punkt aus:");
            System.out.println("1: Einen Wert auf dem Stack ablegen");
            System.out.println("2: Den letzten Wert aus dem Stack schreiben");
            System.out.println("3: Den letzten Wert im Stack anschauen");
            System.out.println("4: Schauen ob der Stack leer ist");
            System.out.println("5: Beende dieses Programm");
            call = scanner.nextInt();
               
            try
            {
                switch(call)
                {
                    case 1:
                        System.out.println("Bitte geben Sie ein, was Sie auf den Stack legen moechten:");
                        item = scanner.next();
                        Stack.push(item);
                        System.out.println();
                        break;
                    case 2:
                        System.out.println("Folgendes Element wurde aus dem Stack entfernt:");
                        System.out.println(Stack.pop());
                        System.out.println();
                        break;
                    case 3:
                        System.out.println("Folgendes Element ist das letzte im Stack:");
                        System.out.println(Stack.peek());
                        System.out.println();
                        break;
                    case 4:
                        Stack.isEmpty();
                        System.out.println();
                        break;
                    case 5:
                        quit = true;
                        System.out.println("Auf Wiedersehen!");
                        break;
                    default:
                        System.out.println("Sie haben keinen gueltigen Wert eingegeben!");
                        System.out.println();
                }
            }
            catch(Exception e)
            {
                System.out.println(e.getMessage());
            }
        }
    }
    
    /**GUI for testing the queue-class*/
    static void choseQueue()
    {
        int call;
        boolean quit = false;
        Object item;
        
        while(quit==false)
        {
            System.out.println("Bitte waehlen Sie einen Punkt aus:");
            System.out.println("1: Einen Wert in die Queue schreiben");
            System.out.println("2: Den ersten Wert aus der Queue schreiben");
            System.out.println("3: Den ersten Wert in der Queue anschauen");
            System.out.println("4: Schauen ob die Queue leer ist");
            System.out.println("5: Beende dieses Programm");
            call = scanner.nextInt();

            try
            {
                switch(call)
                {
                    case 1:
                        System.out.println("Bitte geben Sie ein, was Sie in die Queue schieben moechten:");
                        item = scanner.next();
                        Queue.enqueue(item);
                        System.out.println();
                        break;
                    case 2:
                        System.out.println("Folgendes Element wurde aus der Queue entfernt:");
                        System.out.println(Queue.dequeue());
                        System.out.println();
                        break;
                    case 3:
                        System.out.println("Folgendes Element ist das erste in der Queue:");
                        System.out.println(Queue.peek());
                        System.out.println();
                        break;
                    case 4:
                        Queue.isEmpty();
                        System.out.println();
                        break;
                    case 5:
                        quit = true;
                        System.out.println("Auf Wiedersehen!");
                        break;
                    default:
                        System.out.println("Sie haben keinen gueltigen Wert eingegeben!");
                        System.out.println();
                }
            }
            catch(Exception e)
            {
                System.out.println(e.getMessage());
            }
        }
    }    
}
