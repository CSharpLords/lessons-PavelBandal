using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPassword {
	class Program {
        static void Main(string[] args)
        {
            while (true)
            {
                string password = "пароль";
                Console.WriteLine("Чтобы пользоваться моей программой, напиши пароль!");
                string answer = Console.ReadLine();

                if (answer == password)
                {
                    Console.WriteLine("Ок, правильно. Жми Enter, чтобы пройти!");
                    Console.ReadLine();
                    Console.Clear();

                    StartProgram();
                }
                else
                {

                    Console.WriteLine("Чтобы пользоваться моей программой, напиши пароль!");
                    string answe = Console.ReadLine();

                }
            }
        }

		static void StartProgram() {
			Quest quest = new Quest();
		}
	}
}

