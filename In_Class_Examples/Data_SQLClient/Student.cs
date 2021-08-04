using System;
using System.Collections.Generic;
using System.Text;

namespace Data_SQLClient
{
    public class Student
    {

        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColor { get; set; }

        public Student()
        {
            StudentID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            FavoriteColor = string.Empty;
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName} ({StudentID}) likes {FavoriteColor}";
        }
    }
}
