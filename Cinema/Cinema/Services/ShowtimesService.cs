using Cinema.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Services
{
    class ShowtimesService
    {
        public void ShowShowtimes(DataGridView table)
        {
            using (CinemaEntities database = new CinemaEntities())
            {
                table.DataSource=database.SHOWTIME_VIEW.ToList();
            }
        

        }


    }
}
