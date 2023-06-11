using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_interfaces_and_abstract_classes
{
    interface IAnimal 
    {
        string Name { get; set; }
        string Colour { get; set; }
        int Height { get; set; }
        int Age { get; set; }
        abstract void Eat();
        string Cry();
    }

    class InterfaceDog : IAnimal 
    {
        
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }

        public string Cry()
        {
            return "Woof!";
        }
    }

    class InterfaceCat : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }

        public string Cry()
        {
            return "Meow!";
        }
    }
}
