using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Arrays_ans_Strings
{
    internal class ReorderLogFiles
    {
        public static string[] ReorderLogFiless(string[] logs)
        {
            List<string> letterLogs = new List<string>();
            List<string> digitLogs = new List<string>();

            foreach (string log in logs)
            {
                string[] parts = log.Split(new char[] { ' ' }, 2);

                bool isDigit = char.IsDigit(parts[1][0]);

                if (isDigit)
                    digitLogs.Add(log);
                else
                    letterLogs.Add(log);
            }

            letterLogs.Sort(new LogComparer());

            // Then add digit logs in original order.
            return letterLogs.Concat(digitLogs).ToArray();
        }

        // Custom comparer for comparing logs
        private class LogComparer : IComparer<string>
        {
            public int Compare(string log1, string log2)
            {
                string[] split1 = log1.Split(new char[] { ' ' }, 2);
                string[] split2 = log2.Split(new char[] { ' ' }, 2);

                int cmp = string.Compare(split1[1], split2[1], StringComparison.Ordinal);
                if (cmp != 0)
                    return cmp;

                return string.Compare(split1[0], split2[0], StringComparison.Ordinal);
            }
        }
    }
}
