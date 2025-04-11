using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2;

public class Something
{
    //Input: s = "abcabcbb"
    //Output: 3
    //Explanation: The answer is "abc", with the length of 3
    public static int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            int left = 0, right = 0, maxLen = 0;
            HashSet<char> uniqueChars = new HashSet<char>();

            while (right < s.Length)
            {
                char leftchar = s[left];
                char rightChar = s[right];
                // If the character at the right pointer is not in the set, add it and update maxLen.
                if (!uniqueChars.Contains(s[right]))
                {
                    uniqueChars.Add(s[right]);
                    right++;
                    maxLen = Math.Max(maxLen, uniqueChars.Count);
                }
                else
                {
                    // If it is a duplicate, remove the character at the left pointer and slide the window.
                    uniqueChars.Remove(s[left]);
                    left++;
                }
            }

            return maxLen;
        }

};

