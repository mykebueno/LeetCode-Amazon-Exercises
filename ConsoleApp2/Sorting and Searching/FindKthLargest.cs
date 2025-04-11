using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Sorting_and_Searching;

internal class FindKthLargest
{
    public int FindKthLargests(int[] nums, int k)
    {
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

        foreach (int num in nums)
        {
            minHeap.Enqueue(num, num);

            if (minHeap.Count > k)
            {
                minHeap.Dequeue();
            }
        }

        return minHeap.Peek();
    }
}
