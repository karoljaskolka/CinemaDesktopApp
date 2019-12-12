using Cinema.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Services
{
    class TicketService
    {

    public void ShowTicketView()
        {
            using(CinemaEntities context=new CinemaEntities())
            {
                var tickets = context.TICKET_VIEW.ToList();

                foreach (var item in tickets)
                {
                    Console.WriteLine($"Client: {item.Client} Movie: {item.Movie}");
                }
            }
        }



    }
}
