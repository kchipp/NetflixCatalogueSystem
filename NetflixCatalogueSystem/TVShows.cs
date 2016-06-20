using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    class TVShows : Title

    {   //member variables

        public List<string> ShowName = new List<string>() { "Firefly", "The Big Bang Theory", "Modern Family", "Supernatural", "Person of Interest" };
        public List<int> Episodes = new List<int>() { 14, 207, 166, 241, 102};
        public List<double> Rating = new List<double>() { 5, 4, 3, 3.5, 4 };
        public TVShows()
        //constructor
        {

        }
        //functions follow
        public void ShowList()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TV Shows Available\n");
            Console.ResetColor();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ShowName[i] + "\nEpisodes: " + Episodes[i] + "\nRating: " + Rating[i]);
            }
            Console.ReadKey();

        }
        public void ShowSelect()
        {
            Console.WriteLine("Select a Show");
            string Schoice = Console.ReadLine();
        }

    }//class
}//namespace