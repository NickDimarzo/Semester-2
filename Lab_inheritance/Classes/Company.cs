using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_inheritance.Classes
{
    //Class Company object is used to work with all employees
    internal class Company
    {
        //Company Attributes
        public List<Employee> Employees;

        //Company Constructor
        public Company(List<Employee> employees)
        {
            this.Employees = employees;
        }

        //Method is used to calculate the average weekly pay for all employees
        public double CalculateAverageWeeklyPay()
        {
            double total = 0;
            foreach (Employee employee in Employees)
            {
                total += employee.WeeklyPay();
            }
            return total / Employees.Count;
        }

        //Method is used to find the highest paid employee out of all employees
        public string CalculateHighestWeeklyPay()
        {
            string highestName = "";
            double highestPay = 0;
            foreach (Employee employee in Employees)
            {
                if (employee.WeeklyPay() > highestPay)
                {
                    highestPay = employee.WeeklyPay();
                    highestName = employee.Name;
                }
            }
            return ($"{highestPay:C} - {highestName}");
        }

        //Method is used to find the lowest paid Salarized employee
        public string CalculateLowestSalary()
        {
            string lowestName = "";
            string compareName = "";
            double compareSalary = 0;
            double lowestSalary = 9999999999999;
            foreach (Employee employee in Employees)
            {
                if (employee is Salarized)
                {
                    compareSalary = ((Salarized)employee).Salary;
                    compareName = employee.Name;

                    if (compareSalary < lowestSalary)
                    {
                        lowestSalary = compareSalary;
                        lowestName = compareName;
                    }
                }

            }
            return ($"{lowestSalary:C} - {lowestName}");
        }

        //Method is used to calculate the percentage of each type of employee
        public string CalculatePercentageOfEmployees()
        {
            double total = Employees.Count;
            double salarized = 0;
            double parttime = 0;
            double wages = 0;
            foreach (Employee employee in Employees)
            {
                if (employee is Salarized)
                {
                    salarized++;
                }
                else if (employee is PartTime)
                {
                    parttime++;
                }
                else if (employee is Wages)
                {
                    wages++;
                }
            }
            return ($"\nSalarized: {salarized / total:P}\nPartTime: {parttime / total:P}\nContract: {wages / total:P}");
        }
    }
}
