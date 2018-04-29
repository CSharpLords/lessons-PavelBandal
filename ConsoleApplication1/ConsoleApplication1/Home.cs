using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Home
    {
        public int qwerty = 1;
        public int ducks = 89;
        public Floor[] floor = new Floor[4];
        public Home()
        {
            for (int i = 0; i < floor.Length; i++)
            {
                floor[i] = new Floor();
            }
        }

        public void Boom()
        {
            Console.WriteLine("!!!KABOOM!!!");
        }
        public void Walk()
        {
            for (int i = 0; i < floor.Length; i++)
            {
                floor[i].Move();
            }
            Console.WriteLine("Я хожу!");
        }

        public void CRACRA()
        {
            for (int CRACRA = 0; ducks > 0; CRACRA++)
            {
                Console.WriteLine("КРЯКРЯКРЯКРЯКРЯКРЯКРЯКРЯКРЯКРЯКРЯКРЯКРЯКРЯКРЯКРЯКРЯКРЯКРЯКРЯКРЯ");
                Hunt();
            }
            Console.Read();
        }

        public void Hunt()
        {
            ducks = ducks - 1;
        }
    }
}
    

