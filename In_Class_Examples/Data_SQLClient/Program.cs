using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Data_SQLClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=tcp:s13.winhost.com;Initial Catalog=DB_128040_practice;User ID=student;Password=AdamTheGreat2020;Integrated Security=False;";
            List<Student> students = new List<Student>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT StudentID, FirstName, LastName, FavoriteColor " +
                               "FROM Student";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id;
                        string first, last, favColor;

                        //id = (int)reader["StudentID"];
                        id = Convert.ToInt32(reader["StudentID"]);
                        first = Convert.ToString(reader[1]);
                        last = reader[2].ToString();
                        favColor = reader[3].ToString();

                        Student s = new Student();
                        s.StudentID = id;
                        s.FirstName = first;
                        s.LastName = last;
                        s.FavoriteColor = favColor;
                        students.Add(s);
                    }

                }

            }

            foreach (Student student in students)
            {
                if (!student.FavoriteColor.ToLower().Contains("blue"))
                {
                    Console.WriteLine(student);
                }
            }

        }
    }
}
