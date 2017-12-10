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
            Console.WriteLine("Вася, вводи число не больше 999");
            int number = int.Parse(Console.ReadLine());
            Console.Clear();
            if (number > 999)
            {
                Console.WriteLine("Не больше 999, или закроюсь");
                Vopros();
            }
            else
            {
                Console.WriteLine("Валера,отгадывай.");
                for (int attempts = 1; ; attempts++)
                {
                    
                    int answer = int.Parse(Console.ReadLine());
                    if (answer > number)
                    {

                        Console.WriteLine("Неверно, ищи меньшие числа. Сдаёшься или нет?");
                        string giveup = Console.ReadLine();
                        if (giveup == "сдаюсь")
                        {
                            Console.WriteLine("Вася победил!");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Ок, отгадывай дальше");
                            
                        }
                    }
                    else if (answer < number)
                    {
                        Console.WriteLine("Неверно, ищи большие числа. Сдаёшься или нет?");
                        string giveup = Console.ReadLine();
                        if (giveup == "сдаюсь")
                        {
                            Console.WriteLine("Вася победил!");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ок, отгадывай дальше");
                            
                        }
                    }
                    else
                    {
                        Console.WriteLine("Победа, Валера! Кол-во попыток: " + attempts);
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }
        static void Vopros()
        {
            Console.WriteLine("Вася, вводи число не больше 999");
            int number = int.Parse(Console.ReadLine());
        }
    }
}
