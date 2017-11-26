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
            int attempt = 0;
            int a = 0;
            while (attempt < 6)
            {
                Console.WriteLine("Введите  число");
                int b = int.Parse(Console.ReadLine());
                a = a + b;
                attempt = attempt + 1;
                Console.WriteLine("Сумма этих чисел равна "+a);
                
            }
            Console.ReadLine();

        }
    }
}
