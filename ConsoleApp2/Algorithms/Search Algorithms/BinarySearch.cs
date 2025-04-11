using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Algorithms.Search_Algorithms
{
    internal class BinarySearch
    {
        public static int BinarySearchIterative(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                // Compute the mid index.
                int mid = left + (right - left) / 2;

                // Check if we have found the target.
                if (arr[mid] == target)
                {
                    return mid;
                }
                // If target is greater than mid element, ignore left half.
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                // If target is less than mid element, ignore right half.
                else
                {
                    right = mid - 1;
                }
            }

            // Target was not found.
            return -1;
        }

    }
}
