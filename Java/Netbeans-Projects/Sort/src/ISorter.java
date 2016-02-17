
/**
 * ADS  -  An interface with different sorting algorithms 
 * @author Janett Mohnke
 */
public interface ISorter {

    /**
     * Method to sort an array of integers with bubble sort
     *
     * @param a array of elements to be sorted
     * @param sortNormal true, if sorting has to be done in ascending order
     * false, if sorting has to be done in descending order
     */
    public void bubbleSort(int[] a, boolean sortNormal);

    /**
     * Method to sort an array of integers with insertion sort
     *
     * @param a array of elements to be sorted
     * @param sortNormal true, if sorting has to be done in ascending order
     * false, if sorting has to be done in descending order
     */
    public void insertionSort(int[] a, boolean sortNormal);

    /**
     * Method to sort an array of integers with selection sort
     *
     * @param a array of elements to be sorted
     * @param sortNormal true, if sorting has to be done in ascending order
     * false, if sorting has to be done in descending order
     */
    public void selectionSort(int[] a, boolean sortNormal);

    /**
     * Method to sort an array of integers with quick sort
     *
     * @param a array which contains the sub array of elements to be sorted
     * @param l left boarder index of the sub array of a to be sorted
     * @param r right boarder index of the sub array of a to be sorted
     * @param sortNormal true, if sorting has to be done in ascending order
     * false, if sorting has to be done in descending order
     */
    public void quickSort(int[] a, int l, int r, boolean sortNormal);

    /**
     * Method to sort an array of integers with heap sort
     *
     * @param a array of elements to be sorted
     * @param sortNormal true, if sorting has to be done in ascending order
     * false, if sorting has to be done in descending order
     */
    public void heapSort(int[] a, boolean sortNormal);
    
      /**
     * Method to sort an array of integers with merge sort
     *
     * @param a array which contains the sub array of elements to be sorted
     * @param l left boarder index of the sub array of a to be sorted
     * @param r right boarder index of the sub array of a to be sorted
     * @param sortNormal true, if sorting has to be done in ascending order
     * false, if sorting has to be done in descending order
     */
    public void mergeSort(int[] a, int l, int r, boolean sortNormal);
    
}
