namespace Cinema
{
    partial class RatingsClientPanel
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
            this.dataGridViewRatings = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRatings)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRatings
            // 
            this.dataGridViewRatings.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewRatings.AllowUserToAddRows = false;
            this.dataGridViewRatings.AllowUserToDeleteRows = false;
            this.dataGridViewRatings.AllowUserToResizeColumns = false;
            this.dataGridViewRatings.AllowUserToResizeRows = false;
            this.dataGridViewRatings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRatings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewRatings.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridViewRatings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRatings.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewRatings.GridColor = System.Drawing.Color.Gold;
            this.dataGridViewRatings.Location = new System.Drawing.Point(201, 114);
            this.dataGridViewRatings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRatings.MultiSelect = false;
            this.dataGridViewRatings.Name = "dataGridViewRatings";
            this.dataGridViewRatings.ReadOnly = true;
            this.dataGridViewRatings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewRatings.RowTemplate.Height = 24;
            this.dataGridViewRatings.Size = new System.Drawing.Size(595, 482);
            this.dataGridViewRatings.TabIndex = 0;
            // 
            // RatingsClientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::Cinema.Properties.Resources.cinemaPhoto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dataGridViewRatings);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RatingsClientPanel";
            this.Size = new System.Drawing.Size(933, 738);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRatings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRatings;
    }
}
