namespace Cinema
{
    partial class FormEmployee
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
            this.panelNav = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonComplaints = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonBookings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonShowtimes = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelNav.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.Controls.Add(this.panel3);
            this.panelNav.Controls.Add(this.panel2);
            this.panelNav.Controls.Add(this.panel1);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(200, 553);
            this.panelNav.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonComplaints);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 2;
            // 
            // buttonComplaints
            // 
            this.buttonComplaints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonComplaints.FlatAppearance.BorderSize = 0;
            this.buttonComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComplaints.Location = new System.Drawing.Point(0, 0);
            this.buttonComplaints.Name = "buttonComplaints";
            this.buttonComplaints.Size = new System.Drawing.Size(200, 100);
            this.buttonComplaints.TabIndex = 0;
            this.buttonComplaints.Text = "Complaints";
            this.buttonComplaints.UseVisualStyleBackColor = true;
            this.buttonComplaints.Click += new System.EventHandler(this.buttonComplaints_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonBookings);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // buttonBookings
            // 
            this.buttonBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBookings.FlatAppearance.BorderSize = 0;
            this.buttonBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBookings.Location = new System.Drawing.Point(0, 0);
            this.buttonBookings.Name = "buttonBookings";
            this.buttonBookings.Size = new System.Drawing.Size(200, 100);
            this.buttonBookings.TabIndex = 1;
            this.buttonBookings.Text = "Bookings";
            this.buttonBookings.UseVisualStyleBackColor = true;
            this.buttonBookings.Click += new System.EventHandler(this.buttonBookings_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonShowtimes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // buttonShowtimes
            // 
            this.buttonShowtimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShowtimes.FlatAppearance.BorderSize = 0;
            this.buttonShowtimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowtimes.Location = new System.Drawing.Point(0, 0);
            this.buttonShowtimes.Name = "buttonShowtimes";
            this.buttonShowtimes.Size = new System.Drawing.Size(200, 100);
            this.buttonShowtimes.TabIndex = 0;
            this.buttonShowtimes.Text = "Showtimes";
            this.buttonShowtimes.UseVisualStyleBackColor = true;
            this.buttonShowtimes.Click += new System.EventHandler(this.buttonShowtimes_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(682, 553);
            this.panelContent.TabIndex = 1;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelNav);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEmployee";
            this.Text = "Employee";
            this.panelNav.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonBookings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonShowtimes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonComplaints;
    }
}