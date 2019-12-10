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
        //zmienna id klienta
        private int customerID;
        private SqlCommand querySQL;
        //zmienna polaczenia do bazy
        private readonly Func<System.Data.SqlClient.SqlConnection> dbConnectionCinema = () => new SqlConnection(ConfigurationManager.ConnectionStrings["CinemaKredek"].ConnectionString);



        public SqlCommand QuerySQL { get => querySQL; set => querySQL = value; }
       
        public int CustomerID { get => customerID; set => customerID = value; }

        FormMain formMain;

        public SignUpPanel(FormMain formMain)
        {
            InitializeComponent();
            this.formMain=formMain;
            buttonSignUp.BackColor = Color.PeachPuff;
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

                service.SignUp(textBoxSignUpLogin.Text, textBoxSignUpPassword.Text, textBoxSignUpName.Text, textBoxSignUpSurname.Text, dateTimePickerSignUpBirth.Value.ToString("yyyy-MM-dd"), textBoxSignUpEmail.Text, textBoxSignUpPhone.Text);



            }
            else
            {
                MessageBox.Show("Complete the data");
            }
        }
        
    }
}

