using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_inheritance.Classes
{
    //Class for PartTime Employee Object
    internal class PartTime : Employee
    {
        //Unique attributes for PartTime Employee Object
        public double HourlyRate { get; set; }
        public double WorkHours { get; set;}

        //PartTime Employee Constructor
        public PartTime(string id, string name, string address, string phone, string SIN, string startdate, string department, double hourlyrate, double workhours )
            : base(id, name, address, phone, SIN, startdate, department)
        {
            this.HourlyRate = hourlyrate;
            this.WorkHours = workhours;
        }

        // Method used to calculate the weekly pay for a PartTime Employee
        internal double WeeklyPay()
        {
            double payForThisWeek = HourlyRate * WorkHours; 
            return payForThisWeek;
        }

        // PartTime ToString
        public override string ToString()
        {
            return ($" {base.ToString()} \nHourlyRate: {HourlyRate}\nWorkHours: {WorkHours}");
        }
    }
}
