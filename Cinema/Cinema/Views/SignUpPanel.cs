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
            SetColors();
        }

        private void SetColors()
        {
            buttonSignUp.BackColor = Design.LAUNCHER_BUTTONS;

            labelSignUpLogin.ForeColor = Design.FONT_CLIENT;
            labelSignUpPassword.ForeColor = Design.FONT_CLIENT;
            labelSignUpEmail.ForeColor = Design.FONT_CLIENT;
            labelSignUpPhone.ForeColor = Design.FONT_CLIENT;
            labelSignUpName.ForeColor = Design.FONT_CLIENT;
            labelSignUpSurname.ForeColor = Design.FONT_CLIENT;
            labelSignUpBirth.ForeColor = Design.FONT_CLIENT;
            checkBoxTerms.ForeColor = Design.FONT_CLIENT;

            labelSignUpLogin.BackColor = Color.Transparent;
            labelSignUpPassword.BackColor = Color.Transparent;
            labelSignUpName.BackColor = Color.Transparent;
            labelSignUpPhone.BackColor = Color.Transparent;
            labelSignUpEmail.BackColor = Color.Transparent;
            labelSignUpSurname.BackColor = Color.Transparent;
            labelSignUpBirth.BackColor = Color.Transparent;
            checkBoxTerms.BackColor = Color.Transparent;
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

            if (textBoxSignUpLogin.Text != "" && textBoxSignUpPassword.Text != "" 
                && textBoxSignUpName.Text != "" && textBoxSignUpSurname.Text != "")
            {
                if (checkBoxTerms.Checked == false)
                {
                    MessageBox.Show("You have to agree terms");
                }
                else
                {
                    service.SignUp(textBoxSignUpLogin.Text, textBoxSignUpPassword.Text, 
                        textBoxSignUpName.Text, textBoxSignUpSurname.Text, 
                        dateTimePickerSignUpBirth.Value.ToString("yyyy-MM-dd"), textBoxSignUpEmail.Text, 
                        textBoxSignUpPhone.Text);
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

