using DesktopApp.App;
using DesktopApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class LauncherWindow : Form
    {
        public LauncherWindow()
        {
            InitializeComponent();
            SetColors();
        }

        private void SetColors()
        {
            panelContent.BackColor = Design.LAUNCHER_BACKGROUND;
            panelNav.BackColor = Design.LAUNCHER_NAV;
            buttonLogIn.BackColor = Design.LAUNCHER_BUTTONS;
            buttonSignUp.BackColor = Design.LAUNCHER_BUTTONS;
            buttonEmployee.BackColor = Design.LAUNCHER_BUTTONS;
            buttonAdmin.BackColor = Design.LAUNCHER_BUTTONS;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            LogInPanel panel = new LogInPanel();
            panelContent.Controls.Add(panel);

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            SignUpPanel panel = new SignUpPanel();
            panelContent.Controls.Add(panel);
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {

        }
    }

}
