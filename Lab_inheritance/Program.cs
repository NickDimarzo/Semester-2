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
            List<Employee> employees = new List<Employee>();
            List<string> lines = new List<string>();

            //a.	Fill a list with objects based on the supplied data file.
            string fileName = "employees.txt";
            string projectDirectory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(projectDirectory, fileName);
            lines = File.ReadAllLines(filePath).ToList();

            //Checks the first character of each line to determine which type of employee to create
            foreach (string line in lines)
            {

                //If the line starts with 0, 1, 2, 3, or 4, create a Salarized employee
                if (line.StartsWith("0") || line.StartsWith("1") || line.StartsWith("2") || line.StartsWith("3") || line.StartsWith("4"))
                {
                    string[] items = line.Split(':');
                    Salarized person;
                    person = new Salarized(items[0], items[1], items[2], items[3], items[4], items[5], items[6], Convert.ToDouble(items[7]));
                    employees.Add(person);
                }

                //If the line starts with 5, 6, or 7, create a PartTime employee
                else if (line.StartsWith("5") || line.StartsWith("6") || line.StartsWith("7"))
                {
                    string[] items = line.Split(':');
                    PartTime person;
                    person = new PartTime(items[0], items[1], items[2], items[3], items[4], items[5], items[6], Convert.ToDouble(items[7]), Convert.ToDouble(items[8]));
                    employees.Add(person);
                }

                //If the line starts with 8 or 9, create a Wages employee
                else if (line.StartsWith("8") || line.StartsWith("9"))
                {
                    string[] items = line.Split(':');
                    Wages person;
                    person = new Wages(items[0], items[1], items[2], items[3], items[4], items[5], items[6], Convert.ToDouble(items[7]), Convert.ToDouble(items[8]));
                    employees.Add(person);
                }
            }

            //Create a new Company object
            Company company = new Company(employees);

            //b.	Calculate and return the average weekly pay for all employees.
            double averageWeeklyPay = company.CalculateAverageWeeklyPay();
            Console.WriteLine($"\nThe average weekly pay for all employees is: {averageWeeklyPay:C}");

            //c.	Calculate and return the highest weekly pay for the wage employees, including the name of the employee.
            string highestWeeklyPay = company.CalculateHighestWeeklyPay();
            Console.WriteLine($"\nThe highest weekly pay for all employees is: {highestWeeklyPay}");

            //d.	Calculate and return the lowest salary for the salaried employees, including the name of the employee
            string lowestSalary = company.CalculateLowestSalary();
            Console.WriteLine($"\nThe lowest salary for all employees is: {lowestSalary}");

            //e.	What percentage of the company’s employees fall into each employee category? 
            string percentageOfEmployees = company.CalculatePercentageOfEmployees();
            Console.WriteLine($"\nThe percentage of employees in each category is: {percentageOfEmployees}");

        }

    }

}
