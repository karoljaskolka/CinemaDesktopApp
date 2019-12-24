using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.Services;

namespace Cinema.Views.Employee
{
    public partial class ComplaintsEmployeePanel : UserControl
    {
        ComplaintService serviceComplaint;

        private int complaintID;
        public int ComplaintID { get => complaintID; set => complaintID = value; }

        public ComplaintsEmployeePanel()
        {
            InitializeComponent();
            serviceComplaint = new ComplaintService();
            GetDataFromTable();
        }

        

        /// <summary>
        /// wypelnienie tabeli danymi z bazy danych
        /// polaczen z baza</summary>
        public void GetDataFromTable()
        {
            serviceComplaint.ShowComplaint(dataGridViewComplaint);


        }


        private void dataGridViewComplaint_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewComplaint.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridViewComplaint.SelectedRows[0];

                //pobieram obecny wiersz
                row = this.dataGridViewComplaint.SelectedRows[0];

                buttonDelete.Visible = true;
                ComplaintID = Convert.ToInt32(row.Cells["ID"].Value.ToString());

                textBoxComplaint.Text = serviceComplaint.ShowDescription(ComplaintID);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {


            serviceComplaint.DeleteComplaintByID(ComplaintID);

            MessageBox.Show("This complaint has been removed.");


            GetDataFromTable();

            textBoxComplaint.Text = "";
            buttonDelete.Visible = false ;
        }
    }
}