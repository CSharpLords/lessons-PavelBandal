using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Person
    {
        public string name;
        public string age;
        public string uvazhuha;
        public string skill;
   
        public void GetInfo()
        {
            Console.WriteLine("Имя: " + name + "  Возраст: " + age + " Уважуха : " + uvazhuha+" Особый скилл : "+skill);
        }

        public Person(string name)
        {
            this.name = name;
            age = "Ваще старый как Ленин";
            uvazhuha = "Параша";
            skill = "Абстрактный клич & тп продуктов жизнедеятельности в падик";
        }


    }
}


