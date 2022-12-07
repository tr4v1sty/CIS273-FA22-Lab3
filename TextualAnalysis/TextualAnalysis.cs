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
            // THE SENTENCE THAT WAS HERE WAS MADE A VAR AND WAS KILLING ALL THE TESTS
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
                //check and see if its a stop word and loops till done
                if (ignoreStopWords == true && stop.Contains(word) == true)
                {
                    continue;
                }
                // adds to word count and adds the word as a variable
                else
                {
                    if (wordCounts.ContainsKey(word))
                    {
                     wordCounts[word]++;
                    }
                    else
                    { 
                     wordCounts.Add(word,1);
                    }
                }
                
            }
            return wordCounts;  
        }

        public static Dictionary<string, int> ComputeWordFrequenciesFromFile(string path, bool ignoreStopWords = false)
        {
            string text = System.IO.File.ReadAllText(path);
            
                // boolean value for ignorewords
                if(ignoreStopWords == true)
                {
                     return ComputeWordFrequencies(text,true);
                }
                else
                 {
                return ComputeWordFrequencies(text);
                 }

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
