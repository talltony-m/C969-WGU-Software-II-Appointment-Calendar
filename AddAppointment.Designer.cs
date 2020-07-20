namespace C969_Software_2
{
    partial class AddAppointment
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerIdLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.EndLabel = new System.Windows.Forms.Label();
            this.CustomerIDBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.StartTimeBox = new System.Windows.Forms.TextBox();
            this.EndTimeBox = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(108, 537);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(133, 49);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(566, 537);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(133, 49);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Appointment to Calendar";
            // 
            // CustomerIdLabel
            // 
            this.CustomerIdLabel.AutoSize = true;
            this.CustomerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIdLabel.Location = new System.Drawing.Point(147, 190);
            this.CustomerIdLabel.Name = "CustomerIdLabel";
            this.CustomerIdLabel.Size = new System.Drawing.Size(167, 31);
            this.CustomerIdLabel.TabIndex = 3;
            this.CustomerIdLabel.Text = "Customer ID";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(455, 190);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(75, 31);
            this.TypeLabel.TabIndex = 4;
            this.TypeLabel.Text = "Type";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLabel.Location = new System.Drawing.Point(147, 345);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(204, 31);
            this.StartLabel.TabIndex = 5;
            this.StartLabel.Text = "Start Date Time";
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndLabel.Location = new System.Drawing.Point(455, 345);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(194, 31);
            this.EndLabel.TabIndex = 6;
            this.EndLabel.Text = "End Date Time";
            // 
            // CustomerIDBox
            // 
            this.CustomerIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDBox.Location = new System.Drawing.Point(153, 254);
            this.CustomerIDBox.Name = "CustomerIDBox";
            this.CustomerIDBox.Size = new System.Drawing.Size(161, 38);
            this.CustomerIDBox.TabIndex = 7;
            this.CustomerIDBox.TextChanged += new System.EventHandler(this.CustomerIDBox_TextChanged);
            // 
            // TypeBox
            // 
            this.TypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeBox.Location = new System.Drawing.Point(461, 254);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(161, 38);
            this.TypeBox.TabIndex = 8;
            this.TypeBox.TextChanged += new System.EventHandler(this.TypeBox_TextChanged);
            // 
            // StartTimeBox
            // 
            this.StartTimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeBox.Location = new System.Drawing.Point(153, 436);
            this.StartTimeBox.Name = "StartTimeBox";
            this.StartTimeBox.Size = new System.Drawing.Size(161, 38);
            this.StartTimeBox.TabIndex = 9;
            this.StartTimeBox.TextChanged += new System.EventHandler(this.StartTimeBox_TextChanged);
            // 
            // EndTimeBox
            // 
            this.EndTimeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeBox.Location = new System.Drawing.Point(461, 436);
            this.EndTimeBox.Name = "EndTimeBox";
            this.EndTimeBox.Size = new System.Drawing.Size(161, 38);
            this.EndTimeBox.TabIndex = 10;
            this.EndTimeBox.TextChanged += new System.EventHandler(this.EndTimeBox_TextChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(153, 395);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(196, 25);
            this.Label6.TabIndex = 11;
            this.Label6.Text = "mm/dd/yyyy hh:mm";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(461, 395);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(196, 25);
            this.Label7.TabIndex = 12;
            this.Label7.Text = "mm/dd/yyyy hh:mm";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(328, 537);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(133, 49);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 646);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.EndTimeBox);
            this.Controls.Add(this.StartTimeBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.CustomerIDBox);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.CustomerIdLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "AddAppointment";
            this.Text = " ";
            this.Load += new System.EventHandler(this.AddAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CustomerIdLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.TextBox CustomerIDBox;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.TextBox StartTimeBox;
        private System.Windows.Forms.TextBox EndTimeBox;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Button ClearButton;
    }
}