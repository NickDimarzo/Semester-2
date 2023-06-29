using System;
using System.Runtime.InteropServices;

namespace lab5_creating_exeptions
{
    class Program
    {
        public class Circle
        {
            private double radius;
            
            //Checks whether radius is greater than 0, If radius is greater than 0 the radius is set.
            //If the radius id equal to or less than 0 the method throws the exeption InvalidRadiusExeption 
            public void SetRadius(double value)
            {
                if (value <= 0)
                {
                    throw new InvalidRadiusException(value);
                }
                else
                {
                    radius = value;
                }
            }

            public override string ToString()
            {
                return $"Circle: Radius = {radius}";
            }
        }

        public class InvalidRadiusException : Exception
        {
            public InvalidRadiusException()
            {
                Console.WriteLine("Invalid radius: Radius must be greater than zero.");
            }

            public InvalidRadiusException(double radius)
            {
                Console.WriteLine($"Invalid radius: {radius} is not a valid value.");
            }
        }

        static void Main(string[] args) 
        {
            try
            {
                Circle circle1 = new Circle();
                circle1.SetRadius(2.5);
                Console.WriteLine(circle1.ToString());

                Circle circle2 = new Circle();
                circle2.SetRadius(-1.5);
                Console.WriteLine(circle2.ToString());

                Circle circle3 = new Circle();
                circle3.SetRadius(0);
                Console.WriteLine(circle3.ToString());

            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e) 
            {
                Console.WriteLine("An exeption occured: " + e.Message);
            }
            

        }
    }
}