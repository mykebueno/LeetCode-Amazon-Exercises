using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Sorting_and_Searching
{
    internal class FindMedianSortedArrays
    {
        public static double FindMedianSortedArrayss(int[] nums1, int[] nums2)
        {
            var orderedArray = nums1.Concat(nums2).Order();

            var numOfElements = orderedArray.Count();

            if (numOfElements == 1) return orderedArray.ElementAt(0);

            if (int.IsOddInteger(numOfElements))
            {
                return orderedArray.ElementAt(numOfElements / 2);
            }

            var middle = numOfElements / 2;
            var aux1 = orderedArray.ElementAt(middle);
            var aux2 = orderedArray.ElementAt(middle - 1);
            var aux3 = (double)(aux1 + aux2) / 2;

            return aux3;
        }
    }
}
