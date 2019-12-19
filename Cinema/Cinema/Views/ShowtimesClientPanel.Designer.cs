namespace Cinema
{
    partial class ShowtimesClientPanel
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewShowtimes = new System.Windows.Forms.DataGridView();
            this.sHOWTIMEVIEWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxShowtime = new System.Windows.Forms.GroupBox();
            this.comboBoxShowtimeTicket = new System.Windows.Forms.ComboBox();
            this.comboBoxShowtimeSeat = new System.Windows.Forms.ComboBox();
            this.labelReservationScreen = new System.Windows.Forms.Label();
            this.labelReservationClient = new System.Windows.Forms.Label();
            this.labelReservationDate = new System.Windows.Forms.Label();
            this.labelReservationMovie = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonBook = new System.Windows.Forms.Button();
            this.labelShowtimeDate = new System.Windows.Forms.Label();
            this.labelShowtimeClient = new System.Windows.Forms.Label();
            this.labelShowtimeTicket = new System.Windows.Forms.Label();
            this.labelShowtimeScreen = new System.Windows.Forms.Label();
            this.labelShowtimeSeat = new System.Windows.Forms.Label();
            this.labelShowtimeMovie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowtimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOWTIMEVIEWBindingSource)).BeginInit();
            this.groupBoxShowtime.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewShowtimes
            // 
            this.dataGridViewShowtimes.AllowUserToAddRows = false;
            this.dataGridViewShowtimes.AllowUserToDeleteRows = false;
            this.dataGridViewShowtimes.AllowUserToResizeColumns = false;
            this.dataGridViewShowtimes.AllowUserToResizeRows = false;
            this.dataGridViewShowtimes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewShowtimes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewShowtimes.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridViewShowtimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowtimes.GridColor = System.Drawing.Color.LavenderBlush;
            this.dataGridViewShowtimes.Location = new System.Drawing.Point(223, 66);
            this.dataGridViewShowtimes.Name = "dataGridViewShowtimes";
            this.dataGridViewShowtimes.ReadOnly = true;
            this.dataGridViewShowtimes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewShowtimes.RowTemplate.Height = 24;
            this.dataGridViewShowtimes.Size = new System.Drawing.Size(489, 288);
            this.dataGridViewShowtimes.TabIndex = 0;
            this.dataGridViewShowtimes.SelectionChanged += new System.EventHandler(this.dataGridViewShowtimes_SelectionChanged);
            // 
            // sHOWTIMEVIEWBindingSource
            // 
            this.sHOWTIMEVIEWBindingSource.DataSource = typeof(Cinema.Database.SHOWTIME_VIEW);
            // 
            // groupBoxShowtime
            // 
            this.groupBoxShowtime.Controls.Add(this.comboBoxShowtimeTicket);
            this.groupBoxShowtime.Controls.Add(this.comboBoxShowtimeSeat);
            this.groupBoxShowtime.Controls.Add(this.labelReservationScreen);
            this.groupBoxShowtime.Controls.Add(this.labelReservationClient);
            this.groupBoxShowtime.Controls.Add(this.labelReservationDate);
            this.groupBoxShowtime.Controls.Add(this.labelReservationMovie);
            this.groupBoxShowtime.Controls.Add(this.buttonBuy);
            this.groupBoxShowtime.Controls.Add(this.buttonBook);
            this.groupBoxShowtime.Controls.Add(this.labelShowtimeDate);
            this.groupBoxShowtime.Controls.Add(this.labelShowtimeClient);
            this.groupBoxShowtime.Controls.Add(this.labelShowtimeTicket);
            this.groupBoxShowtime.Controls.Add(this.labelShowtimeScreen);
            this.groupBoxShowtime.Controls.Add(this.labelShowtimeSeat);
            this.groupBoxShowtime.Controls.Add(this.labelShowtimeMovie);
            this.groupBoxShowtime.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold);
            this.groupBoxShowtime.Location = new System.Drawing.Point(223, 376);
            this.groupBoxShowtime.Name = "groupBoxShowtime";
            this.groupBoxShowtime.Size = new System.Drawing.Size(489, 338);
            this.groupBoxShowtime.TabIndex = 1;
            this.groupBoxShowtime.TabStop = false;
            this.groupBoxShowtime.Text = "Reservation";
            // 
            // comboBoxShowtimeTicket
            // 
            this.comboBoxShowtimeTicket.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboBoxShowtimeTicket.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.comboBoxShowtimeTicket.ItemHeight = 16;
            this.comboBoxShowtimeTicket.Items.AddRange(new object[] {
            "Normal",
            "Reduced"});
            this.comboBoxShowtimeTicket.Location = new System.Drawing.Point(136, 186);
            this.comboBoxShowtimeTicket.Name = "comboBoxShowtimeTicket";
            this.comboBoxShowtimeTicket.Size = new System.Drawing.Size(121, 24);
            this.comboBoxShowtimeTicket.TabIndex = 14;
            this.comboBoxShowtimeTicket.Visible = false;
            // 
            // comboBoxShowtimeSeat
            // 
            this.comboBoxShowtimeSeat.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboBoxShowtimeSeat.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.comboBoxShowtimeSeat.FormattingEnabled = true;
            this.comboBoxShowtimeSeat.ItemHeight = 16;
            this.comboBoxShowtimeSeat.Location = new System.Drawing.Point(136, 264);
            this.comboBoxShowtimeSeat.Name = "comboBoxShowtimeSeat";
            this.comboBoxShowtimeSeat.Size = new System.Drawing.Size(64, 24);
            this.comboBoxShowtimeSeat.TabIndex = 13;
            this.comboBoxShowtimeSeat.Visible = false;
            // 
            // labelReservationScreen
            // 
            this.labelReservationScreen.AutoSize = true;
            this.labelReservationScreen.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.labelReservationScreen.Location = new System.Drawing.Point(133, 228);
            this.labelReservationScreen.Name = "labelReservationScreen";
            this.labelReservationScreen.Size = new System.Drawing.Size(67, 17);
            this.labelReservationScreen.TabIndex = 12;
            this.labelReservationScreen.Text = "label5";
            this.labelReservationScreen.Visible = false;
            // 
            // labelReservationClient
            // 
            this.labelReservationClient.AutoSize = true;
            this.labelReservationClient.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.labelReservationClient.Location = new System.Drawing.Point(133, 150);
            this.labelReservationClient.Name = "labelReservationClient";
            this.labelReservationClient.Size = new System.Drawing.Size(67, 17);
            this.labelReservationClient.TabIndex = 10;
            this.labelReservationClient.Text = "label3";
            this.labelReservationClient.Visible = false;
            // 
            // labelReservationDate
            // 
            this.labelReservationDate.AutoSize = true;
            this.labelReservationDate.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.labelReservationDate.Location = new System.Drawing.Point(133, 111);
            this.labelReservationDate.Name = "labelReservationDate";
            this.labelReservationDate.Size = new System.Drawing.Size(67, 17);
            this.labelReservationDate.TabIndex = 9;
            this.labelReservationDate.Text = "label2";
            this.labelReservationDate.Visible = false;
            // 
            // labelReservationMovie
            // 
            this.labelReservationMovie.AutoSize = true;
            this.labelReservationMovie.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.labelReservationMovie.Location = new System.Drawing.Point(133, 72);
            this.labelReservationMovie.Name = "labelReservationMovie";
            this.labelReservationMovie.Size = new System.Drawing.Size(65, 17);
            this.labelReservationMovie.TabIndex = 8;
            this.labelReservationMovie.Text = "label1";
            this.labelReservationMovie.Visible = false;
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonBuy.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.buttonBuy.Location = new System.Drawing.Point(299, 292);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 23);
            this.buttonBuy.TabIndex = 7;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Visible = false;
            // 
            // buttonBook
            // 
            this.buttonBook.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonBook.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.buttonBook.Location = new System.Drawing.Point(408, 292);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(75, 23);
            this.buttonBook.TabIndex = 6;
            this.buttonBook.Text = "Book";
            this.buttonBook.UseVisualStyleBackColor = false;
            this.buttonBook.Visible = false;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // labelShowtimeDate
            // 
            this.labelShowtimeDate.AutoSize = true;
            this.labelShowtimeDate.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.labelShowtimeDate.Location = new System.Drawing.Point(18, 104);
            this.labelShowtimeDate.Name = "labelShowtimeDate";
            this.labelShowtimeDate.Size = new System.Drawing.Size(80, 25);
            this.labelShowtimeDate.TabIndex = 5;
            this.labelShowtimeDate.Text = "Date:";
            // 
            // labelShowtimeClient
            // 
            this.labelShowtimeClient.AutoSize = true;
            this.labelShowtimeClient.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.labelShowtimeClient.Location = new System.Drawing.Point(-5, 143);
            this.labelShowtimeClient.Name = "labelShowtimeClient";
            this.labelShowtimeClient.Size = new System.Drawing.Size(103, 25);
            this.labelShowtimeClient.TabIndex = 4;
            this.labelShowtimeClient.Text = "Client:";
            // 
            // labelShowtimeTicket
            // 
            this.labelShowtimeTicket.AutoSize = true;
            this.labelShowtimeTicket.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.labelShowtimeTicket.Location = new System.Drawing.Point(-4, 182);
            this.labelShowtimeTicket.Name = "labelShowtimeTicket";
            this.labelShowtimeTicket.Size = new System.Drawing.Size(102, 25);
            this.labelShowtimeTicket.TabIndex = 3;
            this.labelShowtimeTicket.Text = "Ticket:";
            // 
            // labelShowtimeScreen
            // 
            this.labelShowtimeScreen.AutoSize = true;
            this.labelShowtimeScreen.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.labelShowtimeScreen.Location = new System.Drawing.Point(-6, 221);
            this.labelShowtimeScreen.Name = "labelShowtimeScreen";
            this.labelShowtimeScreen.Size = new System.Drawing.Size(104, 25);
            this.labelShowtimeScreen.TabIndex = 2;
            this.labelShowtimeScreen.Text = "Screen:";
            // 
            // labelShowtimeSeat
            // 
            this.labelShowtimeSeat.AutoSize = true;
            this.labelShowtimeSeat.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.labelShowtimeSeat.Location = new System.Drawing.Point(25, 260);
            this.labelShowtimeSeat.Name = "labelShowtimeSeat";
            this.labelShowtimeSeat.Size = new System.Drawing.Size(73, 25);
            this.labelShowtimeSeat.TabIndex = 1;
            this.labelShowtimeSeat.Text = "Seat:";
            // 
            // labelShowtimeMovie
            // 
            this.labelShowtimeMovie.AutoSize = true;
            this.labelShowtimeMovie.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.labelShowtimeMovie.Location = new System.Drawing.Point(2, 65);
            this.labelShowtimeMovie.Name = "labelShowtimeMovie";
            this.labelShowtimeMovie.Size = new System.Drawing.Size(96, 25);
            this.labelShowtimeMovie.TabIndex = 0;
            this.labelShowtimeMovie.Text = "Movie:";
            // 
            // ShowtimesClientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.groupBoxShowtime);
            this.Controls.Add(this.dataGridViewShowtimes);
            this.Name = "ShowtimesClientPanel";
            this.Size = new System.Drawing.Size(825, 956);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowtimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOWTIMEVIEWBindingSource)).EndInit();
            this.groupBoxShowtime.ResumeLayout(false);
            this.groupBoxShowtime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShowtimes;
        private System.Windows.Forms.GroupBox groupBoxShowtime;
        private System.Windows.Forms.Label labelShowtimeMovie;
        private System.Windows.Forms.Label labelShowtimeDate;
        private System.Windows.Forms.Label labelShowtimeClient;
        private System.Windows.Forms.Label labelShowtimeTicket;
        private System.Windows.Forms.Label labelShowtimeScreen;
        private System.Windows.Forms.Label labelShowtimeSeat;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.ComboBox comboBoxShowtimeSeat;
        private System.Windows.Forms.Label labelReservationScreen;
        private System.Windows.Forms.Label labelReservationClient;
        private System.Windows.Forms.Label labelReservationDate;
        private System.Windows.Forms.Label labelReservationMovie;
        private System.Windows.Forms.ComboBox comboBoxShowtimeTicket;
        private System.Windows.Forms.BindingSource sHOWTIMEVIEWBindingSource;
    }
}
