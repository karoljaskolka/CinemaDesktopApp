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
            panelNav.BackColor = Design.EMPLOYEE_NAV;
            panelContent.BackColor = Design.EMPLOYEE_BACKGROUND;
        }

    }
}
