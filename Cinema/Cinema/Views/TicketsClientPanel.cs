using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Cinema.Services;

namespace Cinema
{
    public partial class TicketsClientPanel : UserControl
    {
        TicketService service;
        private int customerID;
        private int ticketID;

        public int CustomerID { get => customerID; set => customerID = value; }
        public int TicketID { get => ticketID; set => ticketID = value; }

        public TicketsClientPanel(int customerID)
        {
            InitializeComponent();
            CustomerID = customerID;
            service = new TicketService();
           
            //wczytanie danych do tabeli
            GetDataFromTable();
            
        }
        
        
        /// <summary>
        /// wypelnienie tabeli danymi z bazy danych
        /// polaczen z baza</summary>
        public void GetDataFromTable()
        {
            service.ShowTicketView(dataGridViewTickets , customerID);
              

        }

        /// <summary>
        /// przycisk usuwa rezerwacje lub stary bilet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTicketDelete_Click(object sender, EventArgs e)
        {
        //    //tresc usuniecia
        //    string query = "DELETE FROM Ticket WHERE Ticket_ID=@Ticket_ID";
        //    //jesli nie wybrano zadnego biletu
        //    if (TicketID <= 0)
        //    {
        //        MessageBox.Show("Your should pick ticket to delete");
        //    }
        //    else
        //    {


        //        var connection = dbConnectionCinema();
        //        using (var command = new SqlCommand(query, connection))

        //        {
        //            connection.Open();

        //            //dodanie parametru id biletu
        //            command.Parameters.Add(new SqlParameter("@Ticket_ID", TicketID));
                    
        //            //wykonanie operacji
        //            command.ExecuteScalar();

        //            MessageBox.Show("Your reservation has been canceled");
        //            //wypelnienie tabeli danymi
        //            GetDataFromTable();
        //            connection.Close();
        //        }
        //    }
            
        }

        ///// <summary>
        ///// funkcja ktora wywoluje sie jak zminiamy kliknieciem wiersz
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void dataGridViewTickets_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTickets.SelectedRows.Count != 0)
            {
                //pobieram obecny wiersz
                DataGridViewRow row = this.dataGridViewTickets.SelectedRows[0];
                
                //wlaczam widzialnosc przycisku
                groupBoxTicket.Visible = true;
                
                labelTicketClient.Text = row.Cells["Client"].Value.ToString();
                labelTicketMovie.Text = row.Cells["Movie"].Value.ToString();
                labelTicketDate.Text = row.Cells["Showtime"].Value.ToString();
                labelTicketScreen.Text = row.Cells["Screen"].Value.ToString();
                labelTicketSeat.Text = row.Cells["Seat"].Value.ToString();
                labelTicketPrice.Text = row.Cells["Ticket_Price"].Value.ToString();
                labelTicketStatus.Text = row.Cells["Status"].Value.ToString();
                if (labelTicketStatus.Text == "Booked")
                {
                    buttonBuy.Visible = true;
                    buttonUnbook.Visible = true;

                }
                labelTicketType.Text = row.Cells["Type"].Value.ToString();
            }
        }

        private void buttonUnbook_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {

        }
    }
}
