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
            Console.WriteLine("Enter the first number please.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number please.");
            int b = int.Parse(Console.ReadLine());
        }
        static void SravniChisla(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                Console.WriteLine("+");
                Console.ReadLine();
            }
            else if (a < 0 && b < 0)
            {
                Console.WriteLine("+");
                Console.ReadLine();
            }
            else if (a > 0 && b > 0)
            {
                Console.WriteLine("+");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("-");
                Console.ReadLine();
            }
        }
    }
}
    
