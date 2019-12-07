using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Cinema
{
    public partial class RatingsClientPanel : UserControl
    {
        private SqlCommand querySQL;

        private readonly Func<System.Data.SqlClient.SqlConnection> dbConnectionCinema = () => new SqlConnection(ConfigurationManager.ConnectionStrings["CinemaKredek"].ConnectionString);

        private int customerID;

        public int CustomerID { get => customerID; set => customerID = value; }
        public SqlCommand QuerySQL { get => querySQL; set => querySQL = value; }

        public RatingsClientPanel(int customerID)
        {
            InitializeComponent();
            CustomerID = customerID;
            GetDataFromTable();
            
        }
        /// <summary>
        /// metoda polaczen z baza
        /// </summary>
        public void GetDataFromTable()
        {
            using (var connection = dbConnectionCinema())
            {

                //polaczeniea
                connection.Open();
                try
                {




                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT concat(Customer.First_Name,' ',Customer.Last_Name)AS 'Customer',Movie.Title AS 'Title',Rating.stars AS 'Rating', Rating.Date AS 'Date' FROM Rating INNER JOIN Customer ON Customer.Customer_ID = Rating.Customer_ID INNER JOIN Movie ON Movie.Movie_ID = Rating.Movie_ID WHERE  Rating.Customer_ID = @Customer_ID ", connection);
                    //wynik zapytania do tabeli posrednio z adaptera
                    DataTable table = new DataTable();
                    //QuerySQL = new SqlCommand(adapter, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@Customer_ID", CustomerID);
                    adapter.Fill(table);
                    ///do datarigview dodano powyzsza tabele
                    dataGridViewRatings.DataSource = table;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                connection.Close();
            }
        }
    }
}
