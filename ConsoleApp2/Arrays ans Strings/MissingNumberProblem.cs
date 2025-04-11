using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Arrays_ans_Strings
{
    internal class MissingNumberProblem
    {
        public static int MissingNumber(int[] nums)
        {
            int n = nums.Length;
            int totalSum = n * (n + 1) / 2;

            foreach (int i in nums)
            {
                totalSum -= i;
            }

            return totalSum;
        }
    }
}
