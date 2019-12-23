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

        public void GetShowtimes(DataGridView table)
        {
            using (CinemaEntities database = new CinemaEntities())
            {
                table.DataSource = database.Showtime.Join(database.Movie, x => x.Movie_ID, y => y.Movie_ID,
                        (x, y) => new { x.Showtime_ID, x.Movie_ID, y.Title, x.Screen_ID, x.Date, x.Technology })
                            .ToList();
            }
        }

        public void AddShowtime(int movieID, int screenID, string date, string technology)
        {
            using(CinemaEntities database = new CinemaEntities())
            {
                Showtime showtime = database.Showtime.Create();

                showtime.Showtime_ID = Convert.ToInt32(database.sp_getSeqShowtimeID().FirstOrDefault());
                showtime.Movie_ID = movieID;
                showtime.Screen_ID = screenID;
                showtime.Date = DateTime.Parse(date);
                showtime.Technology = technology;

                database.Showtime.Add(showtime);
                database.SaveChanges();
            }
        }

        public void EditShowtime(int showtimeID, int screenID, string date, string technology)
        {
            using (CinemaEntities database = new CinemaEntities())
            {

                Showtime showtime = database.Showtime.Single(x => x.Showtime_ID == showtimeID);

                showtime.Screen_ID = screenID;
                showtime.Date = DateTime.Parse(date);
                showtime.Technology = technology;

                database.SaveChanges();
            }
        }

        public void ShowAvailableSeats(ComboBox seats, int showtimeID)
        {
            using (CinemaEntities database = new CinemaEntities())
            {

                seats.DataSource = database.sp_showAvailableSeats(showtimeID);
                seats.ValueMember = "Seat_ID";
                seats.DisplayMember = "Name";
            }
        }
        public int GetShowtimeID(int screenID, string date)
        {
            
                int ID = 0;
                using (CinemaEntities database = new CinemaEntities())
                {
                DateTime myDate = DateTime.Parse(date);
                // pobranie ID użytkownika o podanym loginie
                Showtime showtime = database.Showtime.Where(x => x.Screen_ID == screenID && x.Date== myDate).SingleOrDefault();
                if (showtime != null)
                {
                    ID = showtime.Showtime_ID;
                }
                
                
                }
                return ID;
            
        }

        public void OrderingTicket( int showtimeID, int customerID, int seatID, int ticketTypeID, string status)
        {

            using (CinemaEntities database = new CinemaEntities())
            {
                Ticket newTicket = database.Ticket.Create();

                //obecna data
                DateTime myDateTime = DateTime.Now;
                //format daty poprawny do sql
                string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm");

                newTicket.Ticket_ID = Convert.ToInt32(database.sp_getSeqTicketID().FirstOrDefault());
                newTicket.Customer_ID = customerID;
                newTicket.Showtime_ID = showtimeID;
                newTicket.Seat_ID = seatID;
                newTicket.Ticket_Type_ID = customerID;
                newTicket.Status = status;
                newTicket.Date = DateTime.Parse(sqlFormattedDate);

                database.Ticket.Add(newTicket);
                database.SaveChanges();
            }

        }

        public void BuyingTicket()
        {



        }


    }
}
