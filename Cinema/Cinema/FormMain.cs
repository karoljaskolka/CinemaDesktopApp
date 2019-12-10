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
            //koloruuje przyciski
            buttonLogIn.BackColor = Color.PeachPuff;
            buttonSignUp.BackColor = Color.PeachPuff;
            
        }

        /// <summary>
        /// przycisk otwiera panel logowani
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            LogInPanel panel = new LogInPanel(this);
            panelContent.Controls.Add(panel);
        }

        /// <summary>
        /// przycisk otwiera panel tworzenia konta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            
            panelContent.Controls.Clear();
            SignUpPanel signUpPanel = new SignUpPanel(this);
            panelContent.Controls.Add(signUpPanel);
            
        }
    }
}
