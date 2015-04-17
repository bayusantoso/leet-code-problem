using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length_of_Last_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sln = new Solution();
            Console.WriteLine(sln.LengthOfLastWord("H "));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            if (String.IsNullOrEmpty(s)) return 0;
            s = s.Trim();
            string[] text = s.Split();
            return text[text.Length - 1].Length;
        }
    }
}
