using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Example3
{
    public class Movie
    {
        public string Title { get; set; }

        public List<string> Genres { get; set; }

        public int ReleaseYear { get; set; }

        /// <summary>
        /// Default/Empty constructor for a Movie
        /// </summary>
        public Movie()
        {
            Title = string.Empty;// "";
            ReleaseYear = 0;
            Genres = new List<string>();
        }

        /// <summary>
        /// Overloaded constructor that takes the title and year of the movie as arguments
        /// </summary>
        /// <param name="title">Movie Title</param>
        /// <param name="year">Release year of the movie</param>
        public Movie(string title, int year)
        {
            Title = title;
            ReleaseYear = year;
            Genres = new List<string>();
        }

        /// <summary>
        /// Overloaded constructor that takes the title, year and genres of the movie
        /// </summary>
        /// <param name="title"></param>
        /// <param name="year"></param>
        /// <param name="genres"></param>
        public Movie(string title, int year, string[] genres)
        {
            Title = title;
            ReleaseYear = year;
            Genres = new List<string>();

            foreach (string genre in genres)
            {
                Genres.Add(genre);
            }

        }

        /// <summary>
        /// Determines how many years old the movie is.
        /// </summary>
        /// <returns>The number of years since the release of the movie</returns>
        public int Age()
        {
            DateTime today = DateTime.Now;

            int age = today.Year - ReleaseYear;

            return age;
        }


        public override string ToString()
        {
            string output = "";
            int age = Age();

            switch (age)
            {
                case 0:
                    output = $"{Title} was released in {ReleaseYear} and has the genres of : {string.Join(", ", Genres)}.";
                    break;
                case 1:
                    output = $"{Title} was released in {ReleaseYear} (which makes it {age} year old) and has the genres of : {string.Join(", ", Genres)}.";
                    break;
                default:
                    output = $"{Title} was released in {ReleaseYear} (which makes it {age} years old) and has the genres of : {string.Join(", ", Genres)}.";
                    break;
            }

            

            return output;           
        }

    }
}
