namespace Cinema
{
    partial class FormMain
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
            this.panelButtonsStartWindow = new System.Windows.Forms.Panel();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelButtonsStartWindow.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtonsStartWindow
            // 
            this.panelButtonsStartWindow.BackColor = System.Drawing.Color.Wheat;
            this.panelButtonsStartWindow.Controls.Add(this.buttonSignUp);
            this.panelButtonsStartWindow.Controls.Add(this.buttonLogIn);
            this.panelButtonsStartWindow.Location = new System.Drawing.Point(0, -1);
            this.panelButtonsStartWindow.Name = "panelButtonsStartWindow";
            this.panelButtonsStartWindow.Size = new System.Drawing.Size(200, 500);
            this.panelButtonsStartWindow.TabIndex = 0;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSignUp.Location = new System.Drawing.Point(0, 96);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(200, 100);
            this.buttonSignUp.TabIndex = 1;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.Location = new System.Drawing.Point(0, 0);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(200, 100);
            this.buttonLogIn.TabIndex = 0;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.OldLace;
            this.panelContent.Controls.Add(this.labelWelcome);
            this.panelContent.Location = new System.Drawing.Point(196, -1);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(700, 500);
            this.panelContent.TabIndex = 1;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Castellar", 24F, System.Drawing.FontStyle.Bold);
            this.labelWelcome.Location = new System.Drawing.Point(3, 181);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(649, 48);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome in our cinema!";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelButtonsStartWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Cinema";
            this.panelButtonsStartWindow.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtonsStartWindow;
        public System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label labelWelcome;
    }
}

