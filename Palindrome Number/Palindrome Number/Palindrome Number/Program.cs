using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int palindrome = 0;
            Solution sln = new Solution();
            bool isPalindrome = sln.IsPalindrome(palindrome);

            if (isPalindrome)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadKey();
        }
    }

    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            
            bool isPalindrome = true;
            string text = x.ToString();

            int end = text.Length - 1;
            for (int iteration = 0; iteration < (text.Length / 2); iteration++, end--)
            {
                if (text[iteration] != text[end])
                {
                    isPalindrome = false;
                    break;
                }
            }

            return isPalindrome;
        }
    }
}
