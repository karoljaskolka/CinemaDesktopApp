using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.Services;

namespace Cinema.Views.Employee
{
    public partial class BookingsEmployeePanel : UserControl
    {
        TicketService service;
        private int customerID;
        private int ticketID;
        private int showtimeID;
        private int seatID;
        bool checkTicket;
        public int CustomerID { get => customerID; set => customerID = value; }
        public int TicketID { get => ticketID; set => ticketID = value; }
        public int ShowtimeID { get => showtimeID; set => showtimeID = value; }
        public int SeatID { get => seatID; set => seatID = value; }
        public BookingsEmployeePanel()
        {
            InitializeComponent();
            CustomerID = customerID;
            service = new TicketService();
            checkTicket = false;

            //wczytanie danych do tabeli
            GetDataFromTable();

        }


        /// <summary>
        /// wypelnienie tabeli danymi z bazy danych
        /// polaczen z baza</summary>
        public void GetDataFromTable()
        {
            service.ShowAllTicketsView(dataGridViewTickets);


        }

        private void dataGridViewTickets_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTickets.SelectedRows.Count != 0)
            {
                //pobieram obecny wiersz
                DataGridViewRow row = this.dataGridViewTickets.SelectedRows[0];

                //wlaczam widzialnosc przycisku
                groupBoxTicket.Visible = true;

                checkTicket = true;

                labelTicketClient.Text = row.Cells["Client"].Value.ToString();
                labelTicketMovie.Text = row.Cells["Movie"].Value.ToString();
                labelTicketDate.Text = row.Cells["Showtime"].Value.ToString();
                labelTicketScreen.Text = row.Cells["Screen_ID"].Value.ToString();
                labelTicketSeat.Text = row.Cells["Seat"].Value.ToString();
                labelTicketPrice.Text = row.Cells["Ticket_Price"].Value.ToString();
                labelTicketStatus.Text = row.Cells["Status"].Value.ToString();
                
                buttonDelete.Visible = true;
                   


                
                
            }
            else
            {
                checkTicket = false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (checkTicket)
            {

                SeatID = service.GetSeatID(Convert.ToInt32(labelTicketScreen.Text), labelTicketSeat.Text);
                ShowtimeID = service.GetShowtimeID(Convert.ToInt32(labelTicketScreen.Text), labelTicketDate.Text + ":00.000");
                TicketID = service.GetTicketID(ShowtimeID, SeatID);

                service.UnbookTicket(TicketID);

                MessageBox.Show("This ticket has been removed. ");


                GetDataFromTable();
                CleanLabels();
            }
            else
            {
                MessageBox.Show("You must choose a ticket");

            }

        }
        private void CleanLabels()
        {
            labelTicketMovie.Text = "";
            labelTicketDate.Text = "";
            labelTicketScreen.Text = "";
            labelTicketClient.Text = "";
            checkTicket = false;
            buttonDelete.Visible = false;
            
        }

    }
}
