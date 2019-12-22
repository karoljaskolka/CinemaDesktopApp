using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinema.Database;

namespace Cinema.Services
{
    class GenreService
    {
        public List<Genre> GetGenres()
        {

            using (CinemaEntities database = new CinemaEntities())
            {
                return database.Genre.ToList();
            }

        }
    }
}
