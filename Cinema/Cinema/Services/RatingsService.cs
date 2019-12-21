using Cinema.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Services
{
    class RatingsService
    {
        public void ShowRatings(DataGridView table, int customerID)
        {
            using (CinemaEntities database = new CinemaEntities())
            {
                table.DataSource = database.sp_showCustomerRatings(customerID).ToList();
            }


        }

    }
}
