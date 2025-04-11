using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2;

internal class MostCommonWordProblem
{
    public static string MostCommonWord(string paragraph, string[] banned)
    {
        var bannedWords = banned.ToHashSet();
        var wordCounter = new Dictionary<string, int>();
        (string word, int counter) mostFrequentWord = ("", 0);

        foreach (Match match in Regex.Matches(paragraph, @"\w+"))
        {
            string wordFound = match.Value.ToLower();

            if (bannedWords.TryGetValue(wordFound, out _))
            {
                continue;
            }

            if (wordCounter.TryGetValue(wordFound, out int value))
            {
                int newValue = value + 1;

                if (mostFrequentWord.counter < newValue)
                {
                    mostFrequentWord.counter = newValue;
                    mostFrequentWord.word = wordFound;
                }

                wordCounter[wordFound] = newValue;
                continue;
            }

            if (mostFrequentWord.counter < 1)
            {
                mostFrequentWord.counter = 1;
                mostFrequentWord.word = wordFound;
            }

            wordCounter[wordFound] = 1;
        }

        return mostFrequentWord.word;
    }
}
