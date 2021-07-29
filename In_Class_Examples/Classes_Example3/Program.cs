using System;
using System.Collections.Generic;

namespace Classes_Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie();
            movie1.Title = "Jungle Cruise";
            movie1.ReleaseYear = 2021;
            movie1.Genres.Add("Action");
            movie1.Genres.Add("Adventure");
            movie1.Genres.Add("Comedy");

            Movie movie2 = new Movie("Free Guy", 2021);
            movie2.Genres.Add("Comedy");
            movie2.Genres.Add("Action");
            movie2.Genres.Add("Sci-Fi");

            string[] genres = { "Action", "Drama", "Adventure" };

            Movie movie3 = new Movie("Avengers: End Game", 2019, genres);

            Console.WriteLine(movie1.ToString()); //better to get used to not adding the .ToString()
            Console.WriteLine(movie2);
            Console.WriteLine(movie3);

            int age = Age(movie1); // different way to solve the problem, but is not the 'correct' way
        }

        static int Age(Movie m)
        {
            DateTime today = DateTime.Now;

            int age = today.Year - m.ReleaseYear;

            return age;
        }
    }
}
