using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class ReportClientPanel : UserControl
    {
        public ReportClientPanel(int customerID)
        {
            InitializeComponent();
            buttonReport.BackColor = Color.LavenderBlush;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            /* string query = "UPDATE Customer SET Login=@Login, Password=@Password,First_Name=@First_Name, Last_Name=@Last_Name,Email=@Email,Phone=@Phone WHERE Customer_ID = @Customer_ID ";

             if (textBoxProfileLogin.Text != "" && textBoxProfilePassword.Text != "" && textBoxProfileName.Text != "" && textBoxProfileSurname.Text != "")
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
             }*/
        }
    }
}
