using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    class View 
    {   //member variables
        TVShows tvshows = new TVShows();
        public View()//constructor
        {

        }
        public void seeAll()
        {
            Console.WriteLine("Shows\n");
            for (int i = 0; i < 5; i++)
            {
               Console.WriteLine(tvshows.ShowName);
                
            }
            Console.WriteLine();
            Console.WriteLine("Movies\n");
            for (int i = 0; i < 5; i++)
            {

                //Console.WriteLine(MovieName[i]);
            }
            Console.ReadKey();
        }
    }//class
}//namespace

