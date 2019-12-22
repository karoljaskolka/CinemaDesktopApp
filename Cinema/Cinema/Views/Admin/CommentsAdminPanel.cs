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

namespace Cinema.Views.Admin
{
    public partial class CommentsAdminPanel : UserControl
    {

        CommentService service = new CommentService();

        public CommentsAdminPanel()
        {
            InitializeComponent();
            buttonDelete.BackColor = Design.BUTTON_DELETE;
        }

        private void buttonSearchByCustomer_Click(object sender, EventArgs e)
        {

            if (textBoxSearchCustomer.Text != "")
            {
                service.GetCommentsByCustomer(dataGridViewComments, textBoxSearchCustomer.Text);
            }
            SetDataGridViewColumnsWidthCustomer(dataGridViewComments);
            ClearInput();
        }

        private void buttonSearchByMovie_Click(object sender, EventArgs e)
        {
            if (textBoxSearchMovie.Text != "")
            {
                service.GetCommentsByMovie(dataGridViewComments, textBoxSearchMovie.Text);
            }
            SetDataGridViewColumnsWidthMovie(dataGridViewComments);
            ClearInput();
        }

        private void SetDataGridViewColumnsWidthCustomer(DataGridView dataGridView)
        {
            try
            {
                DataGridViewColumn column0 = dataGridView.Columns[0];
                DataGridViewColumn column1 = dataGridView.Columns[1];
                DataGridViewColumn column2 = dataGridView.Columns[2];
                DataGridViewColumn column3 = dataGridView.Columns[3];

                column0.HeaderText = "Comment_ID";
                column1.HeaderText = "Customer";
                column2.HeaderText = "Description";
                column3.HeaderText = "Date";

                // set columns width
                column0.Width = 75;
                column1.Width = 175;
                column2.Width = 375;
                column3.Width = 125;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No results has been found");
            }

        }

        private void SetDataGridViewColumnsWidthMovie(DataGridView dataGridView)
        {
            try
            {
                DataGridViewColumn column0 = dataGridView.Columns[0];
                DataGridViewColumn column1 = dataGridView.Columns[1];
                DataGridViewColumn column2 = dataGridView.Columns[2];
                DataGridViewColumn column3 = dataGridView.Columns[3];

                column0.HeaderText = "Comment_ID";
                column1.HeaderText = "Title";
                column2.HeaderText = "Description";
                column3.HeaderText = "Date";

                // set columns width
                column0.Width = 75;
                column1.Width = 175;
                column2.Width = 375;
                column3.Width = 125;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No results has been found");
            }

        }

        private void ClearInput()
        {
            textBoxSearchCustomer.Text = "";
            textBoxSearchMovie.Text = "";
        }

        private void dataGridViewComments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelID.Text = dataGridViewComments.Rows[dataGridViewComments.CurrentCell.RowIndex].Cells[0].Value.ToString();
            labelDescription.Text = dataGridViewComments.Rows[dataGridViewComments.CurrentCell.RowIndex].Cells[2].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To be done ... ");
        }
    }
}
