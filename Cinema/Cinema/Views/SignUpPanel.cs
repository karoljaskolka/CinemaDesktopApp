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
    public partial class SignUpPanel : UserControl
    {

        FormMain formMain;

        public SignUpPanel(FormMain formMain)
        {
            InitializeComponent();
            this.formMain=formMain;
            buttonSignUp.BackColor = Design.LAUNCHER_BUTTONS; ;
        }

        /// <summary>
        /// tworzenie nowego konta w bazie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            CustomerService service = new CustomerService();

            //jesli textBox'y które wartosci w tabeli mają not null są puste to nie spełnia warunku 

            if (textBoxSignUpLogin.Text != "" && textBoxSignUpPassword.Text != "" && textBoxSignUpName.Text != "" && textBoxSignUpSurname.Text != "")
            {
                if (checkBoxTerms.Checked == false)
                {
                    MessageBox.Show("You have to agree terms");
                }
                else
                {
                    service.SignUp(textBoxSignUpLogin.Text, textBoxSignUpPassword.Text, textBoxSignUpName.Text, textBoxSignUpSurname.Text, dateTimePickerSignUpBirth.Value.ToString("yyyy-MM-dd"), textBoxSignUpEmail.Text, textBoxSignUpPhone.Text);
                    formMain.panelContent.Controls.Clear();
                    LogInPanel panel = new LogInPanel(formMain);
                    formMain.panelContent.Controls.Add(panel);
                }



            }
            else
            {
                MessageBox.Show("Complete the data");
            }
        }
        
    }
}

