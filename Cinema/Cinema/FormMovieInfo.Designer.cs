namespace Cinema
{
    partial class FormMovieInfo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewRating = new System.Windows.Forms.DataGridView();
            this.dataGridViewComments = new System.Windows.Forms.DataGridView();
            this.labelComments = new System.Windows.Forms.Label();
            this.labelAvgRating = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRating
            // 
            this.dataGridViewRating.AllowUserToAddRows = false;
            this.dataGridViewRating.AllowUserToDeleteRows = false;
            this.dataGridViewRating.AllowUserToResizeColumns = false;
            this.dataGridViewRating.AllowUserToResizeRows = false;
            this.dataGridViewRating.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRating.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRating.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridViewRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRating.GridColor = System.Drawing.Color.LavenderBlush;
            this.dataGridViewRating.Location = new System.Drawing.Point(189, 63);
            this.dataGridViewRating.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRating.MultiSelect = false;
            this.dataGridViewRating.Name = "dataGridViewRating";
            this.dataGridViewRating.ReadOnly = true;
            this.dataGridViewRating.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewRating.RowTemplate.Height = 24;
            this.dataGridViewRating.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewRating.Size = new System.Drawing.Size(438, 83);
            this.dataGridViewRating.TabIndex = 13;
            // 
            // dataGridViewComments
            // 
            this.dataGridViewComments.AllowUserToAddRows = false;
            this.dataGridViewComments.AllowUserToDeleteRows = false;
            this.dataGridViewComments.AllowUserToResizeColumns = false;
            this.dataGridViewComments.AllowUserToResizeRows = false;
            this.dataGridViewComments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewComments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewComments.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridViewComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComments.GridColor = System.Drawing.Color.LavenderBlush;
            this.dataGridViewComments.Location = new System.Drawing.Point(119, 211);
            this.dataGridViewComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewComments.MultiSelect = false;
            this.dataGridViewComments.Name = "dataGridViewComments";
            this.dataGridViewComments.ReadOnly = true;
            this.dataGridViewComments.RowHeadersWidth = 51;
            this.dataGridViewComments.RowTemplate.Height = 24;
            this.dataGridViewComments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewComments.Size = new System.Drawing.Size(575, 228);
            this.dataGridViewComments.TabIndex = 14;
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Font = new System.Drawing.Font("Castellar", 14F, System.Drawing.FontStyle.Bold);
            this.labelComments.Location = new System.Drawing.Point(315, 163);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(175, 29);
            this.labelComments.TabIndex = 15;
            this.labelComments.Text = "Comments";
            // 
            // labelAvgRating
            // 
            this.labelAvgRating.AutoSize = true;
            this.labelAvgRating.Font = new System.Drawing.Font("Castellar", 14F, System.Drawing.FontStyle.Bold);
            this.labelAvgRating.Location = new System.Drawing.Point(286, 19);
            this.labelAvgRating.Name = "labelAvgRating";
            this.labelAvgRating.Size = new System.Drawing.Size(270, 29);
            this.labelAvgRating.TabIndex = 16;
            this.labelAvgRating.Text = "Average rating";
            // 
            // FormMovieInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cinema.Properties.Resources.cinemaPhoto;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAvgRating);
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.dataGridViewComments);
            this.Controls.Add(this.dataGridViewRating);
            this.Name = "FormMovieInfo";
            this.Text = "Informations about movie";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRating;
        private System.Windows.Forms.DataGridView dataGridViewComments;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.Label labelAvgRating;
    }
}