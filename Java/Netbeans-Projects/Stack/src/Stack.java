/**
 * Stack.java
 *
 * @author Jannis Guhl
 * @version 1.1 Class to create and handle a stack array with exceptions
 */

public class Stack
{

    static final int stackHeight = 20;
    static Object[] stack = new Object[stackHeight];
    static int pointer = 0;

    /**
     * Adding an object to the stack
     */
    static void push(Object o)
    {
        if (pointer == stackHeight)
        {
            throw new java.lang.ArrayIndexOutOfBoundsException("Der Stack ist voll!");
        }
        stack[pointer] = o;
        pointer++;
    }

    /**
     * Removing an object from the stack
     */
    static Object pop()
    {
        if (pointer == 0)
        {
            throw new java.util.NoSuchElementException("Der Stack ist leer!");
        }
        Object content;
        content = stack[pointer - 1];
        pointer--;
        return content;
    }

    /**
     * Look at the first Object of the stack
     */
    static Object peek()
    {
        if (pointer == 0)
        {
            throw new java.util.NoSuchElementException("Der Stack ist leer!");
        }
        return stack[pointer - 1];
    }

    /**
     * Look how many items are on the stack
     */
    static void isEmpty()
    {
        if (pointer == 0)
        {
            System.out.println("Der Stack ist leer!");
        }
        else
        {
            System.out.println("Es befinden sich " + (pointer) + " Objekte im Stack!");
        }
    }
}
