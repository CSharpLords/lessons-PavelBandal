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
            int[] a = { 334, 254654, 5546, 5675,-1, 5, 34535, 78978979, 56757, 567, };
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 5)
                {

                    Console.WriteLine(i);
                    Console.Read();
                    break;
                }
            }
        }
    }
}
