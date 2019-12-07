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
    public partial class TicketsClientPanel : UserControl
    {
        public TicketsClientPanel(int customerID)
        {
            InitializeComponent();
            buttonBuyTicket.BackColor = Color.LavenderBlush;
        }
    }
}
