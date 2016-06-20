using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalogueSystem
{
    class Title
    {   //member variables
        public string name;
        public double? rating;
        public double? runtime;

        public Title()
            //constructor
        {
            name = null;
            rating = null;
            runtime = null;
        }
        public Title(string Name, int? Rating, double? Runtime)
        {
            this.name = Name;
            this.rating = Rating;
            this.runtime = Runtime;
        }





    } //class   
}//namespace