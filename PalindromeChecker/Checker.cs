using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeChecker
{
    public class Checker
    {
        public string CheckPalindrome(string stringToCheck)
        {
            var str = stringToCheck.Replace(" ", String.Empty);
            var sb = new StringBuilder();
            foreach (char c in str)
            {
                if (!char.IsPunctuation(c))
                    sb.Append(c);
            }
            var compressedString = sb.ToString().ToLower();
            var reversed = new string(compressedString.Reverse().ToArray());
            return reversed;
        }
    }
}
