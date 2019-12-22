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
    public partial class MoviesAdminPanel : UserControl
    {
        MoviesService moviesService = new MoviesService();
        GenreService genreService = new GenreService();

        public MoviesAdminPanel()
        {
            InitializeComponent();
            InitData();
            SetColors();
        }

        private void InitData()
        {
            moviesService.GetMovies(dataGridViewMovies);
            SetDataGridViewColumnsWidth(dataGridViewMovies);
            comboBoxGenre.DataSource = genreService.GetGenres();
            comboBoxGenre.ValueMember = "Genre_ID";
            comboBoxGenre.DisplayMember = "Name";
            comboBoxCategory.Items.Add("3");
            comboBoxCategory.Items.Add("12");
            comboBoxCategory.Items.Add("16");
            comboBoxCategory.Items.Add("18");
            textBoxID.Enabled = false;
            VisibleButtons(false);
            buttonAdd.Visible = true;
            ClearInput();
        }

        private void SetColors()
        {
            buttonAdd.BackColor = Design.BUTTON_ADD;
            buttonEdit.BackColor = Design.BUTTON_EDIT;
            buttonDelete.BackColor = Design.BUTTON_DELETE;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxTitle.Text == "" || textBoxDirector.Text == "" || 
                 comboBoxCategory.SelectedIndex == -1 || comboBoxGenre.SelectedIndex == -1)
            {
                MessageBox.Show("Complete data");
            }
            else
            {
                string description = "";

                if (textBoxDescription.Text != null)
                {
                    description = textBoxDescription.Text;
                }

                moviesService.AddMovie(textBoxTitle.Text, textBoxDirector.Text, dateTimePickerRelease.Value.ToString("yyyy-MM-dd"),
                    Int32.Parse(comboBoxGenre.SelectedValue.ToString()),
                    Int32.Parse(comboBoxCategory.SelectedItem.ToString()),
                    Int32.Parse(numericUpDownDuration.Value.ToString()),
                    description);

                MessageBox.Show("Movie added to database");
                ClearInput();

            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "" || textBoxDirector.Text == "" ||
                    comboBoxCategory.SelectedIndex == -1 || comboBoxGenre.SelectedIndex == -1)
            {
                MessageBox.Show("Complete data");
            }
            else
            {
                string description = "";

                if (textBoxDescription.Text != null)
                {
                    description = textBoxDescription.Text;
                }

                moviesService.EditMovie(Int32.Parse(textBoxID.Text), textBoxTitle.Text, textBoxDirector.Text, dateTimePickerRelease.Value.ToString("yyyy-MM-dd"),
                    Int32.Parse(comboBoxGenre.SelectedValue.ToString()),
                    Int32.Parse(comboBoxCategory.SelectedItem.ToString()),
                    Int32.Parse(numericUpDownDuration.Value.ToString()),
                    description);

                MessageBox.Show("Movie edited");
                ClearInput();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            moviesService.DeleteMovie(Int32.Parse(textBoxID.Text));
            MessageBox.Show("Movie deleted from database");
            ClearInput();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearInput();
            VisibleButtons(false);
            buttonAdd.Visible = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(textBoxSearch.Text == ""){
                MessageBox.Show("Enter title or at least one sign");
            }
            else
            {
                moviesService.GetMovieByTitle(dataGridViewMovies, textBoxSearch.Text);
                textBoxSearch.Text = "";
            }

        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            moviesService.GetMovies(dataGridViewMovies);
        }

        private void dataGridViewMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            VisibleButtons(true);
            buttonAdd.Visible = false;

            textBoxID.Text = dataGridViewMovies.Rows[dataGridViewMovies.CurrentCell.RowIndex].Cells[0].Value.ToString();
            textBoxTitle.Text = dataGridViewMovies.Rows[dataGridViewMovies.CurrentCell.RowIndex].Cells[1].Value.ToString();
            textBoxDirector.Text = dataGridViewMovies.Rows[dataGridViewMovies.CurrentCell.RowIndex].Cells[2].Value.ToString();
            dateTimePickerRelease.Value = DateTime.Parse(dataGridViewMovies.Rows[dataGridViewMovies.CurrentCell.RowIndex].Cells[3].Value.ToString());
            comboBoxGenre.Text = dataGridViewMovies.Rows[dataGridViewMovies.CurrentCell.RowIndex].Cells[4].Value.ToString();
            comboBoxCategory.Text = dataGridViewMovies.Rows[dataGridViewMovies.CurrentCell.RowIndex].Cells[5].Value.ToString();
            numericUpDownDuration.Value = Int32.Parse(dataGridViewMovies.Rows[dataGridViewMovies.CurrentCell.RowIndex].Cells[6].Value.ToString());

            // if description != null
            if (dataGridViewMovies.Rows[dataGridViewMovies.CurrentCell.RowIndex].Cells[7].Value != null)
            {
                textBoxDescription.Text = dataGridViewMovies.Rows[dataGridViewMovies.CurrentCell.RowIndex].Cells[7].Value.ToString();
            }

        }

        private void SetDataGridViewColumnsWidth(DataGridView dataGridView)
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

        private void VisibleButtons(bool enable)
        {
            buttonAdd.Visible = enable;
            buttonClear.Visible = enable;
            buttonDelete.Visible = enable;
            buttonEdit.Visible = enable;
        }

        private void ClearInput()
        {
            textBoxID.Text = "";
            textBoxDescription.Text = "";
            textBoxDirector.Text = "";
            dateTimePickerRelease.Value = DateTime.Parse("2020-01-01");
            textBoxTitle.Text = "";
            numericUpDownDuration.Value = 120;
            comboBoxCategory.SelectedIndex = -1;
            comboBoxGenre.SelectedIndex = -1;
            moviesService.GetMovies(dataGridViewMovies);
            VisibleButtons(false);
            buttonAdd.Visible = true;
        }

    }
}
