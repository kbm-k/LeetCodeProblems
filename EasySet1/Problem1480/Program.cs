using System;
using System.Linq;
using System.Text;

namespace Problem1480
{
    class Program
    {
        // The same code to test
        static void Main(string[] args)
        {
            Console.Write("nums = ");
            var stringNums = Console.ReadLine();
            stringNums = stringNums.Substring(1, stringNums.Length - 2);
            var nums = stringNums.Split(",").Select(x => Convert.ToInt32(x)).ToArray();
            var result = new long[nums.Length];
            result[0] = nums[0];

            var stringResult = new StringBuilder(result[0].ToString());
            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = result[i - 1] + nums[i];
                stringResult.Append("," + result[i].ToString());
            }

            Console.WriteLine("[" + stringResult + "]");
        }

        // The code to submit to LeetCode
        public int[] RunningSum(int[] nums)
        {
            var result = new int[nums.Length];
            result[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = result[i - 1] + nums[i];
            }

            return result;
        }
    }
}
