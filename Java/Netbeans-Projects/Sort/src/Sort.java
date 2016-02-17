
/**
 * Sort.java
 *
 * @author Jannis Guhl
 * @version 1.0 implements ISorter interface
 */
public class Sort implements ISorter
{

    /**
     * Method to sort an array of integers with bubble sort
     *
     * @param a array of elements to be sorted
     * @param sortNormal true, if sorting has to be state in ascending order
     * false, if sorting has to be state in descending order
     */
    @Override
    public void bubbleSort(int[] a, boolean sortNormal)
    {
        int dump, n, i;
        boolean state;

        if (sortNormal)
        {
            for (n = a.length - 1; n > 0; n--)
            {
                state = false;
                for (i = 0; i < n; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        dump = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = dump;
                        state = true;
                    }
                }
                if (!state)
                {
                    break;
                }
            }
        }
        else
        {
            for (n = a.length - 1; n > 0; n--)
            {
                state = false;
                for (i = 0; i < n; i++)
                {
                    if (a[i] < a[i + 1])
                    {
                        dump = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = dump;
                        state = true;
                    }
                }
                if (!state)
                {
                    break;
                }
            }
        }

    }

    /**
     * Method to sort an array of integers with insertion sort
     *
     * @param a array of elements to be sorted
     * @param sortNormal true, if sorting has to be state in ascending order
     * false, if sorting has to be state in descending order
     */
    @Override
    public void insertionSort(int[] a, boolean sortNormal)
    {
        int dump, n, i;

        if (sortNormal)
        {
            for (n = 2; n < a.length; n++)
            {
                dump = a[n];
                i = n;
                while (i > 1 && a[i - 1] > dump)
                {
                    a[i] = a[i - 1];
                    i = i - 1;
                }
                a[i] = dump;
            }
        }
        else
        {
            for (n = 2; n < a.length; n++)
            {
                dump = a[n];
                i = n;
                while (i > 1 && a[i - 1] < dump)
                {
                    a[i] = a[i - 1];
                    i = i - 1;
                }
                a[i] = dump;
            }
        }
    }

    /**
     * Method to sort an array of integers with selection sort
     *
     * @param a array of elements to be sorted
     * @param sortNormal true, if sorting has to be state in ascending order
     * false, if sorting has to be state in descending order
     */
    @Override
    public void selectionSort(int[] a, boolean sortNormal)
    {
        int dump, n, i, z;

        if (sortNormal)
        {
            for (n = 0; n < a.length - 1; n++)
            {
                z = n;
                for (i = n + 1; i < a.length; i++)
                {
                    if (a[i] < a[z])
                    {
                        z = i;
                    }
                }
                if (z != n)
                {
                    dump = a[n];
                    a[n] = a[z];
                    a[z] = dump;
                }
            }
        }
        else
        {
            for (n = 0; n < a.length - 1; n++)
            {
                z = n;
                for (i = n + 1; i < a.length; i++)
                {
                    if (a[i] > a[z])
                    {
                        z = i;
                    }
                }
                if (z != n)
                {
                    dump = a[n];
                    a[n] = a[z];
                    a[z] = dump;
                }
            }
        }
    }

    /**
     * Method to sort an array of integers with quick sort
     *
     * @param a array which contains the sub array of elements to be sorted
     * @param l left boarder index of the sub array of a to be sorted
     * @param r right boarder index of the sub array of a to be sorted
     * @param sortNormal true, if sorting has to be state in ascending order
     * false, if sorting has to be state in descending order
     */
    @Override
    public void quickSort(int[] a, int l, int r, boolean sortNormal)
    {
        int pivot, n, i, dump;

        pivot = a[l + (r - l) / 2];

        n = l;
        i = r;
        if (sortNormal)
        {
            while (n <= i)
            {
                while (a[n] < pivot)
                {
                    n++;
                }

                while (a[i] > pivot)
                {
                    i--;
                }

                if (n <= i)
                {
                    dump = a[n];
                    a[n] = a[i];
                    a[i] = dump;
                    n++;
                    i--;
                }
            }

            if (l < i)
            {
                quickSort(a, l, i, true);
            }

            if (r > n)
            {
                quickSort(a, n, r, true);
            }
        }
        else
        {
            while (n <= i)
            {
                while (a[n] > pivot)
                {
                    n++;
                }

                while (a[i] < pivot)
                {
                    i--;
                }

                if (n <= i)
                {
                    dump = a[n];
                    a[n] = a[i];
                    a[i] = dump;
                    n++;
                    i--;
                }
            }

            if (l < i)
            {
                quickSort(a, l, i, false);
            }

            if (r > n)
            {
                quickSort(a, n, r, false);
            }
        }
    }

    /**
     * Method to sort an array of integers with heap sort
     *
     * @param a array of elements to be sorted
     * @param sortNormal true, if sorting has to be state in ascending order
     * false, if sorting has to be state in descending order
     */
    @Override
    public void heapSort(int[] a, boolean sortNormal)
    {
        throw new UnsupportedOperationException("Diese Methode wurde nicht implementiert");
    }

    /**
     * Method to sort an array of integers with merge sort
     *
     * @param a array which contains the sub array of elements to be sorted
     * @param l left boarder index of the sub array of a to be sorted
     * @param r right boarder index of the sub array of a to be sorted
     * @param sortNormal true, if sorting has to be state in ascending order
     * false, if sorting has to be state in descending order
     */
    @Override
    public void mergeSort(int[] a, int l, int r, boolean sortNormal)
    {
        int n, i, z;
        int[] originalArray = a;
        int[] sortedArray = new int[a.length];

        if (sortNormal)
        {
            if (l < r)
            {
                int middle = (l + r) / 2;
                mergeSort(a, l, middle, true);
                mergeSort(a, middle + 1, r, true);
                for (n = l; n <= r; n++)
                {
                    sortedArray[n] = originalArray[n];
                }
                n = l;
                i = middle + 1;
                z = l;
                while (n <= middle && i <= r)
                {
                    if (sortedArray[n] <= sortedArray[i])
                    {
                        originalArray[z] = sortedArray[n];
                        n++;
                    }
                    else
                    {
                        originalArray[z] = sortedArray[i];
                        i++;
                    }
                    z++;
                }
                while (n <= middle)
                {
                    originalArray[z] = sortedArray[n];
                    z++;
                    n++;
                }
            }
        }
        else
        {
            if (l < r)
            {
                int middle = (l + r) / 2;
                mergeSort(a, l, middle, false);
                mergeSort(a, middle + 1, r, false);
                for (n = l; n <= r; n++)
                {
                    sortedArray[n] = originalArray[n];
                }
                n = l;
                i = middle + 1;
                z = l;
                while (n <= middle && i <= r)
                {
                    if (sortedArray[n] >= sortedArray[i])
                    {
                        originalArray[z] = sortedArray[n];
                        n++;
                    }
                    else
                    {
                        originalArray[z] = sortedArray[i];
                        i++;
                    }
                    z++;
                }
                while (n <= middle)
                {
                    originalArray[z] = sortedArray[n];
                    z++;
                    n++;
                }
            }
        }
    }
}
