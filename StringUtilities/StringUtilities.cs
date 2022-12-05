using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace StringUtilities
{
    public static class StringUtilities
    {
        public static bool IsUniqueCharacterSet(this string s)
        {
            // same as we did last time
            // check if string is empty
            // does not check spaces and letters
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                        return false;
                }
            }
            return true;
                
            // need to check for duplicate letters and remove spaces

          
        }
        
    }
}
