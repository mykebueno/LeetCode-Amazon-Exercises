namespace ConsoleApp2.Arrays_ans_Strings
{
    internal class FirstUniqueCharacterProblem
    {
        public static int FirstUniqChar(string s)
        {
            Dictionary<char, int> dict = new();

            foreach (char c in s)
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                }
                else dict[c]++;
            }


            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (dict[c] > 1) continue;

                return i;
            }

            return -1;
        }
    }
}
