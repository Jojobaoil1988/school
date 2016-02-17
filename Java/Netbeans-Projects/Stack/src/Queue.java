/**
 * Queue.java
 * @author Jannis Guhl
 * @version 1.1
 * Class to create and handle a queue array with exceptions
 */

public class Queue
{
    static final int queueLength = 20;
    static Object[] queue = new Object[queueLength];
    static int pointerFirst = 0;
    static int pointerLast = 0;
    static boolean helper = false;
    
    /**Adding an object to the queue*/
    static void enqueue(Object o)
    {
            if(pointerLast==queueLength)
            {
                pointerLast = 0;
                helper = true;
            }
            if((pointerLast+1)==pointerFirst || (helper==true && pointerFirst==0))
            {
                if(queue[pointerLast]==null)
                queue[pointerLast] = o;
                throw new java.lang.ArrayIndexOutOfBoundsException("Die Queue ist voll!");
            }
            queue[pointerLast] = o;
            pointerLast++;
            helper = false;
    }
    
    /**Removing an object from the queue*/
    static Object dequeue()
    {
        if(pointerLast==pointerFirst)
        {
            throw new java.util.NoSuchElementException("Die Queue ist leer!");
        }
        Object content;
        if(pointerFirst==queueLength)
        {
            pointerFirst = 0;
        }
        content = queue[pointerFirst];
        queue[pointerFirst] = null;
        pointerFirst++;
        return content;
    }
    
    /**Look at the first Object in the queue*/
    static Object peek()
    {
        if(pointerLast==pointerFirst)
        {
            throw new java.util.NoSuchElementException("Die Queue ist leer!");
        }
        return queue[pointerFirst];
    }
    
    /**Look how many items are in the queue*/
    static void isEmpty()
    {
        int count;
        
        if(pointerFirst==pointerLast)
        {
            System.out.println("Die Queue ist leer!");
        }
        else
        {
            if((pointerLast-pointerFirst)<0)
            {
                count = (pointerLast-pointerFirst)*(-1);
            }
            else
            {
                count = pointerLast-pointerFirst;
            }
            System.out.println("Es befinden sich " + (count) + 
                               " Objekte in der Queue!");
        }
    }
}

