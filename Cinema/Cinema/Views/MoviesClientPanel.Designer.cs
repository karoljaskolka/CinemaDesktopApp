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
            this.comboBoxRating.Location = new System.Drawing.Point(711, 529);
            this.comboBoxRating.Name = "comboBoxRating";
            this.comboBoxRating.Size = new System.Drawing.Size(99, 29);
            this.comboBoxRating.TabIndex = 10;
            this.comboBoxRating.ValueMember = "10";
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold);
            this.labelRate.Location = new System.Drawing.Point(705, 439);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(105, 36);
            this.labelRate.TabIndex = 2;
            this.labelRate.Text = "Rate";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold);
            this.labelComment.Location = new System.Drawing.Point(139, 439);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(201, 36);
            this.labelComment.TabIndex = 3;
            this.labelComment.Text = "Comment";
            // 
            // textBoxCommentMovie
            // 
            this.textBoxCommentMovie.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBoxCommentMovie.Font = new System.Drawing.Font("Castellar", 14F);
            this.textBoxCommentMovie.Location = new System.Drawing.Point(123, 504);
            this.textBoxCommentMovie.Multiline = true;
            this.textBoxCommentMovie.Name = "textBoxCommentMovie";
            this.textBoxCommentMovie.Size = new System.Drawing.Size(267, 85);
            this.textBoxCommentMovie.TabIndex = 4;
            // 
            // buttonRate
            // 
            this.buttonRate.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.buttonRate.Location = new System.Drawing.Point(691, 625);
            this.buttonRate.Name = "buttonRate";
            this.buttonRate.Size = new System.Drawing.Size(130, 32);
            this.buttonRate.TabIndex = 5;
            this.buttonRate.Text = "Rate";
            this.buttonRate.UseVisualStyleBackColor = true;
            this.buttonRate.Click += new System.EventHandler(this.buttonRate_Click);
            // 
            // buttonComment
            // 
            this.buttonComment.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.buttonComment.Location = new System.Drawing.Point(171, 625);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(130, 32);
            this.buttonComment.TabIndex = 6;
            this.buttonComment.Text = "Comment";
            this.buttonComment.UseVisualStyleBackColor = true;
            this.buttonComment.Click += new System.EventHandler(this.buttonComment_Click);
            // 
            // labelMovies
            // 
            this.labelMovies.AutoSize = true;
            this.labelMovies.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold);
            this.labelMovies.Location = new System.Drawing.Point(354, 23);
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
            this.dataGridViewMovies.GridColor = System.Drawing.Color.LavenderBlush;
            this.dataGridViewMovies.Location = new System.Drawing.Point(123, 105);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.ReadOnly = true;
            this.dataGridViewMovies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewMovies.RowTemplate.Height = 24;
            this.dataGridViewMovies.Size = new System.Drawing.Size(698, 288);
            this.dataGridViewMovies.TabIndex = 12;
            this.dataGridViewMovies.SelectionChanged += new System.EventHandler(this.dataGridViewMovies_SelectionChanged);
            // 
            // MoviesClientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.dataGridViewMovies);
            this.Controls.Add(this.labelMovies);
            this.Controls.Add(this.buttonComment);
            this.Controls.Add(this.buttonRate);
            this.Controls.Add(this.textBoxCommentMovie);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.comboBoxRating);
            this.Name = "MoviesClientPanel";
            this.Size = new System.Drawing.Size(881, 677);
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
    }
}
