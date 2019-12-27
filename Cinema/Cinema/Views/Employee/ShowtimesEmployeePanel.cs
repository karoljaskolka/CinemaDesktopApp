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
    public partial class ShowtimesEmployeePanel : UserControl
    {
        ShowtimesService serviceShowtime;
        CustomerService serviceCustomer;

        private int customerID;
        private int seatID;
        private int ticketTypeID;
        private int showtimeID;

        public int CustomerID { get => customerID; set => customerID = value; }
        public int SeatID { get => seatID; set => seatID = value; }
        public int TicketTypeID { get => ticketTypeID; set => ticketTypeID = value; }
        public int ShowtimeID { get => showtimeID; set => showtimeID = value; }

        public ShowtimesEmployeePanel()
        {
            InitializeComponent();
            serviceShowtime = new ShowtimesService();
            serviceCustomer = new CustomerService();
            comboBoxShowtimeTicket.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxShowtimeSeat.DropDownStyle = ComboBoxStyle.DropDownList;
            GetDataFromTable();
            
        }

        /// <summary>
        /// wyswietlenie seansow w tabeli
        /// </summary>
        public void GetDataFromTable()
        {

            serviceShowtime.ShowShowtimes(dataGridViewShowtimes);
            

        }

        private void dataGridViewShowtimes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewShowtimes.SelectedRows.Count != 0)
            {
                //pobranie zaznaczonego wiersza
                DataGridViewRow row = this.dataGridViewShowtimes.SelectedRows[0];
                groupBoxShowtime.Visible = true;

                //przypisanie warotsci do etykiet z obecnego wiersza
                labelReservationMovie.Text = row.Cells["Movie"].Value.ToString();
                labelReservationDate.Text = row.Cells["Date"].Value.ToString();
                labelReservationScreen.Text = row.Cells["Screen"].Value.ToString();
                ShowtimeID = serviceShowtime.GetShowtimeID(Convert.ToInt32(labelReservationScreen.Text), row.Cells["Date"].Value.ToString() + ":00.000");
                serviceShowtime.ShowAvailableSeats(comboBoxShowtimeSeat, ShowtimeID);

                buttonBook.Visible = true;
                buttonBuy.Visible = true;

                // labelReservationClient.Text = name + " " + surname;
                comboBoxShowtimeTicket.SelectedIndex = -1;
                comboBoxShowtimeSeat.SelectedIndex = -1;

            }
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

            //CustomerID = serviceCustomer.
            SeatID = Convert.ToInt32(comboBoxShowtimeSeat.SelectedValue);
            CustomerID = serviceCustomer.GetCustomerID("Anonymous_Client");
            serviceShowtime.OrderingTicket(ShowtimeID, CustomerID, SeatID, TicketTypeID, "Paid");

            MessageBox.Show("The purchase of ticket for " + labelReservationMovie.Text+" has been done.");
            CleanLabels();

        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
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

                //CustomerID = serviceCustomer.
                SeatID = Convert.ToInt32(comboBoxShowtimeSeat.SelectedValue);
                CustomerID = serviceCustomer.GetCustomerID("Anonymous_Client");
                serviceShowtime.OrderingTicket(ShowtimeID, CustomerID, SeatID, TicketTypeID, "Booked");

                MessageBox.Show("Reservation for " + labelReservationMovie.Text + " has been done.");
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
            
            comboBoxShowtimeTicket.SelectedIndex = -1;
            comboBoxShowtimeSeat.SelectedIndex = -1;
            buttonBook.Visible = false;
            buttonBuy.Visible = false;
        }
    }
}
