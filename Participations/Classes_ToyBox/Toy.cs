using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_ToyBox
{
    public class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        private string Notes;

        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Notes = string.Empty;
        }

        public Toy(string note)
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Notes = note;
        }

        public void AddNote(string note)
        {
            Notes += "\n" + note;
        }

        public string GetNotes()
        {
            return Notes;
        }

        public string GetAisle()
        {
            Random rand = new Random();
            int number = rand.Next(1, 25);

            string aisle = Manufacturer.ToUpper().Substring(0, 1) + number;
            aisle = $"{Manufacturer.ToUpper()[0]}{number}";
            aisle = Manufacturer.ToUpper()[0].ToString() + number;
            aisle = "" + Manufacturer.ToUpper()[0] + number;

            return aisle;
        }

        public override string ToString()
        {
            return $"{Name} is made by {Manufacturer} and costs {Price}.  Notes: {Notes}.";
        }
    }
}
