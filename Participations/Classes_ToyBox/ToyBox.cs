using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_ToyBox
{
    public class ToyBox
    {
        public List<Toy> Toys { get; set; }

        public string Owner { get; set; }
        public string Location { get; set; }

        public ToyBox()
        {
            Toys = new List<Toy>();
            Owner = string.Empty;
            Location = string.Empty;
        }

        public Toy GetRandomToy()
        {
            Random rand = new Random();
            //TOYS[0] = {}
            //TOYS[1] = {}
            // Count = 2
            int randomIndex = rand.Next(0, Toys.Count);

            Toy randomToy = Toys[randomIndex];

            return randomToy;
        }


    }
}
