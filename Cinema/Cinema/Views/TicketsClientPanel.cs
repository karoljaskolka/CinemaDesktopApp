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
       //  public int TicketID { get => ticketID; set => ticketID = value; }

        public TicketsClientPanel(int customerID)
        {
            InitializeComponent();
            CustomerID = customerID;
            service = new TicketService();
            //wczytanie danych do tabeli
            GetDataFromTable();
            ;
        }
        /// <summary>
        /// wypelnienie tabeli danymi z bazy danych
        /// polaczen z baza</summary>
        public void GetDataFromTable()
        {
            service.ShowTicketView();
              //  dataGridViewTickets.DataSource = table;

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
        //    if (dataGridViewTickets.SelectedRows.Count != 0)
        //    {
        //        //pobieram obecny wiersz
        //        DataGridViewRow row = this.dataGridViewTickets.SelectedRows[0];
                
        //        //wlaczam widzialnosc przycisku
        //        buttonTicketDelete.Visible = true;
                
        //        //pobranie biletu sid z tabeli
        //        TicketID = Convert.ToInt32(row.Cells["ID"].Value);
                

        //    }
        }
    }
}
