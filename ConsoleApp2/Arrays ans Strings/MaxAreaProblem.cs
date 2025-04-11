using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MaxAreaProblem
    {
        public static int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxArea = 0;

            while (left < right)
            {
                // Calculate the area formed by the lines at pointers left and right.
                int currentHeight = Math.Min(height[left], height[right]);
                int currentArea = currentHeight * (right - left);
                maxArea = Math.Max(maxArea, currentArea);

                // Move the pointer pointing to the shorter line inward.
                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            return maxArea;
        }
    }
}
