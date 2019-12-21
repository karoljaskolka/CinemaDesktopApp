using Cinema.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Globalization;
using System.Threading;

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

        public void ShowAvailableSeats(ComboBox seat)
        {
            using (CinemaEntities database = new CinemaEntities())
            {

                //seat.Items.AddRange(database.sp_showAvailableSeats(4).ToString());
                List<string> seats = new List<string>();

                DataTable table = new DataTable();

               // seats.Add(database.sp_showAvailableSeats(4).ToString());
                var result = database.sp_showAvailableSeats(4).ToString();


                //table.DataSet(result);




                BindingSource bs = new BindingSource();
                bs.DataSource = seats;
                seat.DataSource = bs;
            }
        }
        public int GetShowtimeID(int screenID,string date)
        {
            
                int ID = 0;
                using (CinemaEntities database = new CinemaEntities())
                {
                DateTime myDate = DateTime.Parse(date);
                // pobranie ID użytkownika o podanym loginie
                Showtime showtime = database.Showtime.Where(x => x.Screen_ID == screenID && x.Date== myDate).SingleOrDefault();
               // ID = showtime.Showtime_ID;
                //MessageBox.Show("ID " + ID);
                }
                return ID;
            
        }


    }
}
