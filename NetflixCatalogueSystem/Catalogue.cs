using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NetflixCatalogueSystem
{
    public class Catalogue
    {   //member variables
        Genres addGenres = new Genres();
        TVShows addShows = new TVShows();
        Movies addMovies = new Movies();
        public List<string> comedies = new List<string>();
        public List<string> actions = new List<string>();
        public List<string> romances = new List<string>();
        public List<string> musicals = new List<string>();

    public Catalogue()
        {   //contructor
        seeComedy();
        seeAction();
        seeRomance();
        seeMusical();
        } 
    public void seeComedy()
        {
            comedies.Add("Dogma-Runtime 190 minutes");
            comedies.Add("The Big Bang Theory-Rating 4.5");
            comedies.Add("Modern Family-Rating 4");
        }     
                      
    public void seeAction()
        {
            actions.Add("Serenity-Runtime: 159 miuntes");
            actions.Add("Star Wars-Runtime: 185 minutes");
            actions.Add("FireFly-Rating: 5");
            actions.Add("Supernatural-Rating: 4");
            actions.Add("Person of Interest-Rating: 3.5");

        }
    public void seeRomance()
        {
            romances.Add("Forrest Gump-Runtime 205 minutes");
        }
    public void seeMusical()
        {
            musicals.Add("The Wizard of Oz-Runtime 152 minutes");
        }
        public void seeCatalogue()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Movies and Shows by Genre");
            Console.ResetColor();
            Console.ReadLine();
            Console.WriteLine("Comedy Includes:");
            foreach (string com in comedies)
            {               
                Console.WriteLine(com);
                
            }
            Console.WriteLine();
            Console.WriteLine("Action Includes:");
            foreach (string act in actions)
            {
                Console.WriteLine(act);
                
            }
            Console.WriteLine();
            Console.WriteLine("Romance Includes:");
            foreach (string rom in romances)
            {
                Console.WriteLine(rom);
                
            }
            Console.WriteLine();
            Console.WriteLine("Musicals Includes:");
            foreach (string mus in musicals)
            {
                Console.WriteLine(mus);
                
            }
            Console.ReadLine();        
 
        }
        

    }//class
}//namespace