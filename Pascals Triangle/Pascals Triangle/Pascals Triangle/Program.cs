using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascals_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sln = new Solution();

            sln.Generate(15);

        }
    }

    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            
            IList<IList<int>> result = new List<IList<int>>();
            
            if (numRows == 1) {
                IList<int> elem = new List<int>();
                elem.Add(1);
                result.Add(elem);
                return result;
            }


            for (int i = 0; i < numRows; i++)
            {
                IList<int> elem = new List<int>();
                for (int j = i; j >= 0; j--)
                {
                    elem.Add(GetNumber(i,j));
                }
                result.Add(elem);
            }

            return result;
        }

        public int GetNumber(int n, int r)
        {
            int result = 0;
            double nFact = GetFactorial(n);
            double rFact = GetFactorial(r);
            double rnFact = GetFactorial(n - r);

            result = Convert.ToInt32(nFact / (rFact * rnFact));

            return result;
        }

        public double GetFactorial(int n)
        {
            double result = 1;
            for (int i = n; i > 1; i--)
            {
                result *= i;
            }

            return result;
        }

    }
}
