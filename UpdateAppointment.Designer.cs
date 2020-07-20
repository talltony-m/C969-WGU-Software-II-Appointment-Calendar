namespace C969_Software_2
{
    partial class UpdateAppointment
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
            this.UpdateAppLabel = new System.Windows.Forms.Label();
            this.ApptIdLabel = new System.Windows.Forms.Label();
            this.CustomerIdLabel = new System.Windows.Forms.Label();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.CustomerIdBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.StartLabel = new System.Windows.Forms.Label();
            this.EndLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.StartTimeBox = new System.Windows.Forms.TextBox();
            this.EndTimeBox = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpdateAppLabel
            // 
            this.UpdateAppLabel.AutoSize = true;
            this.UpdateAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAppLabel.Location = new System.Drawing.Point(306, 62);
            this.UpdateAppLabel.Name = "UpdateAppLabel";
            this.UpdateAppLabel.Size = new System.Drawing.Size(279, 31);
            this.UpdateAppLabel.TabIndex = 0;
            this.UpdateAppLabel.Text = "Update Appointment";
            // 
            // ApptIdLabel
            // 
            this.ApptIdLabel.AutoSize = true;
            this.ApptIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApptIdLabel.Location = new System.Drawing.Point(81, 147);
            this.ApptIdLabel.Name = "ApptIdLabel";
            this.ApptIdLabel.Size = new System.Drawing.Size(201, 31);
            this.ApptIdLabel.TabIndex = 1;
            this.ApptIdLabel.Text = "Appointment ID";
            // 
            // CustomerIdLabel
            // 
            this.CustomerIdLabel.AutoSize = true;
            this.CustomerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIdLabel.Location = new System.Drawing.Point(81, 259);
            this.CustomerIdLabel.Name = "CustomerIdLabel";
            this.CustomerIdLabel.Size = new System.Drawing.Size(167, 31);
            this.CustomerIdLabel.TabIndex = 2;
            this.CustomerIdLabel.Text = "Customer ID";
            // 
            // SearchBar
            // 
            this.SearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBar.Location = new System.Drawing.Point(343, 147);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(205, 38);
            this.SearchBar.TabIndex = 3;
            // 
            // CustomerIdBox
            // 
            this.CustomerIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIdBox.Location = new System.Drawing.Point(87, 314);
            this.CustomerIdBox.Name = "CustomerIdBox";
            this.CustomerIdBox.Size = new System.Drawing.Size(245, 38);
            this.CustomerIdBox.TabIndex = 4;
            this.CustomerIdBox.TextChanged += new System.EventHandler(this.CustomerIdBox_TextChanged);
            // 
            // TypeBox
            // 
            this.TypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeBox.Location = new System.Drawing.Point(513, 314);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(245, 38);
            this.TypeBox.TabIndex = 5;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(583, 259);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(75, 31);
            this.TypeLabel.TabIndex = 6;
            this.TypeLabel.Text = "Type";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(589, 137);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(169, 50);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLabel.Location = new System.Drawing.Point(81, 390);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(256, 31);
            this.StartLabel.TabIndex = 8;
            this.StartLabel.Text = "Start Date and Time";
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndLabel.Location = new System.Drawing.Point(507, 390);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(246, 31);
            this.EndLabel.TabIndex = 9;
            this.EndLabel.Text = "End Date and Time";
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(598, 569);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(155, 53);
            this.UpdateButton.TabIndex = 12;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click_1);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(87, 569);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(155, 53);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StartTimeBox
            // 
            this.StartTimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeBox.Location = new System.Drawing.Point(87, 478);
            this.StartTimeBox.Name = "StartTimeBox";
            this.StartTimeBox.Size = new System.Drawing.Size(279, 38);
            this.StartTimeBox.TabIndex = 14;
            // 
            // EndTimeBox
            // 
            this.EndTimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeBox.Location = new System.Drawing.Point(508, 478);
            this.EndTimeBox.Name = "EndTimeBox";
            this.EndTimeBox.Size = new System.Drawing.Size(273, 38);
            this.EndTimeBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "mm/dd/yyyy HH:mm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "mm/dd/yyyy HH:mm";
            // 
            // UpdateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 664);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndTimeBox);
            this.Controls.Add(this.StartTimeBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.CustomerIdBox);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.CustomerIdLabel);
            this.Controls.Add(this.ApptIdLabel);
            this.Controls.Add(this.UpdateAppLabel);
            this.Name = "UpdateAppointment";
            this.Text = "Update Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpdateAppLabel;
        private System.Windows.Forms.Label ApptIdLabel;
        private System.Windows.Forms.Label CustomerIdLabel;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.TextBox CustomerIdBox;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.Button UpdateButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox StartTimeBox;
        private System.Windows.Forms.TextBox EndTimeBox;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}