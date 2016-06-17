using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    class Movies : Title
    {   //member variables

        public List<string> MovieName = new List<string>() { "Serenity", "Dogma", "The Wizard of Oz", "Star Wars", "Forrest Gump" };
        public List<string> Runtime = new List<string>() { "159 minutes", "190 minutes", "152 minutes", "185 minutes", "205 minutes" };
        public Movies()//constructor
        {

        }
            
            public void MovieList()
            {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Movie Available\n");
            Console.ResetColor();
            for (int i = 0; i < MovieName.Count; i++)
            {
                Console.WriteLine(MovieName[i] + " \nRuntime: " + Runtime[i]);
            }
            Console.ReadKey();
            //selectMovie();
        }
        
    }//class
}//namespace
