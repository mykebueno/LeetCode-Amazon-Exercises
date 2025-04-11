using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Sorting_and_Searching
{
    internal class KClosestPointsToOrigin
    {
        public static int[][] KClosest(int[][] points, int k)
        {
            PriorityQueue<int[], double> maxHeap = new PriorityQueue<int[], double>();

            foreach (var point in points)
            {
                var distance = Math.Sqrt(Math.Pow(point[0], 2) + Math.Pow(point[1], 2));

                maxHeap.Enqueue(point, -distance);

                if (maxHeap.Count > k)
                {
                    maxHeap.Dequeue();
                }

            }

            List<int[]> pointsAux = new List<int[]>();

            while (maxHeap.Count > 0)
            {
                pointsAux.Add(maxHeap.Dequeue());
            }

            return pointsAux.ToArray();
        }
    }
}
