using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_inheritance.Classes
{
    //Class for PartTime Employee Object
    internal class Wages : Employee
    {
        //Unique attributes for Wages Employee Object
        public double HourlyRate { get; set; }
        public double WorkHours { get; set; }

        //PartTime Employee Constructor
        public Wages(string id, string name, string address, string phone, string SIN, string startdate, string department, double hourlyrate, double workhours)
            : base(id, name, address, phone, SIN, startdate, department)
        {
            this.HourlyRate = hourlyrate;
            this.WorkHours = workhours;
        }

        // Method used to calculate the weekly pay for a Wages Employee. After 40 hours worked Wages Employee will be payed time and a half for the extra hours worked.
        public override double WeeklyPay()
        {
           
            if (WorkHours > 40) 
            {
                double normalRate = (HourlyRate * 40);
                double overTimeHours = (WorkHours - 40);
                double overTimeRate = (overTimeHours * (HourlyRate * 1.5));
                double payForThisweek = (normalRate + overTimeRate);
                return payForThisweek;          
            }
            else
            {
                double payForThisWeek = (HourlyRate * WorkHours);
                return payForThisWeek;
            }
        }

        // Wages ToString
        public override string ToString()
        {
            return ($" {base.ToString()} \nHourlyRate: {HourlyRate}\nWorkHours: {WorkHours}");
        }

    }
}
