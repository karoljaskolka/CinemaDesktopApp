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
        private int showtimeID;
        private int seatID;
        bool checkTicket;
        public int CustomerID { get => customerID; set => customerID = value; }
        public int TicketID { get => ticketID; set => ticketID = value; }
        public int ShowtimeID { get => showtimeID; set => showtimeID = value; }
        public int SeatID { get => seatID; set => seatID = value; }

        public TicketsClientPanel(int customerID)
        {
            InitializeComponent();
            CustomerID = customerID;
            service = new TicketService();
            SetDesign();
            checkTicket = false;

            //wczytanie danych do tabeli
            GetDataFromTable();

        }
        
        private void SetDesign()
        {
            buttonBuy.BackColor = Design.CLIENT_BUTTONS_BACKCOLOR;
            buttonBuy.ForeColor = Design.CLIENT_BUTTONS_FORECOLOR;
            groupBoxTicket.ForeColor = Design.FONT_CLIENT;
            groupBoxTicket.BackColor = Color.Transparent;

            buttonUnbook.BackColor = Design.CLIENT_BUTTONS_BACKCOLOR;
            buttonUnbook.ForeColor = Design.CLIENT_BUTTONS_FORECOLOR;
        }


        /// <summary>
        /// wypelnienie tabeli danymi z bazy danych
        /// polaczen z baza</summary>
        public void GetDataFromTable()
        {
            service.ShowTicketView(dataGridViewTickets , customerID);
              

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

                checkTicket = true;

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
                else
                {
                    buttonBuy.Visible = false;
                    buttonUnbook.Visible = false;
                }
                
                labelTicketType.Text = row.Cells["Type"].Value.ToString();
            }
            else
            {
                checkTicket = false;
            }
        }

        private void buttonUnbook_Click(object sender, EventArgs e)
        {

            if (checkTicket){

                SeatID = service.GetSeatID(Convert.ToInt32(labelTicketScreen.Text), labelTicketSeat.Text);
                ShowtimeID = service.GetShowtimeID(Convert.ToInt32(labelTicketScreen.Text), labelTicketDate.Text + ":00.000");
                TicketID = service.GetTicketID(ShowtimeID, SeatID);

                service.UnbookTicket(TicketID);

                MessageBox.Show("You reservation has been canceled.");


                GetDataFromTable();
                CleanLabels();
            }
            else
            {
                MessageBox.Show("You must choose a ticket");

            }
            

        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (checkTicket)
            {
                SeatID = service.GetSeatID(Convert.ToInt32(labelTicketScreen.Text), labelTicketSeat.Text);
                ShowtimeID = service.GetShowtimeID(Convert.ToInt32(labelTicketScreen.Text), labelTicketDate.Text + ":00.000");
                TicketID = service.GetTicketID(ShowtimeID, SeatID);

                service.BuyTicket(TicketID);

                MessageBox.Show("You bouht this ticket.");

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
            buttonUnbook.Visible = false;
            buttonBuy.Visible = false;
        }
    }
}
