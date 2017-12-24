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
            int[] nums = { 1, 2, 3, 4, 6, 3, 6, 3, 7, 5, 67, 6, 5, 9, 4, 7, 4, 783, 9, 4 };
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * 2;

                Console.WriteLine(nums[i]);
            }
            Console.Read();
        }
    }
}
  