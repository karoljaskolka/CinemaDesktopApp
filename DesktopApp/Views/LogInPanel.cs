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
using DesktopApp.App;

namespace DesktopApp.Views
{
    public partial class LogInPanel : UserControl
    {

        SqlConnection connection;

        public LogInPanel()
        {
            InitializeComponent();
            
            try
            {
                connection = new SqlConnection(App.Environment.DB_SOURCE);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SetColors();
        }

        private void SetColors()
        {
            labelLogin.ForeColor = Design.NAV_BUTTONS_TEXT;
            labelPassword.ForeColor = Design.NAV_BUTTONS_TEXT;
            labelError.ForeColor = Design.NAV_BUTTONS_TEXT;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(
                "SELECT COUNT(*) FROM Customer WHERE login=@Login AND password=@Password", 
                connection);

            adapter.SelectCommand.Parameters.AddWithValue("@Login", textBoxLogin.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@Password", textBoxPassword.Text);

            connection.Open();

            DataTable customers = new DataTable();

            adapter.Fill(customers);

            connection.Close();

            if (customers.Rows.Count > 0)
            {
                if(customers.Rows[0][0].ToString() == "0")
                {
                    labelError.Text = "Wrong login or password. Try again";
                }
                else
                {
                    labelError.Text = "Access granted";
                }
            }

            textBoxPassword.Text = "";
        }
    }
}
