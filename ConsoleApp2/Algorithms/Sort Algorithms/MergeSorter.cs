using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2;

public class MergeSorter
{
    // Main MergeSort method
    public static void MergeSort(int[] array)
    {
        if (array.Length <= 1)
        {
            return; // An array of zero or one element is already sorted.
        }

        // Find the middle index of the array
        int mid = array.Length / 2;

        // Split the array into two halves
        int[] left = new int[mid];
        int[] right = new int[array.Length - mid];

        Array.Copy(array, 0, left, 0, mid);
        Array.Copy(array, mid, right, 0, array.Length - mid);

        // Recursively sort both halves
        MergeSort(left);
        MergeSort(right);

        // Merge the sorted halves back into the original array
        Merge(array, left, right);
    }

    // Merge two sorted arrays into the original array
    private static void Merge(int[] array, int[] left, int[] right)
    {
        int i = 0; // index for left array
        int j = 0; // index for right array
        int k = 0; // index for merged array

        // Merge elements from left and right arrays in order
        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                array[k++] = left[i++];
            }
            else
            {
                array[k++] = right[j++];
            }
        }

        // If there are any remaining elements in left, add them
        while (i < left.Length)
        {
            array[k++] = left[i++];
        }

        // If there are any remaining elements in right, add them
        while (j < right.Length)
        {
            array[k++] = right[j++];
        }
    }
}
