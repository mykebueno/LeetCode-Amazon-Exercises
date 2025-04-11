﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Arrays_ans_Strings
{
    internal class TrapWaterProblem
    {
        public int trap(int[] height)
        {
            // Case of empty height array
            if (height.Length == 0) return 0;
            int ans = 0;
            int size = height.Length;
            // Create left and right max arrays
            int[] left_max = new int[size];
            int[] right_max = new int[size];
            // Initialize first height into left max
            left_max[0] = height[0];
            for (int i = 1; i < size; i++)
            {
                // update left max with current max
                left_max[i] = Math.Max(height[i], left_max[i - 1]);
            }
            // Initialize last height into right max
            right_max[size - 1] = height[size - 1];
            for (int i = size - 2; i >= 0; i--)
            {
                // update right max with current max
                right_max[i] = Math.Max(height[i], right_max[i + 1]);
            }
            // Calculate the trapped water
            for (int i = 1; i < size - 1; i++)
            {
                ans += Math.Min(left_max[i], right_max[i]) - height[i];
            }
            // Return amount of trapped water
            return ans;
        }
    }
}
