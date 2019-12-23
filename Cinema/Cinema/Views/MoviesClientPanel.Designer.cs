namespace Cinema
{
    partial class MoviesClientPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxRating = new System.Windows.Forms.ComboBox();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxCommentMovie = new System.Windows.Forms.TextBox();
            this.buttonRate = new System.Windows.Forms.Button();
            this.buttonComment = new System.Windows.Forms.Button();
            this.labelMovies = new System.Windows.Forms.Label();
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTitleOfMovie = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxRating
            // 
            this.comboBoxRating.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboBoxRating.DisplayMember = "1";
            this.comboBoxRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRating.Font = new System.Drawing.Font("Castellar", 10F);
            this.comboBoxRating.ItemHeight = 21;
            this.comboBoxRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxRating.Location = new System.Drawing.Point(691, 625);
            this.comboBoxRating.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxRating.Name = "comboBoxRating";
            this.comboBoxRating.Size = new System.Drawing.Size(99, 29);
            this.comboBoxRating.TabIndex = 10;
            this.comboBoxRating.ValueMember = "10";
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold);
            this.labelRate.Location = new System.Drawing.Point(685, 565);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(105, 36);
            this.labelRate.TabIndex = 2;
            this.labelRate.Text = "Rate";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold);
            this.labelComment.Location = new System.Drawing.Point(162, 565);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(201, 36);
            this.labelComment.TabIndex = 3;
            this.labelComment.Text = "Comment";
            // 
            // textBoxCommentMovie
            // 
            this.textBoxCommentMovie.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxCommentMovie.Font = new System.Drawing.Font("Castellar", 8F);
            this.textBoxCommentMovie.Location = new System.Drawing.Point(129, 603);
            this.textBoxCommentMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCommentMovie.Multiline = true;
            this.textBoxCommentMovie.Name = "textBoxCommentMovie";
            this.textBoxCommentMovie.Size = new System.Drawing.Size(267, 85);
            this.textBoxCommentMovie.TabIndex = 4;
            // 
            // buttonRate
            // 
            this.buttonRate.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.buttonRate.Location = new System.Drawing.Point(680, 693);
            this.buttonRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRate.Name = "buttonRate";
            this.buttonRate.Size = new System.Drawing.Size(131, 32);
            this.buttonRate.TabIndex = 5;
            this.buttonRate.Text = "Rate";
            this.buttonRate.UseVisualStyleBackColor = true;
            this.buttonRate.Click += new System.EventHandler(this.buttonRate_Click);
            // 
            // buttonComment
            // 
            this.buttonComment.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.buttonComment.Location = new System.Drawing.Point(191, 693);
            this.buttonComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(131, 32);
            this.buttonComment.TabIndex = 6;
            this.buttonComment.Text = "Comment";
            this.buttonComment.UseVisualStyleBackColor = true;
            this.buttonComment.Click += new System.EventHandler(this.buttonComment_Click);
            // 
            // labelMovies
            // 
            this.labelMovies.AutoSize = true;
            this.labelMovies.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold);
            this.labelMovies.Location = new System.Drawing.Point(376, 65);
            this.labelMovies.Name = "labelMovies";
            this.labelMovies.Size = new System.Drawing.Size(193, 48);
            this.labelMovies.TabIndex = 11;
            this.labelMovies.Text = "Movies";
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.AllowUserToAddRows = false;
            this.dataGridViewMovies.AllowUserToDeleteRows = false;
            this.dataGridViewMovies.AllowUserToResizeColumns = false;
            this.dataGridViewMovies.AllowUserToResizeRows = false;
            this.dataGridViewMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMovies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMovies.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.GridColor = System.Drawing.Color.Gold;
            this.dataGridViewMovies.Location = new System.Drawing.Point(129, 149);
            this.dataGridViewMovies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.ReadOnly = true;
            this.dataGridViewMovies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewMovies.RowTemplate.Height = 24;
            this.dataGridViewMovies.Size = new System.Drawing.Size(699, 288);
            this.dataGridViewMovies.TabIndex = 12;
            this.dataGridViewMovies.SelectionChanged += new System.EventHandler(this.dataGridViewMovies_SelectionChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Castellar", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(124, 452);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(97, 29);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Title:";
            // 
            // labelTitleOfMovie
            // 
            this.labelTitleOfMovie.AutoSize = true;
            this.labelTitleOfMovie.Font = new System.Drawing.Font("Castellar", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitleOfMovie.Location = new System.Drawing.Point(230, 452);
            this.labelTitleOfMovie.Name = "labelTitleOfMovie";
            this.labelTitleOfMovie.Size = new System.Drawing.Size(0, 29);
            this.labelTitleOfMovie.TabIndex = 14;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.buttonInfo.Location = new System.Drawing.Point(390, 499);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(179, 45);
            this.buttonInfo.TabIndex = 15;
            this.buttonInfo.Text = "Informations";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // MoviesClientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::Cinema.Properties.Resources.cinemaPhoto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.labelTitleOfMovie);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dataGridViewMovies);
            this.Controls.Add(this.labelMovies);
            this.Controls.Add(this.buttonComment);
            this.Controls.Add(this.buttonRate);
            this.Controls.Add(this.textBoxCommentMovie);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.comboBoxRating);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MoviesClientPanel";
            this.Size = new System.Drawing.Size(933, 738);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxRating;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.TextBox textBoxCommentMovie;
        private System.Windows.Forms.Button buttonRate;
        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.Label labelMovies;
        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTitleOfMovie;
        private System.Windows.Forms.Button buttonInfo;
    }
}
