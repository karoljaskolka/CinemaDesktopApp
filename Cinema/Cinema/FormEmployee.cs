using Cinema.Views.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
            SetColors();
        }

        private void SetColors()
        {
            buttonShowtimes.BackColor = Design.EMPLOYEE_BUTTONS;
            buttonBookings.BackColor = Design.EMPLOYEE_BUTTONS;
            buttonComplaints.BackColor = Design.EMPLOYEE_BUTTONS;
            panelNav.BackColor = Design.EMPLOYEE_NAV;
            panelContent.BackColor = Design.EMPLOYEE_BACKGROUND;
        }

        private void buttonShowtimes_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            ShowtimesEmployeePanel panel = new ShowtimesEmployeePanel();
            panelContent.Controls.Add(panel);
        }

        private void buttonBookings_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            BookingsEmployeePanel panel = new BookingsEmployeePanel();
            panelContent.Controls.Add(panel);
        }

        private void buttonComplaints_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            ComplaintsEmployeePanel panel = new ComplaintsEmployeePanel();
            panelContent.Controls.Add(panel);
        }
    }
}
