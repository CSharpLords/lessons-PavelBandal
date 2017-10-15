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
            Console.WriteLine("ХП");
            string hh = Console.ReadLine();
            int HP = int.Parse(hh);
            if (age < 150 || HP < 50)
            {
                Console.WriteLine("Attack!");
                Console.ReadLine();
            }else{
                Console.WriteLine("Run away!");
                Console.ReadLine();
        }
    }
    }
}