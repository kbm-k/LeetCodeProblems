using System;

namespace Problem1470
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[4] { 1, 1, 2, 2 };
            var result = Shuffle(nums, 2);
            Console.WriteLine(string.Join(",", result));
        }

        public static int[] Shuffle(int[] nums, int n)
        {
            var result = new int[n * 2];

            for (int i = 0, j = 0; j < n; i+=2, j++)
            {
                result[i] = nums[j];
                result[i + 1] = nums[n + j];
            }

            return result;
        }
    }
}
