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
using Cinema.Database;

namespace Cinema.Views.Admin
{
    public partial class UsersAdminPanel : UserControl
    {

        CustomerService service = new CustomerService();
        Customer user;

        public UsersAdminPanel()
        {
            InitializeComponent();
            EnableTextBox(false);
            buttonDelete.BackColor = Design.BUTTON_DELETE;
            buttonDelete.Enabled = false;
        }

        private void EnableTextBox(bool enable)
        {
            textBoxBirth.Enabled = enable;
            textBoxEmail.Enabled = enable;
            textBoxFirstName.Enabled = enable;
            textBoxID.Enabled = enable;
            textBoxLastName.Enabled = enable;
            textBoxLogin.Enabled = enable;
            textBoxPhone.Enabled = enable;
            textBoxRole.Enabled = enable;
        }

        private void ClearTextBox()
        {
            textBoxBirth.Text = "";
            textBoxEmail.Text = "";
            textBoxFirstName.Text = "";
            textBoxID.Text = "";
            textBoxLastName.Text = "";
            textBoxLogin.Text = "";
            textBoxPhone.Text = "";
            textBoxRole.Text = "";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(textBoxSearch.Text != "")
            {
                user = service.GetCustomer(textBoxSearch.Text);

                if (user != null)
                {
                    textBoxBirth.Text = user.Birth.ToString();
                    textBoxEmail.Text = user.Email;
                    textBoxFirstName.Text = user.First_Name;
                    textBoxID.Text = user.Customer_ID.ToString();
                    textBoxLastName.Text = user.Last_Name;
                    textBoxLogin.Text = user.Login;
                    textBoxPhone.Text = user.Phone;
                    textBoxRole.Text = user.Role_ID.ToString();
                    buttonDelete.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Not Found!");
                    buttonDelete.Enabled = false;
                    ClearTextBox();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            service.DeleteCustomer(Int32.Parse(textBoxID.Text));
            ClearTextBox();
            MessageBox.Show("User deleted!");
        }
    }
}
