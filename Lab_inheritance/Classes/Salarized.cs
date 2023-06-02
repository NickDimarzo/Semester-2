using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_inheritance.Classes
{
    // Class for Salarized Employee Object
    internal class Salarized : Employee
    {
        //Unique attributes for Salarzed Employee Object
        public double Salary { get; set; }

        //Salarized Employee Constructor
        public Salarized(string id, string name, string address, string phone, string SIN, string startdate, string department, double salary)
            : base(id, name, address, phone, SIN, startdate, department)
        {
            this.Salary = salary;
        }

        //Method used to calculate the weekly pay for a Salarized Employee
        //Assumming the total salary is for the year and will be divided by 52 weeks
        public override double WeeklyPay()
        {
            double payForThisWeek = Salary / 52;
            return payForThisWeek;

        }

        //Salarized ToString
        public override string ToString()
        {
            return ($" {base.ToString()}\nSalary: {Salary}");

        }
    }
}

