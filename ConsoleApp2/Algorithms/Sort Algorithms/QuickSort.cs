namespace ConsoleApp2;

public class QuickSorter
{
    private static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            // pi is partitioning index, arr[pi] is now at right place
            int pi = Partition(arr, low, high);

            // Recursively sort elements before partition and after partition
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    // This function takes last element as pivot, places the pivot element at its correct position
    // in sorted array, and places all smaller to left of pivot and all greater to right of pivot
    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];  // pivot
        int i = low - 1;  // index of smaller element

        for (int j = low; j < high; j++)
        {
            Console.WriteLine(arr[j] + " <= " + pivot + '?');
            // If current element is less than or equal to pivot
            if (arr[j] <= pivot)
            {
                i++;
                Swap(arr, i, j);
            }
            PrintArray(arr);
        }
        Swap(arr, i + 1, high);
        PrintArray(arr);
        return i + 1;
    }

    // A utility function to swap two elements in the array
    static void Swap(int[] arr, int a, int b)
    {
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }

    // Utility function to print the array
    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
