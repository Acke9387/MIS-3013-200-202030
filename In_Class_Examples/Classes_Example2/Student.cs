using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Example2
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ClassesTaken { get; set; }

        /// <summary>
        /// Default/Empty constructor
        /// </summary>
        public Student()
        {
            ID = 0;
            Name = string.Empty;
            ClassesTaken = string.Empty;
        }

    }
}
