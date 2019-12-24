using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Cinema.Services;

namespace Cinema
{
    public partial class RatingsClientPanel : UserControl
    {
        private int customerID;
        RatingsService service;
        public int CustomerID { get => customerID; set => customerID = value; }
        
        public RatingsClientPanel(int customerID)
        {
            InitializeComponent();
            CustomerID = customerID;
            service = new RatingsService();
            //wypelniam tabele danymi
            SetDataInTable();
            
        }
        /// <summary>
        /// wypelnienie tabeli informazjami z bazy
        /// </summary>
        private void SetDataInTable()
        {

            service.ShowRatings(dataGridViewRatings, CustomerID);

         }
              
              
    }
}
