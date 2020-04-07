using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cat
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            cat1.Name = "sasha"; //setting property
            cat1.Age = 6.9;
            cat1.Color = "fawn";

            Cat cat2 = new Cat();
            cat2.Name = "sunny";
            cat2.Age = 4.20;
            cat2.Color = "ginger";

            Console.WriteLine(cat1.Name + " " + cat1.Age); //getting property
            Console.WriteLine(cat2.Name + " " + cat2.Age);

            cat1.SayMeow();
            Console.ReadKey();
        }
    }
    class Cat
    {
        public string Name { get; set; }
        public double Age { get; set; }
        public string Color { get; set; }
        public Cat()
        {

        }

        public void SayMeow()
        {
            Console.WriteLine("meow");
        }
    }
}
