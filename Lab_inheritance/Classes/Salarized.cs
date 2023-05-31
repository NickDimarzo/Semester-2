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

        internal double WeeklyPay(double Salary)
        {
            double payForThisWeek = Salary / 52;
            return payForThisWeek;

        }

        public override string ToString()
        {
            return ($"\nID: {Id}" +
                 $"\nName: {Name}" +
                 $"\nAddress: {Address}" +
                 $"\nPhone: {Phone}" +
                 $"\nSIN: {SIN}" +
                 $"\nStart Date: {StartDate}" +
                 $"\nDepartment: {Department}" +
                 $"\nSalary: {Salary}");
        }
    }
}
