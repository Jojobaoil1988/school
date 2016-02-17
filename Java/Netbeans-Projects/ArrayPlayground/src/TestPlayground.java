/**
 * TestPlayground.java
 * @author Jannis Guhl
 * @version 1.1
 * Class to test methods implemented in TestPlayground-Class
 */

public class TestPlayground 
{
    public static void main (String [] args)
    {
        int[] array1;
        int[] array2;
        int[] array3 = {1,3,5,7,9};
        float[][] matrix1 = {{1,2},{3,4}};
        float[][] matrix2 = {{1,2},{3,4}};
        float[][] matrix3;
        
        array1 = ArrayPlayground.generateArray();
        System.out.println("Folgendes Array wurde mit der ersten Klassenmethode erzeugt:");
        System.out.println(array1[0] + ", " + array1[1] + ", " + array1[2] + ", "
                           + array1[3] + ", " + array1[4]);
        
        array2 = ArrayPlayground.generateArray2();
        System.out.println("Dieses Array wurde mit der zweiten Klassenmethode erzeugt:");
        System.out.println(array2[0] + ", " + array2[1] + ", " + array2[2] + ", "
                           + array2[3] + ", " + array2[4]);
        
        System.out.println("Das dritte Array vor der Invertierung:");
        System.out.println(array3[0] + ", " + array3[1] + ", " + array3[2] + ", "
                           + array3[3] + ", " + array3[4]);
        
        ArrayPlayground.invertArray(array3);
        System.out.println("Und hier nach der Invertierung:");
        System.out.println(array3[0] + ", " + array3[1] + ", " + array3[2] + ", "
                           + array3[3] + ", " + array3[4]);
        
        matrix3 = ArrayPlayground.matrixMult(matrix1, matrix2);
        System.out.println("Die Ergebnismatrix lautet:");
        System.out.println(matrix3[0][0] + "\t" + matrix3[0][1]);
        System.out.println(matrix3[1][0] + "\t" + matrix3[1][1]);
    }
}
