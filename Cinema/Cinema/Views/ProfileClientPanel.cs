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
    /// <summary>
    /// klasa pozwalajaca na edycji swojego konta
    /// </summary>
    public partial class ProfileClientPanel : UserControl
    {
           private int customerID;

        public int CustomerID { get => customerID; set => customerID = value; }
       
        CustomerService service;

        public ProfileClientPanel(int customerID)
        {
            InitializeComponent();
            buttonProfileEdit.BackColor = Color.LavenderBlush;
            CustomerID = customerID;
            SetDesign();

            //wypełniam textBox'y
            FillTextBoxes();
        }


        private void SetDesign()
        {

            labelProfileLogin.ForeColor = Design.FONT_CLIENT;
            labelProfileName.ForeColor = Design.FONT_CLIENT;
            labelProfileEmail.ForeColor = Design.FONT_CLIENT;
            labelProfilePassword.ForeColor = Design.FONT_CLIENT;
            labelProfilePhone.ForeColor = Design.FONT_CLIENT;
            labelProfileSurname.ForeColor = Design.FONT_CLIENT;

            
            

            labelProfileLogin.BackColor = Color.Transparent;
            labelProfileName.BackColor = Color.Transparent;
            labelProfileEmail.BackColor = Color.Transparent;
            labelProfilePassword.BackColor = Color.Transparent;
            labelProfilePhone.BackColor = Color.Transparent;
            labelProfileSurname.BackColor = Color.Transparent;

            buttonProfileEdit.BackColor = Design.CLIENT_BUTTONS_BACKCOLOR;
            buttonProfileEdit.ForeColor = Design.CLIENT_BUTTONS_FORECOLOR;

        }

        /// <summary>
        /// funkcja wypełnia textBox'y danymi danego uzytkownika z tabeli
        /// </summary>
        private void FillTextBoxes()
        {
            service = new CustomerService();
            
            
                    
             //inicjalizacja danych w text box'ach
             textBoxProfileLogin.Text = service.GetLogin(CustomerID);
             textBoxProfilePassword.Text = service.GetPassword(CustomerID);
             textBoxProfileName.Text = service.GetName(CustomerID);
             textBoxProfileSurname.Text = service.GetSurname(CustomerID);
             textBoxProfileEmail.Text = service.GetEmail(CustomerID);
             textBoxProfilePhone.Text = service.GetPhone(CustomerID);

        }
            

        /// <summary>
        /// wcisniecie przycisku zatwierdza zmiany wprowadzone przez nas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonProfileEdit_Click(object sender, EventArgs e)
        {
            
            //jesli textBox'y które wartosci w tabeli mają not null są puste to nie spełnia warunku 
            if (textBoxProfileLogin.Text != "" && textBoxProfilePassword.Text !="" && textBoxProfileName.Text != "" && textBoxProfileSurname.Text != "")
            {
                service = new CustomerService();

                service.SetLogin(CustomerID, textBoxProfileLogin.Text);
                service.SetPassword(CustomerID, textBoxProfilePassword.Text);
                service.SetName(CustomerID, textBoxProfileName.Text);
                service.SetSurname(CustomerID, textBoxProfileSurname.Text);
                service.SetEmail(CustomerID, textBoxProfileEmail.Text);
                service.SetPhone(CustomerID, textBoxProfilePhone.Text);



                //wypelnienie text boxow
                FillTextBoxes();
                MessageBox.Show("Your profile is updated");

                
                
            }
            else
            {
                MessageBox.Show("Complete the data");
            }
        }
    }
        
   }

