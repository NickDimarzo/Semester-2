using System;

namespace lab_using_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition:");
            Console.WriteLine("Please enter number n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter number m:");
            int m = int.Parse(Console.ReadLine());

            int recursiceSum = RecursiveSum(n, m);
            Console.WriteLine("Recursive sum: " + recursiceSum);

            Console.WriteLine("Division by 2:");
            Console.WriteLine("Please enter number :");
            int number = int.Parse(Console.ReadLine());

            int recursiveDivision = RecursiveDivision(number);
            Console.WriteLine("Number of Recursive divisions by 2: \n" + recursiveDivision);

            Console.ReadKey();

        }

        // Calculate the sum of numbers between n and m
        static int RecursiveSum(int n, int m)
        {
            int sum = n;
            if (n == m) // Base Case
            {
                return sum;
            }
            else
            {
                return sum + RecursiveSum(n + 1, m); // Recursive Case
            }
        }

        // Calculate the number of divisions by 2
        static int RecursiveDivision(int number)
        {
            if (number % 2 != 0) // Base Case
            {
                return 0;
            }
            else
            {
                return 1 + RecursiveDivision(number / 2); // Recursive Case
            }
        }
    }
}