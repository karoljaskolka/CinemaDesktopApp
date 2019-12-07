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
            this.listBoxMovies = new System.Windows.Forms.ListBox();
            this.comboBoxRating = new System.Windows.Forms.ComboBox();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonRate = new System.Windows.Forms.Button();
            this.buttonComment = new System.Windows.Forms.Button();
            this.labelWatchedMovies = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxMovies
            // 
            this.listBoxMovies.FormattingEnabled = true;
            this.listBoxMovies.ItemHeight = 16;
            this.listBoxMovies.Location = new System.Drawing.Point(216, 108);
            this.listBoxMovies.Name = "listBoxMovies";
            this.listBoxMovies.Size = new System.Drawing.Size(494, 196);
            this.listBoxMovies.TabIndex = 0;
            // 
            // comboBoxRating
            // 
            this.comboBoxRating.DisplayMember = "1";
            this.comboBoxRating.FormattingEnabled = true;
            this.comboBoxRating.ItemHeight = 16;
            this.comboBoxRating.Location = new System.Drawing.Point(354, 648);
            this.comboBoxRating.Name = "comboBoxRating";
            this.comboBoxRating.Size = new System.Drawing.Size(38, 24);
            this.comboBoxRating.TabIndex = 10;
            this.comboBoxRating.ValueMember = "10";
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold);
            this.labelRate.Location = new System.Drawing.Point(428, 582);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(105, 36);
            this.labelRate.TabIndex = 2;
            this.labelRate.Text = "Rate";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold);
            this.labelComment.Location = new System.Drawing.Point(387, 344);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(201, 36);
            this.labelComment.TabIndex = 3;
            this.labelComment.Text = "Comment";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 413);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 85);
            this.textBox1.TabIndex = 4;
            // 
            // buttonRate
            // 
            this.buttonRate.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.buttonRate.Location = new System.Drawing.Point(488, 642);
            this.buttonRate.Name = "buttonRate";
            this.buttonRate.Size = new System.Drawing.Size(130, 32);
            this.buttonRate.TabIndex = 5;
            this.buttonRate.Text = "Rate";
            this.buttonRate.UseVisualStyleBackColor = true;
            // 
            // buttonComment
            // 
            this.buttonComment.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.buttonComment.Location = new System.Drawing.Point(488, 520);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(130, 32);
            this.buttonComment.TabIndex = 6;
            this.buttonComment.Text = "Comment";
            this.buttonComment.UseVisualStyleBackColor = true;
            // 
            // labelWatchedMovies
            // 
            this.labelWatchedMovies.AutoSize = true;
            this.labelWatchedMovies.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold);
            this.labelWatchedMovies.Location = new System.Drawing.Point(226, 57);
            this.labelWatchedMovies.Name = "labelWatchedMovies";
            this.labelWatchedMovies.Size = new System.Drawing.Size(446, 48);
            this.labelWatchedMovies.TabIndex = 11;
            this.labelWatchedMovies.Text = "Watched movies";
            // 
            // MoviesClientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.labelWatchedMovies);
            this.Controls.Add(this.buttonComment);
            this.Controls.Add(this.buttonRate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.comboBoxRating);
            this.Controls.Add(this.listBoxMovies);
            this.Name = "MoviesClientPanel";
            this.Size = new System.Drawing.Size(717, 677);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMovies;
        private System.Windows.Forms.ComboBox comboBoxRating;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRate;
        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.Label labelWatchedMovies;
    }
}
