using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Algorithms.Sort_Algorithms
{
    internal class Heap
    {
        // biggest value more deep level of tree
        // this is good to find the largest number, you use min heap
        public int FindKthLargests(int[] nums, int k)
        {
            PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

            foreach (int num in nums)
            {
                minHeap.Enqueue(num, num);

                // if we want to keep the stack with the k elemnts bigger of the nums
                if (minHeap.Count > k)
                {
                    minHeap.Dequeue();
                }
            }

            // gives the smalleste number in the heap
            return minHeap.Peek();
        }

        // biggest value more on on the surface level of tree
        // this is good to find the smallest number, 
        public int FindKthLargests2(int[] nums, int k)
        {
            PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();

            foreach (int num in nums)
            {
                maxHeap.Enqueue(num, -num);

                // if we want to keep the stack with the k elemnts smaller of the nums
                if (maxHeap.Count > k)
                {
                    maxHeap.Dequeue();
                }
            }

            // gives the greater number int the heap
            return maxHeap.Peek();
        }
    }
}
