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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            SetColors();
        }

        private void SetColors()
        {
            buttonMovies.BackColor = Design.ADMIN_BUTTONS;
            buttonShowtimes.BackColor = Design.ADMIN_BUTTONS;
            buttonUsers.BackColor = Design.ADMIN_BUTTONS;
            buttonComments.BackColor = Design.ADMIN_BUTTONS;
            panelNav.BackColor = Design.ADMIN_NAV;
            panelContent.BackColor = Design.ADMIN_BACKGROUND;
        }

        private void buttonMovies_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowtimes_Click(object sender, EventArgs e)
        {

        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {

        }

        private void buttonComments_Click(object sender, EventArgs e)
        {

        }
    }
}
