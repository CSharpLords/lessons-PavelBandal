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
            Console.WriteLine("число");
            int a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("1");
                Console.ReadLine();
            }
            else if (a < 0)
            {
                Console.WriteLine("-1");
                Console.ReadLine();
            }
            else if (a == 0)
            {
                Console.WriteLine("0");
                Console.ReadLine();
            }
        }
    }
}

