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
    public partial class LogInPanel : UserControl
    {
        FormMain formMain;
        private int customerID;
        public LogInPanel(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            buttonLogInAccept.BackColor = Color.PeachPuff;
        }

        private void buttonLogInAccept_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn(textBoxLogin.Text, textBoxPassword.Text);
            //FormWarehouse formWarehouse = new FormWarehouse();
            if (logIn.LogInCinema())
            {
                MessageBox.Show("Login succeeded");
                formMain.Hide();
                customerID=logIn.CustomerID;
                FormClient formClient = new FormClient(1);
                //FormClient formClient = new FormClient(customerID);
                formClient.FormClosed += (s, args) => formMain.Close();
                formClient.Show();
            }
            else
            {
                formMain.Hide();
                FormClient formClient = new FormClient(1);
                //FormClient formClient = new FormClient(customerID);
                formClient.FormClosed += (s, args) => formMain.Close();
                formClient.Show();
                MessageBox.Show("Invalid data provided");
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
            }
            
            

        }
    }
}
