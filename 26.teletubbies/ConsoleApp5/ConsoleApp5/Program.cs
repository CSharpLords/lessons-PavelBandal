using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pocik = new Person("Петрович");
            pocik.age = "Не важен";
            pocik.uvazhuha = "over9000";
            pocik.skill = "Братва";
            pocik.GetInfo();

            Person lenin = new Person("ЛЕНИН!");
            lenin.age = "Не важен";
            lenin.uvazhuha = "overdohrena";
            lenin.skill = "СССР";
            lenin.GetInfo();

            Person mysteryslender = new Person("???");
            mysteryslender.age = "-__-";
            mysteryslender.uvazhuha = "0_0";
            mysteryslender.skill = "IA PPridu c tabe nochiUU";
            mysteryslender.GetInfo();
            Console.Read();
        }
    }
}
