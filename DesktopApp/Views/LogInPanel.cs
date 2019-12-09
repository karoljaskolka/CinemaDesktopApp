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
using DesktopApp.Services;

namespace DesktopApp.Views
{
    public partial class LogInPanel : UserControl
    {

        public int CustomerID { get; set; }

        public LogInPanel()
        {
            InitializeComponent();
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

            AuthenticationService service = new AuthenticationService();
            if (service.SignIn(textBoxLogin.Text, textBoxPassword.Text))
            {
                CustomerID = service.GetCustomerID(textBoxLogin.Text);
                MessageBox.Show("Access Granted :) CustomerID = " + CustomerID);
                textBoxLogin.Clear();
                textBoxPassword.Clear();
            }
            else
            {
                // wyświetlenie informacji
                MessageBox.Show("Wrong login or password");
            }
        }
    }
}
