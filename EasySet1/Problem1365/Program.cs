using System;

namespace Problem1365
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 8, 1, 2, 2, 3 };

            var result = SmallerNumbersThanCurrent(nums);

            Console.WriteLine(string.Join(",", result));
        }

        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var length = nums.Length;
            var result = new int[length];

            var arrayItems = new int[101];

            for (int i = 0; i < nums.Length; i++)
            {
                arrayItems[nums[i]] += 1;
            }

            for (int i = 1; i < 101; i++)
            {
                arrayItems[i] += arrayItems[i - 1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    result[i] = 0;
                else
                    result[i] = arrayItems[nums[i] - 1];
            }

            return result;
        }
    }
}
