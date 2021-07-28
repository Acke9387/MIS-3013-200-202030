using System;
using System.Collections.Generic;

namespace Classes_Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student();
            stud1.Name = "Talia";
            stud1.ID = 1;
            stud1.ClassesTaken = "MIS-2113, MIS-3013, MIS-3033, MIS-3353";

            Student stud2 = new Student();
            stud2.Name = "Kaylee";
            stud2.ID = 2;
            stud2.ClassesTaken = "MIS-2113, MIS-3013, MIS-3033, MIS-3353, MIS-3383";

            Student stud3 = new Student();
            stud3.Name = "Jenna";
            stud3.ID = 3;
            stud3.ClassesTaken = "MIS-2113, MIS-3013, MIS-3353";


            List<Student> studs = new List<Student>();
            studs.Add(stud1);
            studs.Add(stud2);
            studs.Add(stud3);

            OutputStudentsWhoveTakenAParticularCourse("MIS-3013", studs);
            OutputStudentsWhoveTakenAParticularCourse("MIS-3033", studs);
            Console.WriteLine();
            OutputStudentDetails("Jenna", studs);
        }

        static void OutputStudentsWhoveTakenAParticularCourse(string course, List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.ClassesTaken.Contains(course) == true)
                {
                    Console.WriteLine($"{student.Name} ({student.ID}) has taken {course}");
                }
            }
        }

        static void OutputStudentDetails(string name, List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.Name == name )
                {
                    Console.WriteLine($"{student.Name} ({student.ID}) has taken {student.ClassesTaken}");
                }
            }
        }
    }
}
