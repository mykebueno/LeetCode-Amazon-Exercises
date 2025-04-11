using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Sorting_and_Searching
{
    internal class TopKFrequentElemetns
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            if (nums.Length == k)
            {
                return nums;
            }

            Dictionary<int, int> map = new();

            foreach (int num in nums)
            {
                if (!map.TryGetValue(num, out _))
                {
                    map[num] = 1;
                    continue;
                }

                map[num]++;
            }

            PriorityQueue<int, int> heap = new PriorityQueue<int, int>();

            foreach (var keyValuePair in map)
            {
                heap.Enqueue(keyValuePair.Key, keyValuePair.Value);

                if (heap.Count > k)
                {
                    heap.Dequeue();
                }
            }

            List<int> list = new List<int>();

            while (heap.Count > 0)
            {
                list.Add(heap.Dequeue());
            }

            return list.ToArray();
        }
    }
}
