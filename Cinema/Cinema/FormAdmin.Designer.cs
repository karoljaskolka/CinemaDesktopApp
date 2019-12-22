namespace Cinema
{
    partial class FormAdmin
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelButtonMovies = new System.Windows.Forms.Panel();
            this.panelButtonShowtimes = new System.Windows.Forms.Panel();
            this.panelButtonUsers = new System.Windows.Forms.Panel();
            this.panelButtonComments = new System.Windows.Forms.Panel();
            this.buttonMovies = new System.Windows.Forms.Button();
            this.buttonShowtimes = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonComments = new System.Windows.Forms.Button();
            this.panelNav.SuspendLayout();
            this.panelButtonMovies.SuspendLayout();
            this.panelButtonShowtimes.SuspendLayout();
            this.panelButtonUsers.SuspendLayout();
            this.panelButtonComments.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.Controls.Add(this.panelButtonComments);
            this.panelNav.Controls.Add(this.panelButtonUsers);
            this.panelNav.Controls.Add(this.panelButtonShowtimes);
            this.panelNav.Controls.Add(this.panelButtonMovies);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(200, 553);
            this.panelNav.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(200, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(682, 553);
            this.panelContent.TabIndex = 1;
            // 
            // panelButtonMovies
            // 
            this.panelButtonMovies.Controls.Add(this.buttonMovies);
            this.panelButtonMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonMovies.Location = new System.Drawing.Point(0, 0);
            this.panelButtonMovies.Name = "panelButtonMovies";
            this.panelButtonMovies.Size = new System.Drawing.Size(200, 100);
            this.panelButtonMovies.TabIndex = 0;
            // 
            // panelButtonShowtimes
            // 
            this.panelButtonShowtimes.Controls.Add(this.buttonShowtimes);
            this.panelButtonShowtimes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonShowtimes.Location = new System.Drawing.Point(0, 100);
            this.panelButtonShowtimes.Name = "panelButtonShowtimes";
            this.panelButtonShowtimes.Size = new System.Drawing.Size(200, 100);
            this.panelButtonShowtimes.TabIndex = 1;
            // 
            // panelButtonUsers
            // 
            this.panelButtonUsers.Controls.Add(this.buttonUsers);
            this.panelButtonUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonUsers.Location = new System.Drawing.Point(0, 200);
            this.panelButtonUsers.Name = "panelButtonUsers";
            this.panelButtonUsers.Size = new System.Drawing.Size(200, 100);
            this.panelButtonUsers.TabIndex = 2;
            // 
            // panelButtonComments
            // 
            this.panelButtonComments.Controls.Add(this.buttonComments);
            this.panelButtonComments.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonComments.Location = new System.Drawing.Point(0, 300);
            this.panelButtonComments.Name = "panelButtonComments";
            this.panelButtonComments.Size = new System.Drawing.Size(200, 100);
            this.panelButtonComments.TabIndex = 0;
            // 
            // buttonMovies
            // 
            this.buttonMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMovies.FlatAppearance.BorderSize = 0;
            this.buttonMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMovies.Location = new System.Drawing.Point(0, 0);
            this.buttonMovies.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMovies.Name = "buttonMovies";
            this.buttonMovies.Size = new System.Drawing.Size(200, 100);
            this.buttonMovies.TabIndex = 0;
            this.buttonMovies.Text = "Movies";
            this.buttonMovies.UseVisualStyleBackColor = true;
            this.buttonMovies.Click += new System.EventHandler(this.buttonMovies_Click);
            // 
            // buttonShowtimes
            // 
            this.buttonShowtimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShowtimes.FlatAppearance.BorderSize = 0;
            this.buttonShowtimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowtimes.Location = new System.Drawing.Point(0, 0);
            this.buttonShowtimes.Margin = new System.Windows.Forms.Padding(0);
            this.buttonShowtimes.Name = "buttonShowtimes";
            this.buttonShowtimes.Size = new System.Drawing.Size(200, 100);
            this.buttonShowtimes.TabIndex = 0;
            this.buttonShowtimes.Text = "Showtimes";
            this.buttonShowtimes.UseVisualStyleBackColor = true;
            this.buttonShowtimes.Click += new System.EventHandler(this.buttonShowtimes_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUsers.FlatAppearance.BorderSize = 0;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Location = new System.Drawing.Point(0, 0);
            this.buttonUsers.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(200, 100);
            this.buttonUsers.TabIndex = 0;
            this.buttonUsers.Text = "Users";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonComments
            // 
            this.buttonComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonComments.FlatAppearance.BorderSize = 0;
            this.buttonComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComments.Location = new System.Drawing.Point(0, 0);
            this.buttonComments.Margin = new System.Windows.Forms.Padding(0);
            this.buttonComments.Name = "buttonComments";
            this.buttonComments.Size = new System.Drawing.Size(200, 100);
            this.buttonComments.TabIndex = 0;
            this.buttonComments.Text = "Comments";
            this.buttonComments.UseVisualStyleBackColor = true;
            this.buttonComments.Click += new System.EventHandler(this.buttonComments_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelNav);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.panelNav.ResumeLayout(false);
            this.panelButtonMovies.ResumeLayout(false);
            this.panelButtonShowtimes.ResumeLayout(false);
            this.panelButtonUsers.ResumeLayout(false);
            this.panelButtonComments.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelButtonComments;
        private System.Windows.Forms.Button buttonComments;
        private System.Windows.Forms.Panel panelButtonUsers;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Panel panelButtonShowtimes;
        private System.Windows.Forms.Button buttonShowtimes;
        private System.Windows.Forms.Panel panelButtonMovies;
        private System.Windows.Forms.Button buttonMovies;
    }
}