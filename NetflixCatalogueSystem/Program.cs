using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.netflix();
            Catalogue _catalogue = new Catalogue();
            _catalogue.seeCatalogue();
            
        }
    }//class
}//namespace