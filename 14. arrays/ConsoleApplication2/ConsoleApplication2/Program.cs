using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 123, 2346, 123, 7, 23, 7, 1, 56, 234, 67, 235, 58, 12, 6 };
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] - 5;
                Console.Write(nums[i]);

            }
            Console.Read();
        }
    }
}
