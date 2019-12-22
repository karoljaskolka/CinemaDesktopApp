using Cinema.Views;
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
            SetColors();
        }

        private void SetColors()
        {
            buttonLogIn.BackColor = Design.LAUNCHER_BUTTONS;
            buttonSignUp.BackColor = Design.LAUNCHER_BUTTONS;
            buttonEmployee.BackColor = Design.LAUNCHER_BUTTONS;
            buttonAdmin.BackColor = Design.LAUNCHER_BUTTONS;
            panelContent.BackColor = Design.LAUNCHER_BACKGROUND;
            panelButtonsStartWindow.BackColor = Design.LAUNCHER_NAV;
        }

        /// <summary>
        /// przycisk otwiera panel logowania klienta
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
            SignUpPanel panel = new SignUpPanel(this);
            panelContent.Controls.Add(panel);
            
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            LogInEmployeePanel panel = new LogInEmployeePanel(this);
            panelContent.Controls.Add(panel);
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            LogInAdminPanel panel = new LogInAdminPanel(this);
            panelContent.Controls.Add(panel);
        }
    }
}
