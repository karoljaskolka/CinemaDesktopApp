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
    public partial class LogInEmployeePanel : UserControl
    {
        FormMain formMain;

        public LogInEmployeePanel(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            buttonLogIn.BackColor = Design.LAUNCHER_BUTTONS;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            FormEmployee window = new FormEmployee();
            formMain.Hide();
            window.ShowDialog();
            formMain.Close();
        }
    }
}
