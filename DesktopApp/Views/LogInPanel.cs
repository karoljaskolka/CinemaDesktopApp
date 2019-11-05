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

namespace DesktopApp.Views
{
    public partial class LogInPanel : UserControl
    {

        SqlConnection connection;

        public LogInPanel()
        {
            InitializeComponent();

            connection = new SqlConnection(App.Environment.DB_SOURCE);

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name FROM Country", connection);

            DataTable customers = new DataTable();

            adapter.Fill(customers);

            if (customers.Rows.Count > 0)
            {
                labelData.Text = customers.Rows[0][0].ToString();
            }

        }
    }
}
