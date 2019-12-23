using Cinema.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Services
{
    class TicketService
    {

    public void ShowTicketView(DataGridView table,int customerID)
        {
            using (CinemaEntities database = new CinemaEntities())
            {
                table.DataSource = database.sp_showCustomerTickets(customerID).ToList();
            }
        }



    public int GetTicketID(int showtimeID, int seatID)
        {

            int ID = 0;
            using (CinemaEntities database = new CinemaEntities())
            {
                
                // pobranie ID użytkownika o podanym loginie
                Ticket ticket = database.Ticket.Where(x => x.Seat_ID == seatID && x.Showtime_ID == showtimeID).SingleOrDefault();
                if (ticket != null)
                {
                    ID = ticket.Ticket_ID;
                }

                
            }
            return ID;


        }

        public int GetShowtimeID(int screenID, string date)
        {

            int ID = 0;
            using (CinemaEntities database = new CinemaEntities())
            {
                DateTime myDate = DateTime.Parse(date);
                // pobranie ID użytkownika o podanym loginie
                Showtime showtime = database.Showtime.Where(x => x.Screen_ID == screenID && x.Date == myDate).SingleOrDefault();
                if (showtime != null)
                {
                    ID = showtime.Showtime_ID;
                }


            }
            return ID;

        }

        public int GetSeatID(int screenID,string nameOfSeat)
        {
            int ID = 0;
            using (CinemaEntities database = new CinemaEntities())
            {
                
                Seat seat = database.Seat.Where(x => x.Screen_ID == screenID && x.Name == nameOfSeat).SingleOrDefault();
                if (seat != null)
                {
                    ID = seat.Seat_ID;
                }


            }
            return ID;





        }
        public void UnbookTicket(int ticketID)
        {

            using (CinemaEntities database = new CinemaEntities())
            {

                
               Ticket ticket = database.Ticket.Single(x => x.Ticket_ID == ticketID);
                if (ticket != null)
                {
                    database.Ticket.Remove(ticket);
                    database.SaveChanges();
                }


            }

        }

        public void BuyTicket(int ticketID)
        {

            using (CinemaEntities database = new CinemaEntities())
            {

                Ticket ticket = database.Ticket.Single(x => x.Ticket_ID == ticketID);
                if (ticket != null)
                {
                    ticket.Status = "Paid";
                    database.SaveChanges() ;
                }

            }

        }

        public void DeleteTicketByCustomer(int customerID)
        {
            using (CinemaEntities database = new CinemaEntities())
            {
                database.Ticket.RemoveRange(database.Ticket.Where(x => x.Customer_ID == customerID));
                database.SaveChanges();
            }
        }

    }
}
