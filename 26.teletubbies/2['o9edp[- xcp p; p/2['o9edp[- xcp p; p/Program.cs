using System;

namespace CalcPower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите степень: ");
            int e = int.Parse(Console.ReadLine());
            int a = n;
            for (int i = 0 ; i < e; i++)
            {
                a = n * n;
            }
            Console.WriteLine(a);
            Console.Read();
        }
    }
}