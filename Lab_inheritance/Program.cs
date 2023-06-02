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

            // a.	Fill a list with objects based on the supplied data file.
            
            string fileName = "employees.txt";
            string projectDirectory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(projectDirectory, fileName);

            List<Employee> employees = new List<Employee>();
            List<string> lines = new List<string>();
            lines = File.ReadAllLines( filePath ).ToList();

            foreach (string line in lines)
            {
                if (line.StartsWith("0") || line.StartsWith("1") || line.StartsWith("2") || line.StartsWith("3") || line.StartsWith("4"))
                {
                    string[] items = line.Split(':');
                    Salarized p;
                    p = new Salarized(items[0], items[1], items[2], items[3], items[4], items[5], items[6], Convert.ToDouble(items[7]));
                    employees.Add(p);
                }

                else if (line.StartsWith("5") || line.StartsWith("6") || line.StartsWith("7"))
                {
                    string[] items = line.Split(':');
                    PartTime p;
                    p = new PartTime(items[0], items[1], items[2], items[3], items[4], items[5], items[6], Convert.ToDouble(items[7]), Convert.ToDouble(items[8]));
                    employees.Add(p);
                }

                else if (line.StartsWith("8") || line.StartsWith("9"))
                {
                    string[] items = line.Split(':');
                    Wages p;
                    p = new Wages(items[0], items[1], items[2], items[3], items[4], items[5], items[6], Convert.ToDouble(items[7]), Convert.ToDouble(items[8]));
                    employees.Add(p);
                }
            }

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

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

