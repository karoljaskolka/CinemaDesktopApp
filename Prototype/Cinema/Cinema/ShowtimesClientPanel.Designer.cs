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
            this.dataGridViewShowtimes = new System.Windows.Forms.DataGridView();
            this.groupBoxShowtime = new System.Windows.Forms.GroupBox();
            this.labelShowtimeMovie = new System.Windows.Forms.Label();
            this.labelShowtimeSeat = new System.Windows.Forms.Label();
            this.labelShowtimeScreen = new System.Windows.Forms.Label();
            this.labelShowtimeTicket = new System.Windows.Forms.Label();
            this.labelShowtimeClient = new System.Windows.Forms.Label();
            this.labelShowtimeDate = new System.Windows.Forms.Label();
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxShowtimeSeat = new System.Windows.Forms.ComboBox();
            this.comboBoxShowtimeTicket = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowtimes)).BeginInit();
            this.groupBoxShowtime.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewShowtimes
            // 
            this.dataGridViewShowtimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowtimes.Location = new System.Drawing.Point(223, 66);
            this.dataGridViewShowtimes.Name = "dataGridViewShowtimes";
            this.dataGridViewShowtimes.RowHeadersWidth = 51;
            this.dataGridViewShowtimes.RowTemplate.Height = 24;
            this.dataGridViewShowtimes.Size = new System.Drawing.Size(489, 288);
            this.dataGridViewShowtimes.TabIndex = 0;
            // 
            // groupBoxShowtime
            // 
            this.groupBoxShowtime.Controls.Add(this.comboBoxShowtimeTicket);
            this.groupBoxShowtime.Controls.Add(this.comboBoxShowtimeSeat);
            this.groupBoxShowtime.Controls.Add(this.label5);
            this.groupBoxShowtime.Controls.Add(this.label4);
            this.groupBoxShowtime.Controls.Add(this.label3);
            this.groupBoxShowtime.Controls.Add(this.label2);
            this.groupBoxShowtime.Controls.Add(this.label1);
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
            // labelShowtimeSeat
            // 
            this.labelShowtimeSeat.AutoSize = true;
            this.labelShowtimeSeat.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.labelShowtimeSeat.Location = new System.Drawing.Point(25, 252);
            this.labelShowtimeSeat.Name = "labelShowtimeSeat";
            this.labelShowtimeSeat.Size = new System.Drawing.Size(73, 25);
            this.labelShowtimeSeat.TabIndex = 1;
            this.labelShowtimeSeat.Text = "Seat:";
            // 
            // labelShowtimeScreen
            // 
            this.labelShowtimeScreen.AutoSize = true;
            this.labelShowtimeScreen.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.labelShowtimeScreen.Location = new System.Drawing.Point(-6, 212);
            this.labelShowtimeScreen.Name = "labelShowtimeScreen";
            this.labelShowtimeScreen.Size = new System.Drawing.Size(104, 25);
            this.labelShowtimeScreen.TabIndex = 2;
            this.labelShowtimeScreen.Text = "Screen:";
            // 
            // labelShowtimeTicket
            // 
            this.labelShowtimeTicket.AutoSize = true;
            this.labelShowtimeTicket.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.labelShowtimeTicket.Location = new System.Drawing.Point(-4, 174);
            this.labelShowtimeTicket.Name = "labelShowtimeTicket";
            this.labelShowtimeTicket.Size = new System.Drawing.Size(102, 25);
            this.labelShowtimeTicket.TabIndex = 3;
            this.labelShowtimeTicket.Text = "Ticket:";
            // 
            // labelShowtimeClient
            // 
            this.labelShowtimeClient.AutoSize = true;
            this.labelShowtimeClient.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.labelShowtimeClient.Location = new System.Drawing.Point(-5, 140);
            this.labelShowtimeClient.Name = "labelShowtimeClient";
            this.labelShowtimeClient.Size = new System.Drawing.Size(103, 25);
            this.labelShowtimeClient.TabIndex = 4;
            this.labelShowtimeClient.Text = "Client:";
            // 
            // labelShowtimeDate
            // 
            this.labelShowtimeDate.AutoSize = true;
            this.labelShowtimeDate.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.labelShowtimeDate.Location = new System.Drawing.Point(18, 101);
            this.labelShowtimeDate.Name = "labelShowtimeDate";
            this.labelShowtimeDate.Size = new System.Drawing.Size(80, 25);
            this.labelShowtimeDate.TabIndex = 5;
            this.labelShowtimeDate.Text = "Date:";
            // 
            // buttonBook
            // 
            this.buttonBook.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.buttonBook.Location = new System.Drawing.Point(408, 292);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(75, 23);
            this.buttonBook.TabIndex = 6;
            this.buttonBook.Text = "Book";
            this.buttonBook.UseVisualStyleBackColor = true;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.buttonBuy.Location = new System.Drawing.Point(299, 292);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 23);
            this.buttonBuy.TabIndex = 7;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(144, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(144, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(144, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(245, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(145, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // comboBoxShowtimeSeat
            // 
            this.comboBoxShowtimeSeat.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.comboBoxShowtimeSeat.FormattingEnabled = true;
            this.comboBoxShowtimeSeat.ItemHeight = 16;
            this.comboBoxShowtimeSeat.Location = new System.Drawing.Point(150, 252);
            this.comboBoxShowtimeSeat.Name = "comboBoxShowtimeSeat";
            this.comboBoxShowtimeSeat.Size = new System.Drawing.Size(86, 24);
            this.comboBoxShowtimeSeat.TabIndex = 13;
            // 
            // comboBoxShowtimeTicket
            // 
            this.comboBoxShowtimeTicket.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.comboBoxShowtimeTicket.FormattingEnabled = true;
            this.comboBoxShowtimeTicket.ItemHeight = 16;
            this.comboBoxShowtimeTicket.Location = new System.Drawing.Point(150, 175);
            this.comboBoxShowtimeTicket.Name = "comboBoxShowtimeTicket";
            this.comboBoxShowtimeTicket.Size = new System.Drawing.Size(86, 24);
            this.comboBoxShowtimeTicket.TabIndex = 14;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxShowtimeTicket;
    }
}
