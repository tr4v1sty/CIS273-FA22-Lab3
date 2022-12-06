using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Net.WebRequestMethods;

namespace TextualAnalysis
{
    public class TextualAnalysis
    {
        public static string stopWordFilePath = "../../../Data/stop-words.txt";

        public TextualAnalysis()
        {
        }


        public static Dictionary<string, int> ComputeWordFrequencies(string s, bool ignoreStopWords = false)
        {
            var wordCounts = new Dictionary<string, int>();
            string[] stop = GetStopWordsFromFile(stopWordFilePath);
            s = "all the faith he had had had had no effect.";
            HashSet<string> wordset = new HashSet<string>();
            foreach (string word in stop)
            {
                wordset.Add(word);
            }
            // remove punctuation
            var cleanset = Regex.Replace(s, @"[^\w\s]", "");
            // split the string into words (filtering out the empty strings)
            var words = cleanset.ToLower().Split().Where(s => s != "");
            foreach (var word in words)
            {
                    if (wordCounts.ContainsKey(word))
                    {
                        wordCounts[word]++;
                    }
                    else
                    {
                        wordCounts.Add(word, 1);
                    }   
            }
            return wordCounts;  
        }

        public static Dictionary<string, int> ComputeWordFrequenciesFromFile(string path, bool ignoreStopWords = false)
        {
            string text = System.IO.File.ReadAllText(path);

            return ComputeWordFrequencies(text, ignoreStopWords);

   
        }

        private static string[] GetStopWordsFromFile(string path)
        {
            var rawLines = System.IO.File.ReadAllLines(path);
            var lines = new List<string>();

            foreach (var line in rawLines)
            {
                // ignore blank lines
                if (line.Trim() != "")
                {
                    lines.Add(line.Trim().ToLower());
                }
            }

            return lines.ToArray();
        }

    }
}
