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
    /// klasa pozwalajaca na edycji swojego konta
    /// </summary>
    public partial class ProfileClientPanel : UserControl
    {
        //zmienne potrzebne do połączenia z baza a takze nr klienta
        List<string> list;
        private SqlCommand querySQL;

        private readonly Func<System.Data.SqlClient.SqlConnection> dbConnectionCinema = () => new SqlConnection(ConfigurationManager.ConnectionStrings["CinemaKredek"].ConnectionString);

        private int customerID;

        public int CustomerID { get => customerID; set => customerID = value; }
        public SqlCommand QuerySQL { get => querySQL; set => querySQL = value; }

        

        public ProfileClientPanel(int customerID)
        {
            InitializeComponent();
            buttonProfileEdit.BackColor = Color.LavenderBlush;
            CustomerID = customerID;
            //wypełniam textBox'y
            FillTextBoxes();
        }

        /// <summary>
        /// funkcja wypełnia textBox'y danymi danego uzytkownika z tabeli
        /// </summary>
        private void FillTextBoxes()
        {
            //zapytanie
            string query = "SELECT Login,Password,First_Name,Last_Name,Email,Phone FROM Customer WHERE  Customer_ID = @Customer_ID ";
            
            //inicjalizacja połaczenia
            var connection = dbConnectionCinema();
            using (var command = new SqlCommand(query,connection)
)
            {
                //otworzenie polaczenia
                connection.Open();

                //dodanie parametru
                command.Parameters.Add(new SqlParameter("@Customer_ID", CustomerID));
                using (var reader = command.ExecuteReader())
                {
                    list = new List<string>();

                    //przypisanie do listy wartosci klienta
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(0));
                        list.Add(reader.GetString(1));
                        list.Add(reader.GetString(2));
                        list.Add(reader.GetString(3));
                        list.Add(reader.GetString(4));
                        list.Add(reader.GetString(5));
                    }
                    
                    //inicjalizacja danych w text box'ach
                    textBoxProfileLogin.Text = list[0].ToString();
                    textBoxProfilePassword.Text = list[1].ToString();
                    textBoxProfileName.Text = list[2].ToString();
                    textBoxProfileSurname.Text = list[3].ToString();
                    textBoxProfileEmail.Text = list[4].ToString();
                    textBoxProfilePhone.Text = list[5].ToString();



                }
            }
            connection.Close();


            }

        /// <summary>
        /// wcisniecie przycisku zatwierdza zmiany wprowadzone przez nas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonProfileEdit_Click(object sender, EventArgs e)
        {
            //zapytanie
            string query = "UPDATE Customer SET Login=@Login, Password=@Password,First_Name=@First_Name, Last_Name=@Last_Name,Email=@Email,Phone=@Phone WHERE Customer_ID = @Customer_ID ";
            
            //jesli textBox'y które wartosci w tabeli mają not null są puste to nie spełnia warunku 
            if (textBoxProfileLogin.Text != "" && textBoxProfilePassword.Text !="" && textBoxProfileName.Text != "" && textBoxProfileSurname.Text != "")
            {
                var connection = dbConnectionCinema();
                using (var command = new SqlCommand(query, connection)
    )
                {
                    //otworzenei polaczenia
                    connection.Open();

                    //podanie aktualnych parametrow 
                    command.Parameters.Add(new SqlParameter("@Customer_ID", CustomerID));
                    command.Parameters.Add(new SqlParameter("@Login", textBoxProfileLogin.Text));
                    command.Parameters.Add(new SqlParameter("@Password", textBoxProfilePassword.Text));
                    command.Parameters.Add(new SqlParameter("@First_Name", textBoxProfileName.Text));
                    command.Parameters.Add(new SqlParameter("@Last_Name", textBoxProfileSurname.Text));
                    command.Parameters.Add(new SqlParameter("@Email", textBoxProfileEmail.Text));
                    command.Parameters.Add(new SqlParameter("@Phone", textBoxProfilePhone.Text));


                    //wykonanie zapytania
                    command.ExecuteReader();

                    //zamkniecie polaczenia
                    connection.Close();

                    //wypelnienie text boxow
                    FillTextBoxes();
                    MessageBox.Show("Your profile is updated");

                }
                
            }
            else
            {
                MessageBox.Show("Complete the data");
            }
        }
    }
        
   }

