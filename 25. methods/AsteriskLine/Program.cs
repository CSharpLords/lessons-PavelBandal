using System;

namespace PashaAsteriskLine
{

    class Program
    {

        static void Main(string[] args)
        {

            PrintAsterisks(5);

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

    }

}