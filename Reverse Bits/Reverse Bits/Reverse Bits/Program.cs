using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sln = new Solution();
            uint result = sln.reverseBits(2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    public class Solution
    {
        public uint reverseBits(uint n)
        {
            uint result = 0;
            string binary = convertToBinary(n);
            result = convertToDecimal(binary);    
            return result;
        }

        public string convertToBinary(uint n)
        {
            string binary = string.Empty;
            int i = 0;
            while (n > 0 || i < 32)
            {
                uint bin = n % 2;
                binary = bin.ToString() + binary;
                n = n / 2;
                i++;
            }
            return binary;
        }

        public uint convertToDecimal(string binary)
        {
            uint result = 0;
            for (int iteration = 0; iteration < binary.Length; iteration++)
            {
                uint bin = 0;
                
                if (binary[iteration] == Convert.ToChar("1"))
                    bin = 1;

                result += bin * Convert.ToUInt32(Math.Pow(2, Convert.ToDouble(iteration)));
            }
            return result;
        }

    }
}
