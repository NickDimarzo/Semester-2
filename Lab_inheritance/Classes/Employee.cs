using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab2_inheritance.Classes
{
    // Parent or Superclass
    public class Employee
    {
        // Employee Object Attributes
        public string Id {  get; set; }
        public string Name { get; set; }
        public string Address {get; set; }
        public string Phone { get; set; }
        public string SIN { get; set; }
        public string StartDate { get; set; }
        public string Department { get; set; }

        // Employee Constructor
        public Employee(string _id, string _name,string _address ,string _phone , string _SIN, string _startdate, string _department ) 
        {
            this.Id = _id;
            this.Name = _name;
            this.Address = _address;
            this.Phone = _phone;
            this.SIN = _SIN;
            this.StartDate = _startdate;
            this.Department = _department;
        }

        // Employee ToString 
        public override string ToString() 
        {
           return ($"\nID: {Id}" +
                $"\nName: {Name}" +
                $"\nAddress: {Address}" +
                $"\nPhone: {Phone}" +
                $"\nSIN: {SIN}" +
                $"\nStart Date: {StartDate}" +
                $"\nDepartment: {Department}");
        }      
    }
}
