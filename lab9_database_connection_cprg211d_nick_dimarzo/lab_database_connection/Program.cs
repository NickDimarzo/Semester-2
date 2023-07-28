using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace lab_database_connection
{
    class Program
    {
        static void Main(string[] args)
        {
            DBManager dbManager = new DBManager();

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the number of the operation you want to perform:");
                    Console.WriteLine("1. Display all students");
                    Console.WriteLine("2. Add new student");
                    Console.WriteLine("3. Delete student");
                    Console.WriteLine("4. Exit");

                    int operation = Convert.ToInt32(Console.ReadLine());

                    if (operation == 1)
                    {
                        dbManager.DisplayAllStudents();
                    }
                    else if (operation == 2)
                    {
                        dbManager.AddNewStudent();
                    }
                    else if (operation == 3)
                    {
                        dbManager.DeleteStudent();
                    }
                    else if (operation == 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation");
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }



        }
    }
}
