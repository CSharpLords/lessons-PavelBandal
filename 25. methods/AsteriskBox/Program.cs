﻿using System;

namespace PashaAsteriskLine
{

    class Program
    {

        static void Main(string[] args)
        {

            PrintAsteriskBox(4, 5);

            Console.ReadLine(); 

        }

        static void PrintAsterisks(int a)
        {
            string star = "";
            for (int n = 0; n < a; n++)
            {
                star = star + "*";
            }
            Console.WriteLine(star);

         }
        static void PrintAsteriskBox(int shirina, int visota)
        {
            for(int i = 0;i < visota; i++)
            {
                PrintAsterisks(shirina);
            }
        }
    }
}