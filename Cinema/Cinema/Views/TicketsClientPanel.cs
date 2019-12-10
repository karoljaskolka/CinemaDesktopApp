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
    public partial class TicketsClientPanel : UserControl
    {
        //zmienen potrzebne dołaczenia z bazu , nr klienta i biletu
        private SqlCommand querySQL;

        private readonly Func<System.Data.SqlClient.SqlConnection> dbConnectionCinema = () => new SqlConnection(ConfigurationManager.ConnectionStrings["CinemaKredek"].ConnectionString);

        private int customerID;
        private int ticketID;

        public int CustomerID { get => customerID; set => customerID = value; }
        public SqlCommand QuerySQL { get => querySQL; set => querySQL = value; }
        public int TicketID { get => ticketID; set => ticketID = value; }

        public TicketsClientPanel(int customerID)
        {
            InitializeComponent();
            CustomerID = customerID;
            //wczytanie danych do tabeli
            GetDataFromTable();
            TicketID = 0;
        }
        /// <summary>
        /// wypelnienie tabeli danymi z bazy danych
        /// polaczen z baza</summary>
        public void GetDataFromTable()
        {
            using (var connection = dbConnectionCinema())
            {

                //polaczenie
                connection.Open();
                try
                {



                    //zapytanie
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT Movie.Title AS 'Title', Showtime.Date AS 'Date',Showtime.Screen_ID AS 'Screen',Seat.Name AS 'Seat',Ticket.Status,Ticket.Ticket_ID AS 'ID' FROM Ticket INNER JOIN Customer ON Customer.Customer_ID = Ticket.Customer_ID INNER JOIN Showtime ON Ticket.Showtime_ID=Showtime.Showtime_ID INNER JOIN Movie ON Movie.Movie_ID = Showtime.Movie_ID INNER JOIN Seat ON Seat.Seat_ID=Ticket.Seat_ID WHERE  Ticket.Customer_ID = @Customer_ID ", connection);
                    
                    DataTable table = new DataTable();
                    //dodanie parametru nr klienta obecnego
                    adapter.SelectCommand.Parameters.AddWithValue("@Customer_ID", CustomerID);
                    //wynik zapytania do tabeli posrednio z adaptera
                    adapter.Fill(table);
                    ///do datarigview dodano powyzsza tabele
                    dataGridViewTickets.DataSource = table;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                connection.Close();
            }
        }

        /// <summary>
        /// przycisk usuwa rezerwacje lub stary bilet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTicketDelete_Click(object sender, EventArgs e)
        {
            //tresc usuniecia
            string query = "DELETE FROM Ticket WHERE Ticket_ID=@Ticket_ID";
            //jesli nie wybrano zadnego biletu
            if (TicketID <= 0)
            {
                MessageBox.Show("Your should pick ticket to delete");
            }
            else
            {


                var connection = dbConnectionCinema();
                using (var command = new SqlCommand(query, connection))

                {
                    connection.Open();

                    //dodanie parametru id biletu
                    command.Parameters.Add(new SqlParameter("@Ticket_ID", TicketID));
                    
                    //wykonanie operacji
                    command.ExecuteScalar();

                    MessageBox.Show("Your reservation has been canceled");
                    //wypelnienie tabeli danymi
                    GetDataFromTable();
                    connection.Close();
                }
            }
            
        }

        /// <summary>
        /// funkcja ktora wywoluje sie jak zminiamy kliknieciem wiersz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewTickets_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTickets.SelectedRows.Count != 0)
            {
                //pobieram obecny wiersz
                DataGridViewRow row = this.dataGridViewTickets.SelectedRows[0];
                
                //wlaczam widzialnosc przycisku
                buttonTicketDelete.Visible = true;
                
                //pobranie biletu sid z tabeli
                TicketID = Convert.ToInt32(row.Cells["ID"].Value);
                

            }
        }
    }
}
