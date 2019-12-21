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

namespace Cinema
{
    

    public partial class MoviesClientPanel : UserControl
    {

        int customerID;
        MoviesService service;
        int movieID;
        public int CustomerID { get => customerID; set => customerID = value; }
        public int MovieID { get => movieID; set => movieID = value; }

        public MoviesClientPanel(int customerID)
        {
            InitializeComponent();
            buttonRate.BackColor = Color.LavenderBlush;
            buttonComment.BackColor = Color.LavenderBlush;

            buttonRate.Enabled = false;
            buttonComment.Enabled = false;

            CustomerID = customerID;

            service = new MoviesService();
            SetMoviesInTable();
        }

        private void SetMoviesInTable()
        {
            service.ShowMovies(dataGridViewMovies);
        }

        private void dataGridViewMovies_SelectionChanged(object sender, EventArgs e)
        {
            //jesli jest cos zaznaczone to wchodzimy w warunek
            if (dataGridViewMovies.SelectedRows.Count != 0)
            {
                //pobranie zaznaczonego wiersza
                DataGridViewRow row = this.dataGridViewMovies.SelectedRows[0];
                
                buttonComment.Enabled = true;
                buttonRate.Enabled = true;

                
                string title = row.Cells["Title"].Value.ToString();
                MovieID = service.GetMovieID(title);

                


                comboBoxRating.SelectedIndex = -1;


            }
        }

        private void buttonRate_Click(object sender, EventArgs e)
        {

            if (service.AlreadyRated(CustomerID,MovieID) == false)
            {


                if (comboBoxRating.SelectedIndex != -1)
                {

                    service.CreateRating(CustomerID, int.Parse(comboBoxRating.SelectedItem.ToString()), MovieID);

                    MessageBox.Show("You rated this film");

                    comboBoxRating.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("First you must choose rating");
                }
            }
            else
            {

                MessageBox.Show("You have already rated this film");


            }
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            if (textBoxCommentMovie.Text != "")
            {

                service.CreateComment(CustomerID, textBoxCommentMovie.Text, MovieID);

                MessageBox.Show("You commented this film");

                textBoxCommentMovie.Text = "";
            }
            else
            {
                MessageBox.Show("First you must write comment");
            }
        }
    }
}
