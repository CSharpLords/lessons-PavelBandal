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
            Console.WriteLine("Возраст");
            string ag = Console.ReadLine();
            int age = int.Parse(ag);
            if (age >= 10 && age <= 20)
            {
                Console.Write("Ты подросток");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ты не подросток");
                Console.ReadLine();
            }
        }
    }
}

