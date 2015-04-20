using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sln = new Solution();
            bool result = sln.IsPalindrome("A man, a plan, a canal -- Panama");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            string text = s.Trim();
            if (string.IsNullOrEmpty(text)) return true;

            string clearString = GetClearString(text.ToLower());

            int end = clearString.Length - 1;
            for (int i = 0; i < clearString.Length / 2; i++, end--)
            {
                if (clearString[i] != clearString[end])
                {
                    return false;
                }
            }

            return true;
        }

        public string GetClearString(string text)
        {
            string result = string.Empty;
            System.Text.RegularExpressions.Regex rgx = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]");
            result = rgx.Replace(text, "");
            return result;
        }
    }
}
