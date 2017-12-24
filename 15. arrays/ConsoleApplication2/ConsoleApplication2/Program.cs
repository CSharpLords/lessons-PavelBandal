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
            int[] wins = { 20, 453, 678, 57, 546345, 34578, 35478, 2345, 543, 5, 56, 2345, 123456, 1, 2, 1, 2, 3, 4, 78 };
            for (int i = 0; i < wins.Length; i++)
            {
                if (wins[i] < 3)
                {
                    Console.WriteLine("Вот лузеры:"+wins[i]);
                }
                
            }
            Console.Read();
        }
    }
}
