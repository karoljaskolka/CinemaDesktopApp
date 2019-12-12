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
        private int customerID;

        public int CustomerID { get => customerID; set => customerID = value; }
        
        public RatingsClientPanel(int customerID)
        {
            InitializeComponent();
            CustomerID = customerID;

            //wypelniam tabele danymi
            GetDataFromTable();
            
        }
        /// <summary>
        /// wypelnienie tabeli informazjami z bazy
        /// </summary>
        private void GetDataFromTable()
        {

            //int connection;


            //        //zapytanie
            //        SqlDataAdapter adapter = new SqlDataAdapter("SELECT concat(Customer.First_Name,' ',Customer.Last_Name)AS 'Customer',Movie.Title AS 'Title',Rating.stars AS 'Rating', Rating.Date AS 'Date' FROM Rating INNER JOIN Customer ON Customer.Customer_ID = Rating.Customer_ID INNER JOIN Movie ON Movie.Movie_ID = Rating.Movie_ID WHERE  Rating.Customer_ID = @Customer_ID AND Rating.Date < cast(sysdatetime() as date)", connection);
                    
            //        //utworzenie tabeli
            //        DataTable table = new DataTable();
                    
            //        //dodanie parametru id klienta obecnego
            //        adapter.SelectCommand.Parameters.AddWithValue("@Customer_ID", CustomerID);
            //        //wynik zapytania do tabeli posrednio z adaptera
            //        adapter.Fill(table);

            //        ///do datarigview dodano powyzsza tabele
            //        dataGridViewRatings.DataSource = table;

                }
              
              
    }
}
