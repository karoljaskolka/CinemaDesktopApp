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
    public partial class ProfileClientPanel : UserControl
    {
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
            FillTextBoxes();
        }

        private void FillTextBoxes()
        {

            string query = "SELECT Login,Password,First_Name,Last_Name,Email,Phone FROM Customer WHERE  Customer_ID = @Customer_ID ";
            //string query = "SELECT Password,First_Name FROM Customer WHERE  Customer_ID = @Customer_ID ";
            var connection = dbConnectionCinema();
            using (var command = new SqlCommand(query,connection)
)
            {
                connection.Open();


                command.Parameters.Add(new SqlParameter("@Customer_ID", CustomerID));
                using (var reader = command.ExecuteReader())
                {
                    list = new List<string>();

                    
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(0));
                        list.Add(reader.GetString(1));
                        list.Add(reader.GetString(2));
                        list.Add(reader.GetString(3));
                        list.Add(reader.GetString(4));
                        list.Add(reader.GetString(5));
                    }
                    
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

        private void buttonProfileEdit_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Customer SET Login=@Login, Password=@Password,First_Name=@First_Name, Last_Name=@Last_Name,Email=@Email,Phone=@Phone WHERE Customer_ID = @Customer_ID ";

            if (textBoxProfileLogin.Text != "" && textBoxProfilePassword.Text !="" && textBoxProfileName.Text != "" && textBoxProfileSurname.Text != "")
            {
                var connection = dbConnectionCinema();
                using (var command = new SqlCommand(query, connection)
    )
                {
                    connection.Open();

                    command.Parameters.Add(new SqlParameter("@Customer_ID", CustomerID));
                    command.Parameters.Add(new SqlParameter("@Login", textBoxProfileLogin.Text));
                    command.Parameters.Add(new SqlParameter("@Password", textBoxProfilePassword.Text));
                    command.Parameters.Add(new SqlParameter("@First_Name", textBoxProfileName.Text));
                    command.Parameters.Add(new SqlParameter("@Last_Name", textBoxProfileSurname.Text));
                    command.Parameters.Add(new SqlParameter("@Email", textBoxProfileEmail.Text));
                    command.Parameters.Add(new SqlParameter("@Phone", textBoxProfilePhone.Text));



                    command.ExecuteReader();
                    connection.Close();
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

