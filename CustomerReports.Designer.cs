namespace C969_Software_2
{
    partial class CustomerReports
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
            this.CustomerReportView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerReportView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerReportView
            // 
            this.CustomerReportView.AllowUserToAddRows = false;
            this.CustomerReportView.AllowUserToDeleteRows = false;
            this.CustomerReportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerReportView.Location = new System.Drawing.Point(74, 208);
            this.CustomerReportView.Name = "CustomerReportView";
            this.CustomerReportView.ReadOnly = true;
            this.CustomerReportView.RowHeadersVisible = false;
            this.CustomerReportView.RowHeadersWidth = 82;
            this.CustomerReportView.RowTemplate.Height = 33;
            this.CustomerReportView.Size = new System.Drawing.Size(1101, 403);
            this.CustomerReportView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "System Log In Report";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CancelButton.Location = new System.Drawing.Point(74, 105);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(157, 52);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ReportButton.Location = new System.Drawing.Point(1014, 105);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(161, 52);
            this.ReportButton.TabIndex = 3;
            this.ReportButton.Text = "Report";
            this.ReportButton.UseVisualStyleBackColor = false;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // CustomerReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 675);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerReportView);
            this.Name = "CustomerReports";
            this.Text = "Customer Reports";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerReportView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerReportView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ReportButton;
    }
}