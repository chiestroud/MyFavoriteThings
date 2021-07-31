using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.Movies
{
    class ActionMovie : Movie
    {
        public ActionMovie(string name, bool watched)
        {
            Name = name;
            Watched = watched;
        }
    }
}
