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
    /// klasa składa skarge na kino lub jego aplikacje
    /// </summary>
    public partial class ReportClientPanel : UserControl
    {
        
        private int customerID;

        //gettery i settery
        public int CustomerID { get => customerID; set => customerID = value; }

        ComplaintService service;

        public ReportClientPanel(int customerID)
        {
            InitializeComponent();
            buttonReport.BackColor = Color.LavenderBlush;
            CustomerID = customerID;
        }

        /// <summary>
        /// po przycisnieciu zostaje złozona skarga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReport_Click(object sender, EventArgs e)
        {
            
             if (textBoxReport.Text != "")
             {
                service = new ComplaintService();
                service.CreateComplaint(CustomerID, textBoxReport.Text);
                MessageBox.Show("Your complaint has been submitted");
                textBoxReport.Text = "";
                 

             }
             else
             {
                 MessageBox.Show("You must write complain above");
             }
        }
    }
}
