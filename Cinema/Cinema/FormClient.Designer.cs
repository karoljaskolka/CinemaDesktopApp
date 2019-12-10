namespace Cinema
{
    partial class FormClient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelButtonsClient = new System.Windows.Forms.Panel();
            this.buttonProfileUpdate = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonRatings = new System.Windows.Forms.Button();
            this.buttonMovies = new System.Windows.Forms.Button();
            this.buttonTickets = new System.Windows.Forms.Button();
            this.buttonShowtimes = new System.Windows.Forms.Button();
            this.panelClientContent = new System.Windows.Forms.Panel();
            this.panelButtonsClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(206, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 500);
            this.panel1.TabIndex = 0;
            // 
            // panelButtonsClient
            // 
            this.panelButtonsClient.BackColor = System.Drawing.Color.Thistle;
            this.panelButtonsClient.Controls.Add(this.buttonProfileUpdate);
            this.panelButtonsClient.Controls.Add(this.buttonReport);
            this.panelButtonsClient.Controls.Add(this.buttonRatings);
            this.panelButtonsClient.Controls.Add(this.buttonMovies);
            this.panelButtonsClient.Controls.Add(this.buttonTickets);
            this.panelButtonsClient.Controls.Add(this.buttonShowtimes);
            this.panelButtonsClient.Controls.Add(this.panel1);
            this.panelButtonsClient.Location = new System.Drawing.Point(-3, -1);
            this.panelButtonsClient.Name = "panelButtonsClient";
            this.panelButtonsClient.Size = new System.Drawing.Size(200, 600);
            this.panelButtonsClient.TabIndex = 1;
            // 
            // buttonProfileUpdate
            // 
            this.buttonProfileUpdate.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.buttonProfileUpdate.Location = new System.Drawing.Point(0, 500);
            this.buttonProfileUpdate.Name = "buttonProfileUpdate";
            this.buttonProfileUpdate.Size = new System.Drawing.Size(200, 100);
            this.buttonProfileUpdate.TabIndex = 6;
            this.buttonProfileUpdate.Text = "Profile";
            this.buttonProfileUpdate.UseVisualStyleBackColor = true;
            this.buttonProfileUpdate.Click += new System.EventHandler(this.buttonProfileUpdate_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.buttonReport.Location = new System.Drawing.Point(0, 400);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(200, 100);
            this.buttonReport.TabIndex = 5;
            this.buttonReport.Text = "Report Case";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonRatings
            // 
            this.buttonRatings.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRatings.Location = new System.Drawing.Point(0, 300);
            this.buttonRatings.Name = "buttonRatings";
            this.buttonRatings.Size = new System.Drawing.Size(200, 100);
            this.buttonRatings.TabIndex = 4;
            this.buttonRatings.Text = "Ratings";
            this.buttonRatings.UseVisualStyleBackColor = true;
            this.buttonRatings.Click += new System.EventHandler(this.buttonRatings_Click);
            // 
            // buttonMovies
            // 
            this.buttonMovies.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.buttonMovies.Location = new System.Drawing.Point(0, 200);
            this.buttonMovies.Name = "buttonMovies";
            this.buttonMovies.Size = new System.Drawing.Size(200, 100);
            this.buttonMovies.TabIndex = 3;
            this.buttonMovies.Text = "Movies";
            this.buttonMovies.UseVisualStyleBackColor = true;
            this.buttonMovies.Click += new System.EventHandler(this.buttonMovies_Click);
            // 
            // buttonTickets
            // 
            this.buttonTickets.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.buttonTickets.Location = new System.Drawing.Point(0, 100);
            this.buttonTickets.Name = "buttonTickets";
            this.buttonTickets.Size = new System.Drawing.Size(200, 100);
            this.buttonTickets.TabIndex = 2;
            this.buttonTickets.Text = "Tickets";
            this.buttonTickets.UseVisualStyleBackColor = true;
            this.buttonTickets.Click += new System.EventHandler(this.buttonTickets_Click);
            // 
            // buttonShowtimes
            // 
            this.buttonShowtimes.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.buttonShowtimes.Location = new System.Drawing.Point(0, 0);
            this.buttonShowtimes.Name = "buttonShowtimes";
            this.buttonShowtimes.Size = new System.Drawing.Size(200, 100);
            this.buttonShowtimes.TabIndex = 1;
            this.buttonShowtimes.Text = "Showtimes";
            this.buttonShowtimes.UseVisualStyleBackColor = true;
            this.buttonShowtimes.Click += new System.EventHandler(this.buttonShowtimes_Click);
            // 
            // panelClientContent
            // 
            this.panelClientContent.BackColor = System.Drawing.Color.Lavender;
            this.panelClientContent.Location = new System.Drawing.Point(200, 0);
            this.panelClientContent.Name = "panelClientContent";
            this.panelClientContent.Size = new System.Drawing.Size(700, 600);
            this.panelClientContent.TabIndex = 2;
            // 
            // FormClient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.panelClientContent);
            this.Controls.Add(this.panelButtonsClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormClient";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Client of Cinema";
            this.panelButtonsClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelButtonsClient;
        private System.Windows.Forms.Button buttonProfileUpdate;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonRatings;
        private System.Windows.Forms.Button buttonMovies;
        private System.Windows.Forms.Button buttonTickets;
        private System.Windows.Forms.Button buttonShowtimes;
        private System.Windows.Forms.Panel panelClientContent;
    }
}