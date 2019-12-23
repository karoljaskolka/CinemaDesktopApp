namespace Cinema
{
    partial class TicketsClientPanel
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
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.groupBoxTicket = new System.Windows.Forms.GroupBox();
            this.labelTicketStatus = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelTicketPrice = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTicketSeat = new System.Windows.Forms.Label();
            this.labelTicketType = new System.Windows.Forms.Label();
            this.labelTicketScreen = new System.Windows.Forms.Label();
            this.labelTicketClient = new System.Windows.Forms.Label();
            this.labelTicketDate = new System.Windows.Forms.Label();
            this.labelTicketMovie = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonUnbook = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelScreen = new System.Windows.Forms.Label();
            this.labelSeat = new System.Windows.Forms.Label();
            this.labelMovie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.groupBoxTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.AllowUserToAddRows = false;
            this.dataGridViewTickets.AllowUserToDeleteRows = false;
            this.dataGridViewTickets.AllowUserToResizeColumns = false;
            this.dataGridViewTickets.AllowUserToResizeRows = false;
            this.dataGridViewTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTickets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTickets.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.GridColor = System.Drawing.Color.LavenderBlush;
            this.dataGridViewTickets.Location = new System.Drawing.Point(92, 89);
            this.dataGridViewTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTickets.MultiSelect = false;
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.RowHeadersWidth = 51;
            this.dataGridViewTickets.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTickets.RowTemplate.Height = 24;
            this.dataGridViewTickets.Size = new System.Drawing.Size(757, 257);
            this.dataGridViewTickets.TabIndex = 2;
            this.dataGridViewTickets.SelectionChanged += new System.EventHandler(this.dataGridViewTickets_SelectionChanged);
            // 
            // groupBoxTicket
            // 
            this.groupBoxTicket.Controls.Add(this.labelTicketStatus);
            this.groupBoxTicket.Controls.Add(this.labelStatus);
            this.groupBoxTicket.Controls.Add(this.labelTicketPrice);
            this.groupBoxTicket.Controls.Add(this.labelPrice);
            this.groupBoxTicket.Controls.Add(this.labelTicketSeat);
            this.groupBoxTicket.Controls.Add(this.labelTicketType);
            this.groupBoxTicket.Controls.Add(this.labelTicketScreen);
            this.groupBoxTicket.Controls.Add(this.labelTicketClient);
            this.groupBoxTicket.Controls.Add(this.labelTicketDate);
            this.groupBoxTicket.Controls.Add(this.labelTicketMovie);
            this.groupBoxTicket.Controls.Add(this.buttonBuy);
            this.groupBoxTicket.Controls.Add(this.buttonUnbook);
            this.groupBoxTicket.Controls.Add(this.labelDate);
            this.groupBoxTicket.Controls.Add(this.labelClient);
            this.groupBoxTicket.Controls.Add(this.labelType);
            this.groupBoxTicket.Controls.Add(this.labelScreen);
            this.groupBoxTicket.Controls.Add(this.labelSeat);
            this.groupBoxTicket.Controls.Add(this.labelMovie);
            this.groupBoxTicket.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold);
            this.groupBoxTicket.Location = new System.Drawing.Point(231, 379);
            this.groupBoxTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTicket.Name = "groupBoxTicket";
            this.groupBoxTicket.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxTicket.Size = new System.Drawing.Size(489, 357);
            this.groupBoxTicket.TabIndex = 56;
            this.groupBoxTicket.TabStop = false;
            this.groupBoxTicket.Text = "Ticket";
            this.groupBoxTicket.Visible = false;
            // 
            // labelTicketStatus
            // 
            this.labelTicketStatus.AutoSize = true;
            this.labelTicketStatus.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.labelTicketStatus.Location = new System.Drawing.Point(394, 261);
            this.labelTicketStatus.Name = "labelTicketStatus";
            this.labelTicketStatus.Size = new System.Drawing.Size(67, 17);
            this.labelTicketStatus.TabIndex = 18;
            this.labelTicketStatus.Text = "label5";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.labelStatus.Location = new System.Drawing.Point(269, 254);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(105, 25);
            this.labelStatus.TabIndex = 17;
            this.labelStatus.Text = "Status:";
            // 
            // labelTicketPrice
            // 
            this.labelTicketPrice.AutoSize = true;
            this.labelTicketPrice.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.labelTicketPrice.Location = new System.Drawing.Point(131, 202);
            this.labelTicketPrice.Name = "labelTicketPrice";
            this.labelTicketPrice.Size = new System.Drawing.Size(67, 17);
            this.labelTicketPrice.TabIndex = 16;
            this.labelTicketPrice.Text = "label2";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.labelPrice.Location = new System.Drawing.Point(13, 194);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(85, 25);
            this.labelPrice.TabIndex = 15;
            this.labelPrice.Text = "Price:";
            // 
            // labelTicketSeat
            // 
            this.labelTicketSeat.AutoSize = true;
            this.labelTicketSeat.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.labelTicketSeat.Location = new System.Drawing.Point(131, 327);
            this.labelTicketSeat.Name = "labelTicketSeat";
            this.labelTicketSeat.Size = new System.Drawing.Size(67, 17);
            this.labelTicketSeat.TabIndex = 14;
            this.labelTicketSeat.Text = "label5";
            // 
            // labelTicketType
            // 
            this.labelTicketType.AutoSize = true;
            this.labelTicketType.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.labelTicketType.Location = new System.Drawing.Point(129, 242);
            this.labelTicketType.Name = "labelTicketType";
            this.labelTicketType.Size = new System.Drawing.Size(67, 17);
            this.labelTicketType.TabIndex = 13;
            this.labelTicketType.Text = "label5";
            // 
            // labelTicketScreen
            // 
            this.labelTicketScreen.AutoSize = true;
            this.labelTicketScreen.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.labelTicketScreen.Location = new System.Drawing.Point(131, 286);
            this.labelTicketScreen.Name = "labelTicketScreen";
            this.labelTicketScreen.Size = new System.Drawing.Size(67, 17);
            this.labelTicketScreen.TabIndex = 12;
            this.labelTicketScreen.Text = "label5";
            // 
            // labelTicketClient
            // 
            this.labelTicketClient.AutoSize = true;
            this.labelTicketClient.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.labelTicketClient.Location = new System.Drawing.Point(131, 76);
            this.labelTicketClient.Name = "labelTicketClient";
            this.labelTicketClient.Size = new System.Drawing.Size(67, 17);
            this.labelTicketClient.TabIndex = 10;
            this.labelTicketClient.Text = "label3";
            // 
            // labelTicketDate
            // 
            this.labelTicketDate.AutoSize = true;
            this.labelTicketDate.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.labelTicketDate.Location = new System.Drawing.Point(131, 160);
            this.labelTicketDate.Name = "labelTicketDate";
            this.labelTicketDate.Size = new System.Drawing.Size(67, 17);
            this.labelTicketDate.TabIndex = 9;
            this.labelTicketDate.Text = "label2";
            // 
            // labelTicketMovie
            // 
            this.labelTicketMovie.AutoSize = true;
            this.labelTicketMovie.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.labelTicketMovie.Location = new System.Drawing.Point(131, 118);
            this.labelTicketMovie.Name = "labelTicketMovie";
            this.labelTicketMovie.Size = new System.Drawing.Size(65, 17);
            this.labelTicketMovie.TabIndex = 8;
            this.labelTicketMovie.Text = "label1";
            // 
            // buttonBuy
            // 
            this.buttonBuy.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonBuy.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.buttonBuy.Location = new System.Drawing.Point(263, 324);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(99, 23);
            this.buttonBuy.TabIndex = 7;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Visible = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // buttonUnbook
            // 
            this.buttonUnbook.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonUnbook.Font = new System.Drawing.Font("Castellar", 8F, System.Drawing.FontStyle.Bold);
            this.buttonUnbook.Location = new System.Drawing.Point(380, 324);
            this.buttonUnbook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUnbook.Name = "buttonUnbook";
            this.buttonUnbook.Size = new System.Drawing.Size(103, 23);
            this.buttonUnbook.TabIndex = 6;
            this.buttonUnbook.Text = "Unbook";
            this.buttonUnbook.UseVisualStyleBackColor = false;
            this.buttonUnbook.Visible = false;
            this.buttonUnbook.Click += new System.EventHandler(this.buttonUnbook_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.labelDate.Location = new System.Drawing.Point(19, 153);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(80, 25);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Date:";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.labelClient.Location = new System.Drawing.Point(-4, 68);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(103, 25);
            this.labelClient.TabIndex = 4;
            this.labelClient.Text = "Client:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.labelType.Location = new System.Drawing.Point(21, 236);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(76, 25);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Type:";
            // 
            // labelScreen
            // 
            this.labelScreen.AutoSize = true;
            this.labelScreen.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.labelScreen.Location = new System.Drawing.Point(-5, 278);
            this.labelScreen.Name = "labelScreen";
            this.labelScreen.Size = new System.Drawing.Size(104, 25);
            this.labelScreen.TabIndex = 2;
            this.labelScreen.Text = "Screen:";
            // 
            // labelSeat
            // 
            this.labelSeat.AutoSize = true;
            this.labelSeat.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.labelSeat.Location = new System.Drawing.Point(25, 320);
            this.labelSeat.Name = "labelSeat";
            this.labelSeat.Size = new System.Drawing.Size(73, 25);
            this.labelSeat.TabIndex = 1;
            this.labelSeat.Text = "Seat:";
            // 
            // labelMovie
            // 
            this.labelMovie.AutoSize = true;
            this.labelMovie.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.labelMovie.Location = new System.Drawing.Point(3, 110);
            this.labelMovie.Name = "labelMovie";
            this.labelMovie.Size = new System.Drawing.Size(96, 25);
            this.labelMovie.TabIndex = 0;
            this.labelMovie.Text = "Movie:";
            // 
            // TicketsClientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::Cinema.Properties.Resources.cinemaPhoto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.groupBoxTicket);
            this.Controls.Add(this.dataGridViewTickets);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TicketsClientPanel";
            this.Size = new System.Drawing.Size(933, 738);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.groupBoxTicket.ResumeLayout(false);
            this.groupBoxTicket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.GroupBox groupBoxTicket;
        private System.Windows.Forms.Label labelTicketScreen;
        private System.Windows.Forms.Label labelTicketClient;
        private System.Windows.Forms.Label labelTicketDate;
        private System.Windows.Forms.Label labelTicketMovie;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonUnbook;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelScreen;
        private System.Windows.Forms.Label labelSeat;
        private System.Windows.Forms.Label labelMovie;
        private System.Windows.Forms.Label labelTicketSeat;
        private System.Windows.Forms.Label labelTicketType;
        private System.Windows.Forms.Label labelTicketPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelTicketStatus;
        private System.Windows.Forms.Label labelStatus;
    }
}
