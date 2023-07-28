using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_database_connection
{
    public class Student
    {
        public Student(int id, string name, double gpa)
        {
            this.id = id;
            this.name = name;
            this.gpa = gpa;
        }

        public int id { get; set; }
        public string name { get; set; }
        public double gpa { get; set; }

        public override string ToString()
        {
            return ($"ID:{id} NAME:{name} GPA: {gpa}");
        }
    }
}
