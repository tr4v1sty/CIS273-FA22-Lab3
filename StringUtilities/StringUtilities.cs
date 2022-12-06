using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace StringUtilities
{
    public static class StringUtilities
    {
        public static bool IsUniqueCharacterSet(this string s)
        {
            
            var cleanString = Regex.Replace(s, @"\s+", string.Empty).ToLower();
            HashSet<char> hashset = new HashSet<char>();

            foreach (var letter in cleanString)
            {
                if (hashset.Contains(letter))
                {
                    return false;
                }
                hashset.Add(letter);
            }
            return true;
           
        }
        
    }
}
