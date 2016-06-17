using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    class Genres
    {   //member variables
        public List<string> genres = new List<string>();
        
    public Genres()//constructor
        {
            genres.Add("Romance");
            genres.Add("Comedy");
            genres.Add("Action");
            genres.Add("Musical");
            
        }      
    public void GenreList()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Genres Available\n");
            Console.ResetColor();
            foreach (string genre in genres)
            {
                Console.WriteLine(genre);
            }

            Console.ReadKey();
        }
        
    }//class

}//namespace

