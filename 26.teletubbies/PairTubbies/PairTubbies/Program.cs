
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PairSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckPairs("namespace ConsoleApplication1 {class Program {static void Main(string[] args) {}", "{", "}");
            CheckPairs("graphics = e.Graphics;graphics.SmoothingMode = SmoothingMode.AntiAlias;graphics.Clear(Color.FromArgb(0x44444400));DrawCar(carX, 200);", "(", ")");
            Console.ReadLine();
        }
        static void CheckPairs(string text, string symbolsOpen, string symbolsClose)
        {
            int SO = 0;
            int SC = 0;
            for (int i = 0; i < text.Length; i++)
            {

                if (text[i].ToString() == symbolsOpen)
                {
                    SO = SO + 1;
                }
                else if (text[i].ToString() == symbolsClose)
                {
                    SC = SC + 1;
                }
            }
            if (SO == SC)
            {
                Console.WriteLine("ЭЬТА Щ4ИдеВирЬЬ");
            }
            else
            {
                Console.WriteLine("Сори, но ты фекалиекодер");
            }
        }
    }
}

               

