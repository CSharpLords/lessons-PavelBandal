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
            Console.WriteLine("Введите первое число");
            string w = Console.ReadLine();
            int a = int.Parse(w);
            Console.WriteLine("Введите второе число");
            string e = Console.ReadLine();
            int b = int.Parse(e);
            Console.WriteLine("Введите третье число");
            string r = Console.ReadLine();
            int c = int.Parse(r);

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(a);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(c);
                    Console.ReadLine();
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine(b);
                    Console.ReadLine();


                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }

}
            
                   