using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class MoviesClientPanel : UserControl
    {
        public MoviesClientPanel(int customerID)
        {
            InitializeComponent();
            buttonRate.BackColor = Color.LavenderBlush;
            buttonComment.BackColor = Color.LavenderBlush;
        }

    }
}
