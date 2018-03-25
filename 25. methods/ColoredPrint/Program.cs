using System;

namespace ColoredPrint {
	class Program {
        static void Main(string[] args)
        {
            while (true)
            {
                PrintColoredText("010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010010101010100101010101", ConsoleColor.Red);
                PrintColoredText("010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010010101010100101010101", ConsoleColor.Yellow);
                PrintColoredText("010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010010101010100101010101", ConsoleColor.Green);
                PrintColoredText("010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010101010010101010100101010101", ConsoleColor.Blue);


            }
        }

		static void PrintColoredText(string text, ConsoleColor color) {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = color;
            Console.WriteLine(text);
        }   
	}
}
