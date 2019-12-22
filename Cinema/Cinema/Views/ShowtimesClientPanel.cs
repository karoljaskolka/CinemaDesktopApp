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
    /// <summary>
    /// klasa pokazuje seansy i zapisuje rezerwacje
    /// </summary>
    public partial class ShowtimesClientPanel : UserControl


    {

        
        private int customerID;
        private int seatID;
        private int ticketTypeID;
        private int showtimeID;

        private string name;
        private string surname;
        //gettery i settery
        public int CustomerID { get => customerID; set => customerID = value; }
        public int SeatID { get => seatID; set => seatID = value; }
        public int TicketTypeID { get => ticketTypeID; set => ticketTypeID = value; }
        public int ShowtimeID { get => showtimeID; set => showtimeID = value; }

        ShowtimesService serviceShowtime;
        CustomerService serviceCustomer;

        List<int> seats;
        public ShowtimesClientPanel(int customerID)
        {
            InitializeComponent();
            buttonBook.BackColor = Color.LavenderBlush;
            buttonBuy.BackColor = Color.LavenderBlush;
            CustomerID = customerID;
            serviceShowtime = new ShowtimesService();
            serviceCustomer = new CustomerService();

            name = serviceCustomer.GetName(CustomerID).ToString();
            surname = serviceCustomer.GetSurname(CustomerID).ToString();

            //wczytanie seansow do tabeli
            GetDataFromTable();
            comboBoxShowtimeTicket.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxShowtimeSeat.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        /// <summary>
        /// wyswietlenie seansow w tabeli
        /// </summary>
        public void GetDataFromTable()
        {

            serviceShowtime.ShowShowtimes(dataGridViewShowtimes);


        }



        /// <summary>
        /// funkcja jest wywolywana gdy zmienimy zaznaczenie obecnego wiersza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewShowtimes_SelectionChanged(object sender, EventArgs e)
        {
            //jesli jest cos zaznaczone to wchodzimy w warunek
            if (dataGridViewShowtimes.SelectedRows.Count != 0)
            {
                //pobranie zaznaczonego wiersza
                DataGridViewRow row = this.dataGridViewShowtimes.SelectedRows[0];
                //wlaczenie etykiet
                labelReservationMovie.Visible = true;
                labelReservationDate.Visible = true;
                labelReservationScreen.Visible = true;
                labelReservationClient.Visible = true;
                buttonBuy.Visible = true;
                buttonBook.Visible = true;
                comboBoxShowtimeTicket.Visible = true;
                comboBoxShowtimeSeat.Visible = true;
                
                //przypisanie warotsci do etykiet z obecnego wiersza
                labelReservationMovie.Text = row.Cells["Movie"].Value.ToString();
                labelReservationDate.Text = row.Cells["Date"].Value.ToString();
                labelReservationScreen.Text = row.Cells["Screen"].Value.ToString();
                ShowtimeID = serviceShowtime.GetShowtimeID(Convert.ToInt32(labelReservationScreen.Text), row.Cells["Date"].Value.ToString() + ":00.000");
                serviceShowtime.ShowAvailableSeats(comboBoxShowtimeSeat, ShowtimeID);

                labelReservationClient.Text = name + " " + surname;
                comboBoxShowtimeTicket.SelectedIndex = -1;
                comboBoxShowtimeSeat.SelectedIndex = -1;
                
            }

        }

        

        /// <summary>
        /// przycisk rezerwuje miejsce na seans
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBook_Click(object sender, EventArgs e)
        {
            ////tresc inserta
            //string query = "INSERT INTO Ticket VALUES (NEXT VALUE FOR SEQ_TICKET_ID,@Showtime_ID, @Customer_ID,@Seat_ID,@Ticket_Type_ID,'Booked',@Date)";
            
            ////jesli zaznaczylismy comboboxy to wchodzimy
            if (!string.IsNullOrEmpty(comboBoxShowtimeTicket.Text) && !string.IsNullOrEmpty(comboBoxShowtimeSeat.Text))
            {
                 if (comboBoxShowtimeSeat.Text == "Reduced")
                 {
                     TicketTypeID = 1;
                 }
                 else
                  {
                     TicketTypeID = 2;
                  }


                SeatID = Convert.ToInt32(comboBoxShowtimeSeat.SelectedValue);
                serviceShowtime.OrderingTicket(ShowtimeID, CustomerID, SeatID, TicketTypeID, "Booked");

                MessageBox.Show("You booked a ticket for " + labelReservationMovie.Text);
                CleanLabels();
                

            }
            else
            {
                MessageBox.Show("You must choose seat and ticket type");
            }
        }

        private void CleanLabels()
        {
            labelReservationMovie.Text = "";
            labelReservationDate.Text = "";
            labelReservationScreen.Text = "";
            labelReservationClient.Text = ""; 
            comboBoxShowtimeTicket.SelectedIndex = -1;
            comboBoxShowtimeSeat.SelectedIndex = -1;
            buttonBook.Visible = false;
            buttonBuy.Visible = false;
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (comboBoxShowtimeSeat.Text == "Reduced")
            {
                TicketTypeID = 1;
            }
            else
            {
                TicketTypeID = 2;
            }


            SeatID = Convert.ToInt32(comboBoxShowtimeSeat.SelectedValue);
            serviceShowtime.OrderingTicket(ShowtimeID, CustomerID, SeatID, TicketTypeID, "Paid");

            MessageBox.Show("You booght a ticket for " + labelReservationMovie.Text);
            CleanLabels();



        }
    }
}
