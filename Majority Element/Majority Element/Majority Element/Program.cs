using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majority_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sln = new Solution();
            int[] nums = {1,2,3,2,2,2,2,2,3,3,3,3,3,3,3,4,4,4,4,4,5,5,5,2,11,1,1,1,1,1,1,1,1,1};
            Console.WriteLine(sln.MajorityElement(nums));
            Console.ReadKey();   
        }
    }

    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            int result = 0;
            
            Dictionary<int, int> element = new Dictionary<int, int>();
            int i = (nums.Length - 1);
            for (; i >= 0; i--)
            {
                if (!element.ContainsKey(nums[i]))
                {
                    element.Add(nums[i], 1);
                }
                else
                {
                    element[nums[i]]++;
                }
            }

            int max = 0;
            int n = 0;
            foreach (KeyValuePair<int, int> el in element)
            {
                if (n == 0)
                {
                    max = el.Value;
                    result = el.Key;
                }
                else
                {
                    if (el.Value > max)
                    {
                        max = el.Value;
                        result = el.Key;
                    }
                }
                n++;
            }
            
            return result;
        }
    }
}
