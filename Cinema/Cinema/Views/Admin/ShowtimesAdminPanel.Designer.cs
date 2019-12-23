namespace Cinema.Views.Admin
{
    partial class ShowtimesAdminPanel
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
            this.buttonShowMovies = new System.Windows.Forms.Button();
            this.buttonShowShowtimes = new System.Windows.Forms.Button();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.textBoxMovieIDEdit = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerEdit = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxScreenEdit = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxTechnologyEdit = new System.Windows.Forms.ComboBox();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.textBoxMovieID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTimePickerAdd = new System.Windows.Forms.DateTimePicker();
            this.textBoxMovie = new System.Windows.Forms.TextBox();
            this.comboBoxScreenAdd = new System.Windows.Forms.ComboBox();
            this.comboBoxTechnologyAdd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxShowtimeIDEdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.groupBoxEdit.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShowMovies
            // 
            this.buttonShowMovies.Location = new System.Drawing.Point(635, 34);
            this.buttonShowMovies.Name = "buttonShowMovies";
            this.buttonShowMovies.Size = new System.Drawing.Size(110, 45);
            this.buttonShowMovies.TabIndex = 0;
            this.buttonShowMovies.Text = "Movies";
            this.buttonShowMovies.UseVisualStyleBackColor = true;
            this.buttonShowMovies.Click += new System.EventHandler(this.buttonShowMovies_Click);
            // 
            // buttonShowShowtimes
            // 
            this.buttonShowShowtimes.Location = new System.Drawing.Point(342, 34);
            this.buttonShowShowtimes.Name = "buttonShowShowtimes";
            this.buttonShowShowtimes.Size = new System.Drawing.Size(110, 45);
            this.buttonShowShowtimes.TabIndex = 1;
            this.buttonShowShowtimes.Text = "Showtimes";
            this.buttonShowShowtimes.UseVisualStyleBackColor = true;
            this.buttonShowShowtimes.Click += new System.EventHandler(this.buttonShowShowtimes_Click);
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            this.dataGridViewData.AllowUserToResizeColumns = false;
            this.dataGridViewData.AllowUserToResizeRows = false;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(26, 108);
            this.dataGridViewData.MultiSelect = false;
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.RowHeadersVisible = false;
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.ShowEditingIcon = false;
            this.dataGridViewData.Size = new System.Drawing.Size(1010, 283);
            this.dataGridViewData.TabIndex = 2;
            this.dataGridViewData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellClick);
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.textBoxShowtimeIDEdit);
            this.groupBoxEdit.Controls.Add(this.label7);
            this.groupBoxEdit.Controls.Add(this.textBoxMovieIDEdit);
            this.groupBoxEdit.Controls.Add(this.buttonEdit);
            this.groupBoxEdit.Controls.Add(this.label5);
            this.groupBoxEdit.Controls.Add(this.label10);
            this.groupBoxEdit.Controls.Add(this.dateTimePickerEdit);
            this.groupBoxEdit.Controls.Add(this.label11);
            this.groupBoxEdit.Controls.Add(this.comboBoxScreenEdit);
            this.groupBoxEdit.Controls.Add(this.label9);
            this.groupBoxEdit.Controls.Add(this.comboBoxTechnologyEdit);
            this.groupBoxEdit.Location = new System.Drawing.Point(26, 414);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(492, 316);
            this.groupBoxEdit.TabIndex = 3;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edit";
            // 
            // textBoxMovieIDEdit
            // 
            this.textBoxMovieIDEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMovieIDEdit.Location = new System.Drawing.Point(134, 88);
            this.textBoxMovieIDEdit.Name = "textBoxMovieIDEdit";
            this.textBoxMovieIDEdit.Size = new System.Drawing.Size(343, 26);
            this.textBoxMovieIDEdit.TabIndex = 14;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(347, 256);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(89, 42);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Movie_ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(6, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Date";
            // 
            // dateTimePickerEdit
            // 
            this.dateTimePickerEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerEdit.Location = new System.Drawing.Point(134, 135);
            this.dateTimePickerEdit.Name = "dateTimePickerEdit";
            this.dateTimePickerEdit.Size = new System.Drawing.Size(343, 26);
            this.dateTimePickerEdit.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(6, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Screen";
            // 
            // comboBoxScreenEdit
            // 
            this.comboBoxScreenEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxScreenEdit.FormattingEnabled = true;
            this.comboBoxScreenEdit.Location = new System.Drawing.Point(134, 186);
            this.comboBoxScreenEdit.Name = "comboBoxScreenEdit";
            this.comboBoxScreenEdit.Size = new System.Drawing.Size(121, 28);
            this.comboBoxScreenEdit.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(6, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Technology";
            // 
            // comboBoxTechnologyEdit
            // 
            this.comboBoxTechnologyEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxTechnologyEdit.FormattingEnabled = true;
            this.comboBoxTechnologyEdit.Location = new System.Drawing.Point(134, 239);
            this.comboBoxTechnologyEdit.Name = "comboBoxTechnologyEdit";
            this.comboBoxTechnologyEdit.Size = new System.Drawing.Size(121, 28);
            this.comboBoxTechnologyEdit.TabIndex = 17;
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.textBoxMovieID);
            this.groupBoxAdd.Controls.Add(this.label6);
            this.groupBoxAdd.Controls.Add(this.buttonAdd);
            this.groupBoxAdd.Controls.Add(this.dateTimePickerAdd);
            this.groupBoxAdd.Controls.Add(this.textBoxMovie);
            this.groupBoxAdd.Controls.Add(this.comboBoxScreenAdd);
            this.groupBoxAdd.Controls.Add(this.comboBoxTechnologyAdd);
            this.groupBoxAdd.Controls.Add(this.label4);
            this.groupBoxAdd.Controls.Add(this.label3);
            this.groupBoxAdd.Controls.Add(this.label2);
            this.groupBoxAdd.Controls.Add(this.label1);
            this.groupBoxAdd.Location = new System.Drawing.Point(544, 414);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(492, 316);
            this.groupBoxAdd.TabIndex = 4;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Add";
            // 
            // textBoxMovieID
            // 
            this.textBoxMovieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMovieID.Location = new System.Drawing.Point(143, 48);
            this.textBoxMovieID.Name = "textBoxMovieID";
            this.textBoxMovieID.Size = new System.Drawing.Size(121, 26);
            this.textBoxMovieID.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(15, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "MovieID";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(377, 251);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(89, 42);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dateTimePickerAdd
            // 
            this.dateTimePickerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerAdd.Location = new System.Drawing.Point(143, 141);
            this.dateTimePickerAdd.Name = "dateTimePickerAdd";
            this.dateTimePickerAdd.Size = new System.Drawing.Size(343, 26);
            this.dateTimePickerAdd.TabIndex = 7;
            // 
            // textBoxMovie
            // 
            this.textBoxMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMovie.Location = new System.Drawing.Point(143, 94);
            this.textBoxMovie.Name = "textBoxMovie";
            this.textBoxMovie.Size = new System.Drawing.Size(343, 26);
            this.textBoxMovie.TabIndex = 6;
            // 
            // comboBoxScreenAdd
            // 
            this.comboBoxScreenAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxScreenAdd.FormattingEnabled = true;
            this.comboBoxScreenAdd.Location = new System.Drawing.Point(143, 191);
            this.comboBoxScreenAdd.Name = "comboBoxScreenAdd";
            this.comboBoxScreenAdd.Size = new System.Drawing.Size(121, 28);
            this.comboBoxScreenAdd.TabIndex = 5;
            // 
            // comboBoxTechnologyAdd
            // 
            this.comboBoxTechnologyAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxTechnologyAdd.FormattingEnabled = true;
            this.comboBoxTechnologyAdd.Location = new System.Drawing.Point(143, 236);
            this.comboBoxTechnologyAdd.Name = "comboBoxTechnologyAdd";
            this.comboBoxTechnologyAdd.Size = new System.Drawing.Size(121, 28);
            this.comboBoxTechnologyAdd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(15, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Technology";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Movie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Screen";
            // 
            // textBoxShowtimeIDEdit
            // 
            this.textBoxShowtimeIDEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxShowtimeIDEdit.Location = new System.Drawing.Point(134, 42);
            this.textBoxShowtimeIDEdit.Name = "textBoxShowtimeIDEdit";
            this.textBoxShowtimeIDEdit.Size = new System.Drawing.Size(343, 26);
            this.textBoxShowtimeIDEdit.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Showtime_ID";
            // 
            // ShowtimesAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.buttonShowShowtimes);
            this.Controls.Add(this.buttonShowMovies);
            this.Name = "ShowtimesAdminPanel";
            this.Size = new System.Drawing.Size(1062, 753);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowMovies;
        private System.Windows.Forms.Button buttonShowShowtimes;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdd;
        private System.Windows.Forms.TextBox textBoxMovie;
        private System.Windows.Forms.ComboBox comboBoxScreenAdd;
        private System.Windows.Forms.ComboBox comboBoxTechnologyAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMovieID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerEdit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxScreenEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxTechnologyEdit;
        private System.Windows.Forms.TextBox textBoxMovieIDEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxShowtimeIDEdit;
        private System.Windows.Forms.Label label7;
    }
}
