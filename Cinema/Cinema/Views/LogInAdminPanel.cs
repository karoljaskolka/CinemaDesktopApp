using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.Services;

namespace Cinema.Views
{
    public partial class LogInAdminPanel : UserControl
    {
        FormMain formMain;
        CustomerService service = new CustomerService();

        public LogInAdminPanel(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            SetColors();
        }

        private void SetColors()
        {
            buttonLogIn.BackColor = Design.LAUNCHER_BUTTONS;

            labelLogin.ForeColor = Design.FONT_CLIENT;
            labelPassword.ForeColor = Design.FONT_CLIENT;
            labelKey.ForeColor = Design.FONT_CLIENT;

            labelLogin.BackColor = Color.Transparent;
            labelPassword.BackColor = Color.Transparent;
            labelKey.BackColor = Color.Transparent;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if(service.LogIn(textBoxLogin.Text, textBoxPassword.Text, 3) 
                && textBoxKey.Text == "youshallnotpass")
            {
                FormAdmin window = new FormAdmin();
                formMain.Hide();
                window.ShowDialog();
                formMain.Close();
            }
            else
            {
                MessageBox.Show("Invalid data provided");
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
                textBoxKey.Text = "";
            }
        }
    }
}
