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
            Console.WriteLine("введите в сантиметрах");
            int a = int.Parse (Console.ReadLine());
            double b = (double)a / 100.0;
            Console.WriteLine("в метрах это "+b);
            Console.ReadLine();

        }   
    }
}
