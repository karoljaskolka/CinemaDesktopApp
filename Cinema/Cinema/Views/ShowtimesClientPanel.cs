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
        private int ticketID;
        private int showtimeID;

        //gettery i settery
        public int CustomerID { get => customerID; set => customerID = value; }
         public int SeatID { get => seatID; set => seatID = value; }
        public int TicketID { get => ticketID; set => ticketID = value; }
        public int ShowtimeID { get => showtimeID; set => showtimeID = value; }

        ShowtimesService service;

        List<int> seats;
        public ShowtimesClientPanel(int customerID)
        {
            InitializeComponent();
            buttonBook.BackColor = Color.LavenderBlush;
            buttonBuy.BackColor = Color.LavenderBlush;
            CustomerID = customerID;
            service = new ShowtimesService();
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



            service.ShowShowtimes(dataGridViewShowtimes);



            //    using (var connection = dbConnectionCinema())
            //    {

            //        //polaczeniea
            //        connection.Open();
            //        try
            //        {



            //            //tresc zapytania
            //            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Movie.Title AS 'Title',Showtime.date AS 'Date', Showtime.Screen_ID AS 'Screen',Showtime.Showtime_ID AS 'ID' FROM Showtime INNER JOIN  Movie ON Movie.Movie_ID = Showtime.Movie_ID WHERE Date > cast(sysdatetime() as date)", connection);

            //            DataTable table = new DataTable();

            //            //wynik zapytania do tabeli posrednio z adaptera
            //            adapter.Fill(table);

            //            ///do datarigview dodano powyzsza tabele
            //            dataGridViewShowtimes.DataSource = table;

            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.ToString());
            //        }
            //        connection.Close();

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
                buttonBook.Visible = true;
                comboBoxShowtimeTicket.Visible = true;
                //przypisanie warotsci do etykiet z obecnego wiersza
                //ShowtimeID= Convert.ToInt32(row.Cells["ID"].Value);
                labelReservationMovie.Text = row.Cells["Movie"].Value.ToString();
                labelReservationDate.Text = row.Cells[5].Value.ToString();
                labelReservationScreen.Text = row.Cells[6].Value.ToString();
                comboBoxShowtimeTicket.SelectedIndex = -1;
                //wypelnienie pozostałych etykiet 
                //fillDataFromDatabase();

            }

        }

        /// <summary>
        /// funkcja pobiera dane z tabeli tych wartosci ktorych nie ma w tabeli
        /// </summary>
        private void fillDataFromDatabase()
        {
        //    labelReservationClient.Visible = true;
        //    comboBoxShowtimeSeat.Visible = true;

        //    //tresc zapytan
        //    string query = "SELECT concat(Customer.First_Name,' ',Customer.Last_Name)AS 'Customer' FROM Customer WHERE  Customer_ID = @Customer_ID ";
        //    string querySeat = "SELECT Seat.Name From Seat WHERE Screen_ID=@Screen_ID";
        //    //inicjalizacja polaczenia
        //    var connection = dbConnectionCinema();
        //    using (var command = new SqlCommand(query, connection))

        //    {
        //        //otworzenie polaczenia
        //        connection.Open();

        //        //parametr id klienta
        //        command.Parameters.Add(new SqlParameter("@Customer_ID", CustomerID));
                
        //        //przypisanie do labela imiienia i nazwiska obecnego klienta
        //        labelReservationClient.Text=command.ExecuteScalar().ToString();
                
              
                
        //    }
            
        //        try
        //        {

        //        //wyczyszczenie chcekbox'a
        //        comboBoxShowtimeSeat.Items.Clear();


        //            SqlDataAdapter adapter = new SqlDataAdapter(querySeat, connection);
                    
        //            DataTable table = new DataTable();
                    
        //        //parametr id wybrabnej sali
        //            adapter.SelectCommand.Parameters.AddWithValue("@Screen_ID", labelReservationScreen.Text);
        //        //wynik zapytania do tabeli posrednio z adaptera
        //        adapter.Fill(table);

        //        //lista siedzen
        //        seats = new List<int>();
        //        //dodaje kazda wartosc z listy do comboboxa
        //            foreach(DataRow dr in table.Rows)
        //        {
        //            comboBoxShowtimeSeat.Items.Add(dr["Name"].ToString());
                    
        //        }

        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.ToString());
        //        }

           

        //    connection.Close();
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
            //    //jesli ulgowy to przypisuje id biletu 1
            //    if (comboBoxShowtimeSeat.Text == "Reduced")
            //    {
            //        TicketID = 1;
            //    }
            //    else
            //    {
            //        TicketID = 2;
            //    }
            //    //inicjalizacja polaczenia
            //   // var connection;
            //    //tresc zapytania 
            //    string querySeatID = "SELECT Seat_ID From Seat WHERE Screen_ID=@Screen_ID AND Name=@Name";
                
            //    //szukam siedzienia id
            //    using (var command = new SqlCommand(querySeatID, connection))

            //    {
            //        connection.Open();

            //        //podaje parametry nazwy siedzeinia i id sali
            //        command.Parameters.Add(new SqlParameter("@Name", comboBoxShowtimeSeat.Text));
            //        command.Parameters.Add(new SqlParameter("@Screen_ID", labelReservationScreen.Text));
                    
            //       SeatID = Convert.ToInt32(command.ExecuteScalar().ToString());

            //    }


            //    //rezerwuje bilet
            //    using (var command = new SqlCommand(query, connection))
            //    {
            //        //obecna data
            //        DateTime myDateTime = DateTime.Now;
            //        //format daty poprawny do sql
            //        string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm");
            //        //podaje potrzebne parametry
            //        command.Parameters.Add(new SqlParameter("@Showtime_ID", ShowtimeID));
            //        command.Parameters.Add(new SqlParameter("@Customer_ID", CustomerID));
            //        command.Parameters.Add(new SqlParameter("@Seat_ID", SeatID));
            //        command.Parameters.Add(new SqlParameter("@Ticket_Type_ID", TicketID));
            //        command.Parameters.Add(new SqlParameter("@Date", sqlFormattedDate));
                    
            //        //wykonanie inserta
            //        command.ExecuteScalar();
            //        connection.Close();

            //        //zerowanie comboboxow
            //        comboBoxShowtimeTicket.SelectedIndex = -1;
            //        comboBoxShowtimeSeat.SelectedIndex = -1;
            //        MessageBox.Show("Congratulations, you booked a ticket");

            //    }

            }
            else
            {
                MessageBox.Show("You must choose seat and ticket type");
            }
        }

    }
}
