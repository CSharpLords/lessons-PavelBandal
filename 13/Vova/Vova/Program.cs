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
            Console.WriteLine("Какую вещь ты хочешь найти мой юный падаван?");
            Console.WriteLine("Вот список: портфель, тапочки, XBox, телефон, записка с паролем от Dota2");
            string answer = Console.ReadLine();
            if (answer == "носки")
            {
                Console.WriteLine("Твои носки остались в школе внутри аптечки 5г");
                Console.ReadKey();
            }
            else if (answer == "портфель")
            {
                Console.WriteLine("Он на твоей спине");
                Console.ReadKey();
            }
            else if (answer == "тапочки")
            {
                Console.WriteLine("На ногах");
                Console.ReadKey();
            }
            else if (answer == "XBox")
            {
                Console.WriteLine("Твой Xbox на люстре");
                Console.ReadKey();
            }
            else if (answer == "телефон")
            {
                Console.WriteLine("В ванной");
                Console.ReadKey();
            }
            else if (answer == "записка с паролем от Dota2")
            {
                Console.WriteLine("На моём экране");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Либо ты грамотей, либо я не знаю такой вещи");
                Console.ReadKey();
            }
        }
    }
}

