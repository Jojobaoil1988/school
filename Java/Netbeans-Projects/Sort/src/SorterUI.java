/*
 * ADS - Thema Sortieralgorithmen und Aufwand
 * Programm zum Testen der Sortieralgorithmen
 *  - BubbleSort
 *  - InsertionSort
 *  - SelectionSort
 *  - QuickSort
 *  - Heapsort
 *  - MergeSort
 */

import java.io.*;

/**
 * Class to compare run times of sorting algorithms
 *
 * @author Janett Mohnke
 * @version 1.0
 */
public class SorterUI
{

    private static final int SIZE = 20480; // array size
    private static int[] input; //the array of elements to sort
    private static int[] hold;  //array to hold unsorted values

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) throws IOException
    {

        int ip; //input value for choosing an algorithm

        BufferedReader din = new BufferedReader(
                new InputStreamReader(System.in));

        ISorter theSorter = new Sort();

        do
        { //main loop
            printMenue();
            ip = Integer.parseInt(din.readLine());
            switch (ip)
            {
                case 1:
                    createUnsortedArray();
                    break;
                case 21:
                    resetUnsortedArray();
                    break;
                case 2:
                    printArray();
                    break;
                case 3:
                    startBubbleSort(theSorter, true);
                    break;
                case 4:
                    startBubbleSort(theSorter, false); //sort array in inverse order
                    break;
                case 5:
                    startInsertionSort(theSorter, true);
                    break;
                case 6:
                    startInsertionSort(theSorter, false); //sort array in inverse order
                    break;
                case 7:
                    startQuickSort(theSorter, true);
                    break;
                case 8:
                    startQuickSort(theSorter, false); //sort array in inverse order
                    break;
                case 9:
                    startHeapSort(theSorter, true);
                    break;
                case 10:
                    startHeapSort(theSorter, false); //sort array in inverse order
                    break;
                case 11:
                    startSelectionSort(theSorter, true);
                    break;
                case 12:
                    startSelectionSort(theSorter, false); //sort array in inverse order
                    break;
                case 13:
                    startMergeSort(theSorter, true);
                    break;
                case 14:
                    startMergeSort(theSorter, false); //sort array in inverse order
                    break;
                default:
            }
        }
        while (ip != 0);
    }

    /**
     * Method to print out menue of choices
     */
    private static void printMenue()
    {
        System.out.println("\nMenue:");
        System.out.println(" 1 Unsortiertes Feld erzeugen   2 Feld ausgeben");
        System.out.println("21 Reset zum unsortierten Feld");
        System.out.println(" 3 BubbleSort normal            4 BubbleSort invers");
        System.out.println(" 5 InsertionSort normal         6 InsertionSort invers");
        System.out.println(" 7 QuickSort normal             8 QuickSort invers");
        System.out.println(" 9 HeapSort normal             10 HeapSort invers");
        System.out.println("11 SelectionSort normal        12 SelectionSort invers");
        System.out.println("13 MergeSort normal            14 MergeSort invers");
        System.out.println(" 0 Exit");
        System.out.println();
    }

    /**
     * Method to create array "input" of size SIZE filled with random numbers
     * This array will be the input of all sorting algorithms
     */
    private static void createUnsortedArray()
    {
        input = new int[SIZE];
        hold = new int[SIZE];
        int randomNum;
        for (int i = 0; i < SIZE; i++)
        {
            randomNum = (int) (Math.random() * SIZE);
            input[i] = randomNum;
            hold[i] = randomNum;
        }
    }

    /**
     * Method to reset array "input" to the initial setting of random numbers
     * This is useful to be able to compare sorting algorithms.
     */
    private static void resetUnsortedArray()
    {
        for (int i = 0; i < SIZE; i++)
        {
            input[i] = hold[i];
        }
    }

    /**
     * Method to print out the array "input"
     */
    private static void printArray()
    {
        if (input == null)
        {
            return;
        }

        for (int i = 0; i < SIZE; i++)
        {
            int value = input[i];
            System.out.print(" " + value + " ");
            if ((i % 16) == 0) //print 16 numbers on each line only
            {
                System.out.println();
            }
        }
        System.out.println();
    }

    /**
     * Method to start bubbleSort on array "input" an to measure and print out
     * time in ms which is needed
     *
     * @param s the sorter object
     * @param sortNormal true: sort in normal order, false: sort in inverse
     * order
     */
    private static void startBubbleSort(ISorter s, boolean sortNormal)
    {
        long time1 = System.currentTimeMillis();
        s.bubbleSort(input, sortNormal);
        long time2 = System.currentTimeMillis();
        System.out.println("Rechenzeit: " + (time2 - time1) + "ms");
    }

    /**
     * Method to start insertionSort on array "input" an to measure and print
     * out time in ms which is needed
     *
     * @param s the sorter object
     * @param sortNormal true: sort in normal order, false: sort in inverse
     * order
     */
    private static void startInsertionSort(ISorter s, boolean sortNormal)
    {
        long time1 = System.currentTimeMillis();
        s.insertionSort(input, sortNormal);
        long time2 = System.currentTimeMillis();
        System.out.println("Rechenzeit: " + (time2 - time1) + "ms");
    }

    /**
     * Method to start selectionSort on array "input" an to measure and print
     * out time in ms which is needed
     *
     * @param s the sorter object
     * @param sortNormal true: sort in normal order, false: sort in inverse
     * order
     */
    private static void startSelectionSort(ISorter s, boolean sortNormal)
    {
        long time1 = System.currentTimeMillis();
        s.selectionSort(input, sortNormal);
        long time2 = System.currentTimeMillis();
        System.out.println("Rechenzeit: " + (time2 - time1) + "ms");
    }

    /**
     * Method to start quickSort on array "input" an to measure and print out
     * time in ms which is needed
     *
     * @param s the sorter object
     * @param sortNormal true: sort in normal order, false: sort in inverse
     * order
     */
    private static void startQuickSort(ISorter s, boolean sortNormal)
    {
        long time1 = System.currentTimeMillis();
        s.quickSort(input, 0, SIZE - 1, sortNormal);
        long time2 = System.currentTimeMillis();
        System.out.println("Rechenzeit: " + (time2 - time1) + "ms");
    }

    /**
     * Method to start heapSort on array "input" an to measure and print out
     * time in ms which is needed
     *
     * @param s the sorter object
     * @param sortNormal true: sort in normal order, false: sort in inverse
     * order
     */
    private static void startHeapSort(ISorter s, boolean sortNormal)
    {
        long time1 = System.currentTimeMillis();
        s.heapSort(input, sortNormal);
        long time2 = System.currentTimeMillis();
        System.out.println("Rechenzeit: " + (time2 - time1) + "ms");
    }

    /**
     * Method to start mergeSort on array "input" an to measure and print out
     * time in ms which is needed
     *
     * @param s the sorter object
     * @param sortNormal true: sort in normal order, false: sort in inverse
     * order
     */
    private static void startMergeSort(ISorter s, boolean sortNormal)
    {
        long time1 = System.currentTimeMillis();
        s.mergeSort(input, 0, SIZE - 1, sortNormal);
        long time2 = System.currentTimeMillis();
        System.out.println("Rechenzeit: " + (time2 - time1) + "ms");
    }
}
