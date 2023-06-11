using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_interfaces_and_abstract_classes
{
    abstract class Animal
    {
        private string Name;
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        private string Colour;       
        public string colour
        {
            get { return Colour; }
            set { Colour = value; }
        }

        private int Age;
        public int age
        {
            get { return Age; }
            set { Age = value; }
        }

        public abstract void Eat();    
    }

    class AbstractDog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
    }

    class AbstractCat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
    }
}
