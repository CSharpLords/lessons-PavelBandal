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
            Console.WriteLine("У тебя есть комп?");
            string answer1 = Console.ReadLine();
            if (answer1 == "нет")
            {
                Console.WriteLine("Ну, тогда твой IQ = 0, и нам неочем с тобой говорить.");
                Console.ReadKey();
            }
            else if (answer1 == "да")
            {
                Console.WriteLine("Сколько часов в неделю ты сидишь в компе?");
                int answer2 = int.Parse(Console.ReadLine());
                Console.WriteLine("А ты большую часть времени работаешь или отдыхаешь?");
                string answer3 = Console.ReadLine();
                if (answer2 < 14)
                {
                    if (answer3 == "работаю")
                    {
                        Console.WriteLine("Ты и отдохнуть не забывай");
                        Console.ReadKey();
                    }
                    else if (answer3 == "отдыхаю")
                    {
                        Console.WriteLine("Хорошо, что ты знаешь меру");
                        Console.ReadKey();
                    }
                }
                else if (answer2 > 13)
                {
                    if (answer3 == "работаю")
                    {
                        Console.WriteLine("Пожалей себя!!");
                        Console.ReadKey();
                    }
                    else if (answer3 == "отдыхаю")
                    {
                        Console.WriteLine("Не расстраивай свою маму и здоровье таким поведением!");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}




