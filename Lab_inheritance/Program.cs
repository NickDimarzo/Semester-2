using lab2_inheritance.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInheritance 
{

    class MainProgram 
    {

        static void Main(string[] args) 
        {
            // Testing to make sure objects are being build correctly
            var testOne = new Employee("634567","Fred Flintstone", "34 Flintrock Way, Bedrock, BC", "(345) 295 - 9076", "678453234", "June 15, 2000 BC", "Pediatrics");
            Console.WriteLine(testOne.ToString());

            var testTwo = new Salarized("217546", "Samuel Ludlow III", "2345 The Rich Man Way, RichVille, RC","(567) 324 - 9812","768956453", "February 29, 1942","Collections Section", 20500);
            Console.WriteLine(testTwo.ToString());

            var testThree = new PartTime("86595", "Bill Partley", "11 Partway Road, Almost, NW", "(111) 232 - 9876", "876345987", "July 10, 1966", "Parts Stuff", 20.55, 18);
            Console.WriteLine(testThree.ToString());

            var testFour = new Wages("54153", "BobBob Never", "22 NeverReally Lane, Neverland", "(234) 674 - 7865", "98765678", "September 3, 1988", "Never Media", 30.60, 48);
            Console.WriteLine(testFour.ToString());

            // Testing to make sure the weekly wages are working correctly
            Console.WriteLine($"\nEmployee {testTwo.Name} will be payed ${testTwo.WeeklyPay()} this week");
            Console.WriteLine($"\nEmployee {testThree.Name} will be payed ${testThree.WeeklyPay()} this week");
            Console.WriteLine($"\nEmployee {testFour.Name} will be payed ${testFour.WeeklyPay()} this week");

            // MainProgram To do:
            // - figure out how to read the text file and create objects from each line of the text file
            // - need to sort the lines using the first digit of the employee number in order to create the proper Employee Objects
            // - Calculate and return the average weekly pay for all employees
            // - Calculate and return the highest weekly pay for the wage employees, including the name of the employee
            // - Calculate and return the lowest salary for the salaried employees, including the name of the employee
            // - What percentage of the company’s employees fall into each employee category? 


        }

    }

}

