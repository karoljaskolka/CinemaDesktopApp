namespace Cinema.Views.Admin
{
    partial class CommentsAdminPanel
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
            this.dataGridViewComments = new System.Windows.Forms.DataGridView();
            this.buttonSearchByCustomer = new System.Windows.Forms.Button();
            this.textBoxSearchCustomer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSearchByMovie = new System.Windows.Forms.Button();
            this.textBoxSearchMovie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewComments
            // 
            this.dataGridViewComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComments.Location = new System.Drawing.Point(26, 142);
            this.dataGridViewComments.Name = "dataGridViewComments";
            this.dataGridViewComments.RowHeadersVisible = false;
            this.dataGridViewComments.RowTemplate.Height = 24;
            this.dataGridViewComments.Size = new System.Drawing.Size(1012, 251);
            this.dataGridViewComments.TabIndex = 0;
            this.dataGridViewComments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewComments_CellClick);
            // 
            // buttonSearchByCustomer
            // 
            this.buttonSearchByCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearchByCustomer.Location = new System.Drawing.Point(753, 27);
            this.buttonSearchByCustomer.Name = "buttonSearchByCustomer";
            this.buttonSearchByCustomer.Size = new System.Drawing.Size(108, 31);
            this.buttonSearchByCustomer.TabIndex = 22;
            this.buttonSearchByCustomer.Text = "Search";
            this.buttonSearchByCustomer.UseVisualStyleBackColor = true;
            this.buttonSearchByCustomer.Click += new System.EventHandler(this.buttonSearchByCustomer_Click);
            // 
            // textBoxSearchCustomer
            // 
            this.textBoxSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearchCustomer.Location = new System.Drawing.Point(402, 29);
            this.textBoxSearchCustomer.Name = "textBoxSearchCustomer";
            this.textBoxSearchCustomer.Size = new System.Drawing.Size(308, 26);
            this.textBoxSearchCustomer.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(243, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Customer Login: ";
            // 
            // buttonSearchByMovie
            // 
            this.buttonSearchByMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSearchByMovie.Location = new System.Drawing.Point(753, 83);
            this.buttonSearchByMovie.Name = "buttonSearchByMovie";
            this.buttonSearchByMovie.Size = new System.Drawing.Size(108, 31);
            this.buttonSearchByMovie.TabIndex = 25;
            this.buttonSearchByMovie.Text = "Search";
            this.buttonSearchByMovie.UseVisualStyleBackColor = true;
            this.buttonSearchByMovie.Click += new System.EventHandler(this.buttonSearchByMovie_Click);
            // 
            // textBoxSearchMovie
            // 
            this.textBoxSearchMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearchMovie.Location = new System.Drawing.Point(402, 85);
            this.textBoxSearchMovie.Name = "textBoxSearchMovie";
            this.textBoxSearchMovie.Size = new System.Drawing.Size(308, 26);
            this.textBoxSearchMovie.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(243, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Movie Title : ";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(395, 163);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(91, 34);
            this.buttonDelete.TabIndex = 26;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDescription);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Location = new System.Drawing.Point(320, 433);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 215);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comment";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDescription.Location = new System.Drawing.Point(149, 100);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(0, 20);
            this.labelDescription.TabIndex = 31;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelID.Location = new System.Drawing.Point(146, 52);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 20);
            this.labelID.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "ID";
            // 
            // CommentsAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSearchByMovie);
            this.Controls.Add(this.textBoxSearchMovie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearchByCustomer);
            this.Controls.Add(this.textBoxSearchCustomer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridViewComments);
            this.Name = "CommentsAdminPanel";
            this.Size = new System.Drawing.Size(1062, 753);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewComments;
        private System.Windows.Forms.Button buttonSearchByCustomer;
        private System.Windows.Forms.TextBox textBoxSearchCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSearchByMovie;
        private System.Windows.Forms.TextBox textBoxSearchMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
