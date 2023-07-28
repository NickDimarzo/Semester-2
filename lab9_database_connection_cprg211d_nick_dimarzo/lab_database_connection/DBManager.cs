using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_database_connection
{
    public class DBManager
    {
        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            UserID = "root",
            Password = "password",
            Database = "demo211"
        };

        public void DisplayAllStudents() 
        {
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();

            string sqlSelectAllStudents = "SELECT * FROM students";

            MySqlCommand command = new MySqlCommand(sqlSelectAllStudents, connection);

            MySqlDataReader reader = command.ExecuteReader();

            List<Student> students = new List<Student>();
            while (reader.Read()) 
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                double gpa = reader.GetDouble(2);

                Student newStudent = new Student(id, name, gpa);
                students.Add(newStudent);
            }

            foreach (Student student in students) 
            {
                Console.WriteLine(student);
            }

            connection.Close();
        }

        public void AddNewStudent() 
        {
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();

            try
            {
                Console.WriteLine("Please enter the ID of the new student:");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the name of the new student:");
                string name = Console.ReadLine();

                Console.WriteLine("Please enter the gpa of the new student:");
                double gpa = Convert.ToDouble(Console.ReadLine());

                string sqlAddNewStudent = $"INSERT INTO `students` VALUES ({id}, '{name}', {gpa})";

                MySqlCommand command = new MySqlCommand( sqlAddNewStudent, connection);
                command.ExecuteNonQuery();

                Console.WriteLine("Student added successfully");    

            } 
            catch (Exception ex) 
            {
                
                Console.WriteLine("An exeption has occured:" + ex.Message);
            }

            connection.Close();
                   
        }

        public void DeleteStudent() 
        {
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();

            try 
            {
                Console.WriteLine("PLease enter the ID of the student you wish to delete:");
                int id = Convert.ToInt32(Console.ReadLine());

                string sqlDeleteStudent = $"DELETE FROM `students` WHERE `id` = {id}";

                MySqlCommand command = new MySqlCommand(sqlDeleteStudent, connection);
                command.ExecuteNonQuery();

                Console.WriteLine("Student deleted successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception has occured:" + ex.Message);
            }

            connection.Close();
        }
    }
}
