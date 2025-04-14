using System;

class QuickSortExample
{
    public static void QuickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(arr, left, right);

            QuickSort(arr, left, pivotIndex - 1);  // Left side
            QuickSort(arr, pivotIndex + 1, right); // Right side
        }
    }

    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right]; // Choose the rightmost as pivot
        int i = left - 1; // Index of smaller element

        for (int j = left; j < right; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }

        Swap(arr, i + 1, right); // Put pivot in correct place
        return i + 1;
    }

    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    static void Main()
    {
        int[] array = { 8, 3, 1, 7, 0, 10, 2 };

        Console.WriteLine("Original: " + string.Join(", ", array));

        QuickSort(array, 0, array.Length - 1);

        Console.WriteLine("Sorted: " + string.Join(", ", array));
    }
}
