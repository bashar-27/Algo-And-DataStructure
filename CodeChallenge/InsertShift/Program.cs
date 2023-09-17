using System;
using System.Collections.Generic;


namespace InsertShift
{


    public class Program
    {



        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>
{
    new Movie { Title = "Your Name", Year = 2016, Genres = new List<string> { "Animation", "Drama", "Fantasy" } },
    new Movie { Title = "Spirited Away", Year = 2001, Genres = new List<string> { "Animation", "Adventure", "Family" } },
    new Movie { Title = "Akira", Year = 1988, Genres = new List<string> { "Animation", "Action", "Sci-Fi" } },
    new Movie { Title = "Grave of the Fireflies", Year = 1988, Genres = new List<string> { "Animation", "Drama", "War" } },
    new Movie { Title = "Princess Mononoke", Year = 1997, Genres = new List<string> { "Animation", "Adventure", "Fantasy" } },
    new Movie { Title = "Perfect Blue", Year = 1997, Genres = new List<string> { "Animation", "Horror", "Mystery" } },
    new Movie { Title = "Ghost in the Shell", Year = 1995, Genres = new List<string> { "Animation", "Action", "Crime" } }
    // Add more anime movies as needed
};
            List<Movie> sortedByYear = Sorting.SortByYear(new List<Movie>(movies));
            List<Movie> sortedByTitle = Sorting.SortByName(new List<Movie>(movies));

            Console.WriteLine("{0,-30} {1}", "Title", "Year");
            Console.WriteLine(new string('-', 36));

            Console.WriteLine("\n--------------Sorted by Years---------------:");
            foreach (var movie in sortedByYear)
            {
                Console.WriteLine("{0,-30} {1}", movie.Title, movie.Year);
            }


            Console.WriteLine("\n--------------Sorted by Title----------------");
            foreach (var movie in sortedByTitle)
            {
                Console.WriteLine($"Title: {movie.Title}.");


            }



        }
    }
}



    
