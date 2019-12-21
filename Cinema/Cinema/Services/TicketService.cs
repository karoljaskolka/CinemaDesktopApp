﻿using Cinema.Database;
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

    public void ShowTicketView(DataGridView table)
        {
            using (CinemaEntities database = new CinemaEntities())
            {
                table.DataSource = database.TICKET_VIEW.ToList();
            }
        }



    }
}
