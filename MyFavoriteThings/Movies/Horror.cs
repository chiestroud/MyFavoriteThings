using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFavoriteThings.Movies
{
    class Horror : Movie
    {
        public Horror(string name, bool watched)
        {
            Name = name;
            Watched = watched;
        }
    }
}
