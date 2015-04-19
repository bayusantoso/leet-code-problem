using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Version_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sln = new Solution();
            Console.WriteLine(sln.CompareVersion("0.0.1", "0.1"));
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int CompareVersion(string version1, string version2)
        {
            int result = 0;
            string[] versi1 = version1.Split(Convert.ToChar("."));
            string[] versi2 = version2.Split(Convert.ToChar("."));
            double ver1 = 0;
            double ver2 = 0;
            
            int iteration = 0;
            foreach (string txt in versi1)
            {
                double digit = Convert.ToDouble(txt);
                if (digit > 0)
                {
                    ver1 += digit * Math.Pow(10, -iteration);
                }

                iteration++;
            }

            iteration = 0;
            foreach (string txt in versi2)
            {
                double digit = Convert.ToDouble(txt);
                if (digit > 0)
                {
                    ver2 += digit * Math.Pow(10, -iteration);
                }
                iteration++;
            }
            
            if (ver1 > ver2) result = 1;
            else if (ver1 < ver2) result = -1;

            return result;
        }
    }
}
