// CPRG 211D
// Lab: Interfaces and Abstract Classes
// Nick Dimarzo
// Revision June 11, 2023

using System;
using System.Collections.Generic;

namespace lab3_interfaces_and_abstract_classes 
{

    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program begins");

            // Testing the abstract Dog class
            AbstractDog abstractDog = new AbstractDog();

            Console.WriteLine("\nPlease enter your Dogs name:");
            abstractDog.name = Console.ReadLine();

            Console.WriteLine("\nPlease enter your Dogs colour:");
            abstractDog.colour = Console.ReadLine();

            Console.WriteLine("\nPlease enter your Dogs age:");
            abstractDog.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nYour Dog's name is {0}, it is {1} years old and its colour is {2}.", abstractDog.name, abstractDog.age, abstractDog.colour);
            abstractDog.Eat();


            // Testing the abstract Cat class
            AbstractCat abstractCat = new AbstractCat();

            Console.WriteLine("\nPlease enter your Cats name:");
            abstractCat.name = Console.ReadLine();

            Console.WriteLine("\nPlease enter your Cats colour:");
            abstractCat.colour = Console.ReadLine();

            Console.WriteLine("\nPlease enter your Cats age:");
            abstractCat.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nYour Cat's name is {0}, it is {1} years old and its colour is {2}.", abstractCat.name, abstractCat.age, abstractCat.colour);
            abstractCat.Eat();


            // Testing the interface Dog class
            InterfaceDog interfaceDog = new InterfaceDog();

            Console.WriteLine("\nPlease enter your Dogs name:");
            interfaceDog.Name = Console.ReadLine();

            Console.WriteLine("\nPlease enter your Dogs colour:");
            interfaceDog.Colour = Console.ReadLine();

            Console.WriteLine("\nPLease enter your Dogs height in cm:");
            interfaceDog.Height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter your Dogs age:");
            interfaceDog.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nYour Dog's name is {0}, it is {1} years old, its colour is {2} and its height is {3}cm.", interfaceDog.Name, interfaceDog.Age, interfaceDog.Colour, interfaceDog.Height);  
            interfaceDog.Eat();
            Console.WriteLine(interfaceDog.Cry());


            // Testing the interface Cat class
            InterfaceCat interfaceCat = new InterfaceCat();

            Console.WriteLine("\nPlease enter your Cats name:");
            interfaceCat.Name = Console.ReadLine();

            Console.WriteLine("\nPlease enter your Cats colour:");
            interfaceCat.Colour = Console.ReadLine();

            Console.WriteLine("\nPLease enter your Cats height in cm:");
            interfaceCat.Height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPlease enter your Cats age:");
            interfaceCat.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nYour Cat's name is {0}, it is {1} years old, its colour is {2} and its height is {3}cm.", interfaceCat.Name, interfaceCat.Age, interfaceCat.Colour, interfaceCat.Height);
            interfaceCat.Eat();
            Console.WriteLine(interfaceCat.Cry());

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(interfaceDog);
            animals.Add(interfaceCat);

            Console.WriteLine("\nList of animals:");
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine("{0}", animal.Name);
            }

            Console.ReadKey();
        }
    }   
}
