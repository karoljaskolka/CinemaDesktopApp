using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.Views
{
    public partial class LogInAdminPanel : UserControl
    {
        FormMain formMain;

        public LogInAdminPanel(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            buttonLogIn.BackColor = Design.LAUNCHER_BUTTONS;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            FormAdmin window = new FormAdmin();
            formMain.Hide();
            window.ShowDialog();
            formMain.Close();
        }
    }
}
