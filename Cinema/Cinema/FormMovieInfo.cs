using Cinema.Services;
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
    public partial class FormMovieInfo : Form
    {
        MoviesService service;
        private int movieID;
        public FormMovieInfo(int movieID)
        {
            InitializeComponent();
            service = new MoviesService();
            SetDesign();
            this.movieID = movieID;
            LoadTables();
        }

        private void LoadTables()
        {
            service.ShowAvgRating(dataGridViewRating, movieID);
            service.ShowComments(dataGridViewComments, movieID);
        }

        private void SetDesign()
        {
            labelAvgRating.BackColor = Color.Transparent;
            labelComments.BackColor = Color.Transparent;

            dataGridViewRating.AutoResizeColumns();
            dataGridViewComments.AutoResizeColumns();

            labelAvgRating.ForeColor = Design.FONT_CLIENT;
            labelComments.ForeColor = Design.FONT_CLIENT;

        }
    }
}
