namespace Cinema.Views.Employee
{
    partial class ComplaintsEmployeePanel
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
            this.dataGridViewComplaint = new System.Windows.Forms.DataGridView();
            this.textBoxComplaint = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComplaint)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewComplaint
            // 
            this.dataGridViewComplaint.AllowUserToAddRows = false;
            this.dataGridViewComplaint.AllowUserToDeleteRows = false;
            this.dataGridViewComplaint.AllowUserToResizeColumns = false;
            this.dataGridViewComplaint.AllowUserToResizeRows = false;
            this.dataGridViewComplaint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewComplaint.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewComplaint.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewComplaint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComplaint.GridColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridViewComplaint.Location = new System.Drawing.Point(38, 53);
            this.dataGridViewComplaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewComplaint.MultiSelect = false;
            this.dataGridViewComplaint.Name = "dataGridViewComplaint";
            this.dataGridViewComplaint.RowHeadersWidth = 51;
            this.dataGridViewComplaint.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewComplaint.RowTemplate.Height = 24;
            this.dataGridViewComplaint.Size = new System.Drawing.Size(605, 143);
            this.dataGridViewComplaint.TabIndex = 58;
            this.dataGridViewComplaint.SelectionChanged += new System.EventHandler(this.dataGridViewComplaint_SelectionChanged);
            // 
            // textBoxComplaint
            // 
            this.textBoxComplaint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxComplaint.Location = new System.Drawing.Point(176, 256);
            this.textBoxComplaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxComplaint.Multiline = true;
            this.textBoxComplaint.Name = "textBoxComplaint";
            this.textBoxComplaint.ReadOnly = true;
            this.textBoxComplaint.Size = new System.Drawing.Size(324, 159);
            this.textBoxComplaint.TabIndex = 59;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Crimson;
            this.buttonDelete.Location = new System.Drawing.Point(271, 451);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(103, 46);
            this.buttonDelete.TabIndex = 60;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ComplaintsEmployeePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxComplaint);
            this.Controls.Add(this.dataGridViewComplaint);
            this.Name = "ComplaintsEmployeePanel";
            this.Size = new System.Drawing.Size(682, 553);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComplaint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewComplaint;
        private System.Windows.Forms.TextBox textBoxComplaint;
        private System.Windows.Forms.Button buttonDelete;
    }
}
