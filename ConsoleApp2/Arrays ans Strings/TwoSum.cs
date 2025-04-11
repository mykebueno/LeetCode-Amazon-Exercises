using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2;

public class TwoSum
{
    // Input: nums = [3, 2, 4], target = 6
    // Output: [1, 2]
    public static int[] TwoSums(int[] nums, int target)
    {
        Dictionary<int, int> numCache = new();

        for (int numPos = 0; numPos < nums.Length; numPos++)
        {
            int numberNeeded = target - nums[numPos];

            if (!numCache.TryGetValue(numberNeeded, out int indexOfNumberNeeded))
            {
                numCache.TryAdd(nums[numPos], numPos);
                continue;
            }

            return [indexOfNumberNeeded, numPos];
        }

        return [-1];
    }
}
