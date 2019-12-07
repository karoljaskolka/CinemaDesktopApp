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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonLogIn.BackColor = Color.PeachPuff;
            buttonSignUp.BackColor = Color.PeachPuff;
            
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            LogInPanel panel = new LogInPanel(this);
            panelContent.Controls.Add(panel);
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            
            panelContent.Controls.Clear();
            SignUpPanel signUpPanel = new SignUpPanel();
            panelContent.Controls.Add(signUpPanel);
        }
    }
}
