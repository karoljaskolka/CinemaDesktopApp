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

        public void DeleteRatingByCustomer(int customerID)
        {
            using (CinemaEntities database = new CinemaEntities())
            {
                database.Rating.RemoveRange(database.Rating.Where(x => x.Customer_ID == customerID));
                database.SaveChanges();
            }
        }

    }
}
