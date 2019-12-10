using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class FormClient : Form
    {
        //zmienna przechowujaca numer klienta
        private int customerID;

        //getter i settter
        public int CustomerID { get => customerID; set => customerID = value; }

        public FormClient(int customerID)
        {
            InitializeComponent();
            //koloruje przyciski
            buttonShowtimes.BackColor = Color.LavenderBlush;
            buttonTickets.BackColor = Color.LavenderBlush;
            buttonMovies.BackColor = Color.LavenderBlush;
            buttonRatings.BackColor = Color.LavenderBlush;
            buttonReport.BackColor = Color.LavenderBlush;
            buttonProfileUpdate.BackColor = Color.LavenderBlush;

            //przypisuje nr klienta
            CustomerID = customerID;

        }

        /// <summary>
        /// przycisk otwieera panel profilu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonProfileUpdate_Click(object sender, EventArgs e)
        {
            panelClientContent.Controls.Clear();
            ProfileClientPanel profilePanel = new ProfileClientPanel(CustomerID);
            panelClientContent.Controls.Add(profilePanel);
        }

        /// <summary>
        /// przycisk otwiera panel składania skarg
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReport_Click(object sender, EventArgs e)
        {
            panelClientContent.Controls.Clear();
            ReportClientPanel reportPanel = new ReportClientPanel(CustomerID);
            panelClientContent.Controls.Add(reportPanel);
        }

        /// <summary>
        /// przycisk otwiera panel filmow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMovies_Click(object sender, EventArgs e)
        {
            panelClientContent.Controls.Clear();
            MoviesClientPanel moviesPanel = new MoviesClientPanel(CustomerID);
            panelClientContent.Controls.Add(moviesPanel);
        }

        /// <summary>
        /// przycisk otwiera panel biletow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTickets_Click(object sender, EventArgs e)
        {
            panelClientContent.Controls.Clear();
            TicketsClientPanel ticketsClientPanel = new TicketsClientPanel(CustomerID);
            panelClientContent.Controls.Add(ticketsClientPanel);
        }

        /// <summary>
        /// przycisk otwier panel seansow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowtimes_Click(object sender, EventArgs e)
        {
            panelClientContent.Controls.Clear();
            ShowtimesClientPanel showtimesPanel = new ShowtimesClientPanel(CustomerID);
            panelClientContent.Controls.Add(showtimesPanel);
        }

        /// <summary>
        /// przycisk otwiera panel ocen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRatings_Click(object sender, EventArgs e)
        {
            panelClientContent.Controls.Clear();
            RatingsClientPanel ratingsPanel = new RatingsClientPanel(CustomerID);
            panelClientContent.Controls.Add(ratingsPanel);
        }
    }
}
