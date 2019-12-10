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

namespace Cinema
{
    /// <summary>
    /// klasa składa skarge na kino lub jego aplikacje
    /// </summary>
    public partial class ReportClientPanel : UserControl
    {
        //zmienne potrzebne do polaczenia sie z baza danych i nr klienta
        
        private readonly Func<System.Data.SqlClient.SqlConnection> dbConnectionCinema = () => new SqlConnection(ConfigurationManager.ConnectionStrings["CinemaKredek"].ConnectionString);

        private int customerID;

        //gettery i settery
        public int CustomerID { get => customerID; set => customerID = value; }
       


        public ReportClientPanel(int customerID)
        {
            InitializeComponent();
            buttonReport.BackColor = Color.LavenderBlush;
            CustomerID = customerID;
        }

        /// <summary>
        /// po przycisnieciu zostaje złozona skarga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReport_Click(object sender, EventArgs e)
        {
            //tresc inserta
             string query = "INSERT INTO Complaint VALUES (NEXT VALUE FOR SEQ_COMPLAINT_ID, @Customer_ID,@Description,@Date)";

             if (textBoxReport.Text != "")
             {
                 var connection = dbConnectionCinema();
                 using (var command = new SqlCommand(query, connection))
                 {
                    //otworzenie polaczenia
                     connection.Open();
                    //przypisanie obecnej daty
                    DateTime myDateTime = DateTime.Now;
                    //format daty potrzebnej do wprowadzania do bazy
                    string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm"); 
                    //dodanie parametrow
                    command.Parameters.Add(new SqlParameter("@Customer_ID", CustomerID));
                    command.Parameters.Add(new SqlParameter("@Date", sqlFormattedDate));
                    command.Parameters.Add(new SqlParameter("@Description", textBoxReport.Text));
                     
                    //wykonanie inserta
                     command.ExecuteReader();
                     connection.Close();
                     
                     MessageBox.Show("Your complaint has been submitted");
                    textBoxReport.Text = "";
                 }

             }
             else
             {
                 MessageBox.Show("You must write complain above");
             }
        }
    }
}
