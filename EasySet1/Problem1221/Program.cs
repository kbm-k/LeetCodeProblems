using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Problem1221
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = BalancedStringSplit("RLRRLLRLRL");
            Console.WriteLine(result);
        }

        public static int BalancedStringSplit(string s)
        {
            int result = 0, count = 0;

            for (int i = 0; i < s.Length; ++i)
            {
                count += s[i] == 'L' ? 1 : -1;
                if (count == 0) result++;
            }

            return result;
        }
    }
}
