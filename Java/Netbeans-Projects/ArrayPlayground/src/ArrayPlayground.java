/**
 * ArrayPlayground.java
 * @author Jannis Guhl
 * @version 1.1
 * Class with methods to be tested in TestPlayground-Class
 */

public class ArrayPlayground 
{
    /**Generating an array and returning it.*/      
    static int[] generateArray()
    {
        int[] array = {1,2,3,4,5};
        return array;
    }
    
    /**Generating an array and returning it.*/
    static int[] generateArray2()
    {
        int[] array;
        array = new int[5];
        array[0] = 6;
        array[1] = 7;
        array[2] = 8;
        array[3] = 9;
        array[4] = 10;
        return array;
    }
        
    /**Inverting a given array.*/
    static void invertArray(int[] array)
    {
        int dump1, dump2 = 0;
        int i, length;
        
        length = array.length;
        
        for(i=0;i<(length/2);i++)
        {
            dump1 = array[i];
            dump2 = array[(length-1)-i];
            array[(length-1)-i] = dump1;
            array[i] = dump2;
        }
    }
    
    /**Multiplying two matrices and return the result matrix*/
    static float[][] matrixMult(float[][] a, float[][] b)
    {
        int i, j ,k;
        float[][] matrix = new float[a.length][b[0].length];
        
        for(i=0;i<a.length;i++)
        {
            for(j=0;j<b[0].length;j++)
            {
                for(k=0;k<a[0].length;k++)
                {
                    matrix[i][j] += a[i][k] * b[k][j];
                }
            }
        }
        return matrix;
    }
}