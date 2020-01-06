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
    public partial class ShowtimesAdminPanel : UserControl
    {
        MoviesService moviesService = new MoviesService();
        ShowtimesService showtimesService = new ShowtimesService();

        bool showtimes;

        public ShowtimesAdminPanel()
        {
            InitializeComponent();
            InitData();
            EnableGroupBox();
        }

        private void InitData()
        {
            // display showtimes on init
            showtimesService.GetShowtimes(dataGridViewData);
            SetDataGridViewColumnsWidthShowtimes(dataGridViewData);
            showtimes = true;

            textBoxMovie.Enabled = false;
            textBoxMovieIDEdit.Enabled = false;
            textBoxShowtimeIDEdit.Enabled = false;
            textBoxMovieID.Enabled = false;

            buttonAdd.BackColor = Design.BUTTON_ADD;
            buttonEdit.BackColor = Design.BUTTON_EDIT;

            buttonShowMovies.BackColor = Design.BUTTON_ADD;
            buttonShowShowtimes.BackColor = Design.BUTTON_EDIT;

            comboBoxScreenAdd.Items.Add("1");
            comboBoxScreenAdd.Items.Add("2");
            comboBoxScreenAdd.Items.Add("3");

            comboBoxTechnologyAdd.Items.Add("2D");
            comboBoxTechnologyAdd.Items.Add("3D");

            comboBoxScreenEdit.Items.Add("1");
            comboBoxScreenEdit.Items.Add("2");
            comboBoxScreenEdit.Items.Add("3");

            comboBoxTechnologyEdit.Items.Add("2D");
            comboBoxTechnologyEdit.Items.Add("3D");

            comboBoxScreenAdd.SelectedIndex = -1;
            comboBoxTechnologyAdd.SelectedIndex = -1;

            comboBoxScreenEdit.SelectedIndex = -1;
            comboBoxTechnologyEdit.SelectedIndex = -1;

            dateTimePickerAdd.Format = DateTimePickerFormat.Custom;
            dateTimePickerAdd.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            dateTimePickerAdd.Value = DateTime.Now;

            dateTimePickerEdit.Format = DateTimePickerFormat.Custom;
            dateTimePickerEdit.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            dateTimePickerEdit.Value = new DateTime(2020, 1, 1, 15, 15, 0);
        }

        private void buttonShowShowtimes_Click(object sender, EventArgs e)
        {
            dataGridViewData.DataSource = null;
            showtimesService.GetShowtimes(dataGridViewData);
            SetDataGridViewColumnsWidthShowtimes(dataGridViewData);
            showtimes = true;
            EnableGroupBox();
            ClearInput();
        }

        private void buttonShowMovies_Click(object sender, EventArgs e)
        {
            dataGridViewData.DataSource = null;
            moviesService.GetMovies(dataGridViewData);
            SetDataGridViewColumnsWidthMovies(dataGridViewData);
            showtimes = false;
            EnableGroupBox();
            ClearInput();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxMovieIDEdit.Text == null || comboBoxScreenEdit.SelectedIndex == -1 || comboBoxScreenEdit.SelectedIndex == -1)
            {
                MessageBox.Show("Complete data");
            }
            else
            {

                string date = dateTimePickerEdit.Value.ToString("yyyy-MM-dd HH:mm:ss") + ".000";

                int id = showtimesService.GetShowtimeID(Int32.Parse(comboBoxScreenEdit.SelectedItem.ToString()), date);

                if (id == 0)
                {
                    showtimesService.EditShowtime(Int32.Parse(textBoxShowtimeIDEdit.Text), Int32.Parse(comboBoxScreenEdit.SelectedItem.ToString()),
                        dateTimePickerEdit.Value.ToString("yyyy-MM-dd HH:mm:ss"), comboBoxTechnologyEdit.SelectedItem.ToString());

                    MessageBox.Show("Showtime updated");
                    dataGridViewData.DataSource = null;
                    showtimesService.GetShowtimes(dataGridViewData);
                    SetDataGridViewColumnsWidthShowtimes(dataGridViewData);
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Screen is not available at this time");
                }

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxMovieID.Text == null || comboBoxScreenAdd.SelectedIndex == -1 || comboBoxTechnologyAdd.SelectedIndex == -1)
            {
                MessageBox.Show("Complete data");
            }
            else
            {

                string date = dateTimePickerAdd.Value.ToString("yyyy-MM-dd HH:mm:ss") + ".000";
             
                int id = showtimesService.GetShowtimeID(Int32.Parse(comboBoxScreenAdd.SelectedItem.ToString()), date);

                if (id == 0)
                {
                    showtimesService.AddShowtime(Int32.Parse(textBoxMovieID.Text), Int32.Parse(comboBoxScreenAdd.SelectedItem.ToString()),
                        dateTimePickerAdd.Value.ToString("yyyy-MM-dd HH:mm:ss"), comboBoxTechnologyAdd.SelectedItem.ToString());

                    MessageBox.Show("Showtime added to database");
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Screen is not available at this time");
                }

            }
        }

        private void SetDataGridViewColumnsWidthMovies(DataGridView dataGridView)
        {
            DataGridViewColumn column0 = dataGridView.Columns[0];
            DataGridViewColumn column1 = dataGridView.Columns[1];
            DataGridViewColumn column2 = dataGridView.Columns[2];
            DataGridViewColumn column3 = dataGridView.Columns[3];
            DataGridViewColumn column4 = dataGridView.Columns[4];
            DataGridViewColumn column5 = dataGridView.Columns[5];
            DataGridViewColumn column6 = dataGridView.Columns[6];
            DataGridViewColumn column7 = dataGridView.Columns[7];

            column0.HeaderText = "ID";
            column1.HeaderText = "Movie";
            column3.HeaderText = "Release";
            column4.HeaderText = "Genre";
            column5.HeaderText = "Age";

            // set columns width
            column0.Width = 25;
            column1.Width = 250;
            column2.Width = 125;
            column3.Width = 65;
            column4.Width = 75;
            column5.Width = 35;
            column6.Width = 55;
            column7.Width = 105;
        }

        private void SetDataGridViewColumnsWidthShowtimes(DataGridView dataGridView)
        {
            DataGridViewColumn column0 = dataGridView.Columns[0];
            DataGridViewColumn column1 = dataGridView.Columns[1];
            DataGridViewColumn column2 = dataGridView.Columns[2];
            DataGridViewColumn column3 = dataGridView.Columns[3];
            DataGridViewColumn column4 = dataGridView.Columns[4];
            DataGridViewColumn column5 = dataGridView.Columns[5];

            // set columns width
            column0.Width = 75;
            column1.Width = 75;
            column2.Width = 300;
            column3.Width = 75;
            column4.Width = 125;
            column5.Width = 75;
        }

        private void EnableGroupBox()
        {
            if (showtimes)
            {
                groupBoxEdit.Visible = true;
                groupBoxAdd.Visible = false;
            }
            else
            {
                groupBoxEdit.Visible = false;
                groupBoxAdd.Visible = true;
            }
        }

        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (showtimes)
            {
                textBoxShowtimeIDEdit.Text = dataGridViewData.Rows[dataGridViewData.CurrentCell.RowIndex].Cells[0].Value.ToString();
                textBoxMovieIDEdit.Text = dataGridViewData.Rows[dataGridViewData.CurrentCell.RowIndex].Cells[1].Value.ToString();
                dateTimePickerEdit.Value = DateTime.Parse(dataGridViewData.Rows[dataGridViewData.CurrentCell.RowIndex].Cells[4].Value.ToString());
                comboBoxScreenEdit.Text = dataGridViewData.Rows[dataGridViewData.CurrentCell.RowIndex].Cells[3].Value.ToString();
                comboBoxTechnologyEdit.Text = dataGridViewData.Rows[dataGridViewData.CurrentCell.RowIndex].Cells[5].Value.ToString();

            }
            else
            {
                textBoxMovieID.Text = dataGridViewData.Rows[dataGridViewData.CurrentCell.RowIndex].Cells[0].Value.ToString();
                textBoxMovie.Text = dataGridViewData.Rows[dataGridViewData.CurrentCell.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void ClearInput()
        {
            textBoxMovie.Text = "";
            textBoxMovieID.Text = "";

            textBoxMovieIDEdit.Text = "";
            textBoxShowtimeIDEdit.Text = "";

            comboBoxScreenAdd.SelectedIndex = -1;
            comboBoxTechnologyAdd.SelectedIndex = -1;

            comboBoxScreenEdit.SelectedIndex = -1;
            comboBoxTechnologyEdit.SelectedIndex = -1;

            dateTimePickerAdd.Value = DateTime.Now;
            dateTimePickerEdit.Value = new DateTime(2020, 1, 1, 15, 15, 0);
        }

    }
}
