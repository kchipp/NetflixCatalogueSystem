using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    class Menu
    {   //member variables
        View _view = new View();
        Title _title = new Title();
        TVShows _shows = new TVShows();
        Movies _movies = new Movies();
        Genres _genres = new Genres();
        Catalogue _catalogue = new Catalogue();
        public Menu()
        //constructor
        {

        }
        public void netflix()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nWelcome to the Netflix(ish) Catalogue System\n");
            Console.ResetColor();

            Console.WriteLine("Please Select an Option:\nG to see Genres\nM to see Movies\nS to see TV Shows\nA to see All");
            string choice;
            choice = Console.ReadLine();
            switch (choice.ToLower())
            {
                case "g":
                    _genres.GenreList();
                    Console.Clear();
                    break;
                case "m":
                    _movies.MovieList();
                    Console.Clear();
                    break;
                case "s":
                    _shows.ShowList();
                    Console.Clear();
                    break;
                case "a":
                    _genres.GenreList();
                    _movies.MovieList();
                    _shows.ShowList();

                    Console.Clear();
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Oops! Press 'enter' to Try again");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    netflix();
                    break;
            }
            //StringBuilder builder = new StringBuilder();
            //builder.Append(MovieName);
            //builder.Append("two ");
            //builder.Append("three ");
            ////
            //// Add many strings to the StringBuilder in a loop.
            ////
            //for (int i = 0; i < 10; i++)
            //{
            //    builder.Append("x ");
            //}
            ////
            //// Convert the buffer to a string.
            //// Often no additional copying is required at this stage.
            ////
            //string result = builder.ToString();
            //Console.WriteLine(result);
        }



    }//class

}//namespace