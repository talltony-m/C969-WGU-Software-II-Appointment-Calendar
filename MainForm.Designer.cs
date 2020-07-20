namespace C969_Software_2
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AppointmentCalendar = new System.Windows.Forms.DataGridView();
            this.WeekRadioButton = new System.Windows.Forms.RadioButton();
            this.MonthViewRadioButton = new System.Windows.Forms.RadioButton();
            this.CreateCustomerButton = new System.Windows.Forms.Button();
            this.UpdateCustomerButton = new System.Windows.Forms.Button();
            this.DeleteCustomerButton = new System.Windows.Forms.Button();
            this.LogInReportButton = new System.Windows.Forms.Button();
            this.AddAppointmentButton = new System.Windows.Forms.Button();
            this.UpdateAppointmentButton = new System.Windows.Forms.Button();
            this.DeleteAppointmentButton = new System.Windows.Forms.Button();
            this.AppointmentButton = new System.Windows.Forms.Button();
            this.ScheduleButton = new System.Windows.Forms.Button();
            this.apptGroupBox = new System.Windows.Forms.GroupBox();
            this.CustGroupBox = new System.Windows.Forms.GroupBox();
            this.ReportGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentCalendar)).BeginInit();
            this.apptGroupBox.SuspendLayout();
            this.CustGroupBox.SuspendLayout();
            this.ReportGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(605, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(760, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer and Appointment Management System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(821, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Appointmnet Calendar";
            // 
            // AppointmentCalendar
            // 
            this.AppointmentCalendar.AllowUserToAddRows = false;
            this.AppointmentCalendar.AllowUserToDeleteRows = false;
            this.AppointmentCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentCalendar.Location = new System.Drawing.Point(34, 511);
            this.AppointmentCalendar.MultiSelect = false;
            this.AppointmentCalendar.Name = "AppointmentCalendar";
            this.AppointmentCalendar.ReadOnly = true;
            this.AppointmentCalendar.RowHeadersVisible = false;
            this.AppointmentCalendar.RowHeadersWidth = 82;
            this.AppointmentCalendar.RowTemplate.Height = 33;
            this.AppointmentCalendar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentCalendar.ShowEditingIcon = false;
            this.AppointmentCalendar.Size = new System.Drawing.Size(1812, 465);
            this.AppointmentCalendar.TabIndex = 4;
            this.AppointmentCalendar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentCalendar_CellContentClick);
            // 
            // WeekRadioButton
            // 
            this.WeekRadioButton.AutoSize = true;
            this.WeekRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekRadioButton.Location = new System.Drawing.Point(743, 465);
            this.WeekRadioButton.Name = "WeekRadioButton";
            this.WeekRadioButton.Size = new System.Drawing.Size(215, 35);
            this.WeekRadioButton.TabIndex = 5;
            this.WeekRadioButton.TabStop = true;
            this.WeekRadioButton.Text = "Weekley View";
            this.WeekRadioButton.UseVisualStyleBackColor = true;
            this.WeekRadioButton.CheckedChanged += new System.EventHandler(this.WeekRadioButton_CheckedChanged);
            // 
            // MonthViewRadioButton
            // 
            this.MonthViewRadioButton.AutoSize = true;
            this.MonthViewRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthViewRadioButton.Location = new System.Drawing.Point(1042, 465);
            this.MonthViewRadioButton.Name = "MonthViewRadioButton";
            this.MonthViewRadioButton.Size = new System.Drawing.Size(206, 35);
            this.MonthViewRadioButton.TabIndex = 6;
            this.MonthViewRadioButton.TabStop = true;
            this.MonthViewRadioButton.Text = "Monthly View";
            this.MonthViewRadioButton.UseVisualStyleBackColor = true;
            // 
            // CreateCustomerButton
            // 
            this.CreateCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CreateCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateCustomerButton.Location = new System.Drawing.Point(44, 40);
            this.CreateCustomerButton.Name = "CreateCustomerButton";
            this.CreateCustomerButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CreateCustomerButton.Size = new System.Drawing.Size(249, 67);
            this.CreateCustomerButton.TabIndex = 7;
            this.CreateCustomerButton.Text = "Create Customer";
            this.CreateCustomerButton.UseVisualStyleBackColor = false;
            this.CreateCustomerButton.Click += new System.EventHandler(this.CreateCustomerButton_Click);
            // 
            // UpdateCustomerButton
            // 
            this.UpdateCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.UpdateCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCustomerButton.Location = new System.Drawing.Point(335, 40);
            this.UpdateCustomerButton.Name = "UpdateCustomerButton";
            this.UpdateCustomerButton.Size = new System.Drawing.Size(299, 67);
            this.UpdateCustomerButton.TabIndex = 8;
            this.UpdateCustomerButton.Text = "Update Customer";
            this.UpdateCustomerButton.UseVisualStyleBackColor = false;
            this.UpdateCustomerButton.Click += new System.EventHandler(this.UpdateCustomerButton_Click);
            // 
            // DeleteCustomerButton
            // 
            this.DeleteCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCustomerButton.Location = new System.Drawing.Point(673, 40);
            this.DeleteCustomerButton.Name = "DeleteCustomerButton";
            this.DeleteCustomerButton.Size = new System.Drawing.Size(292, 67);
            this.DeleteCustomerButton.TabIndex = 9;
            this.DeleteCustomerButton.Text = "Delete Customer";
            this.DeleteCustomerButton.UseVisualStyleBackColor = false;
            this.DeleteCustomerButton.Click += new System.EventHandler(this.DeleteCustomerButton_Click);
            // 
            // LogInReportButton
            // 
            this.LogInReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LogInReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInReportButton.Location = new System.Drawing.Point(209, 194);
            this.LogInReportButton.Name = "LogInReportButton";
            this.LogInReportButton.Size = new System.Drawing.Size(359, 67);
            this.LogInReportButton.TabIndex = 10;
            this.LogInReportButton.Text = "Log In Reports";
            this.LogInReportButton.UseVisualStyleBackColor = false;
            this.LogInReportButton.Click += new System.EventHandler(this.LogInReportButton_Click);
            // 
            // AddAppointmentButton
            // 
            this.AddAppointmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAppointmentButton.Location = new System.Drawing.Point(44, 37);
            this.AddAppointmentButton.Name = "AddAppointmentButton";
            this.AddAppointmentButton.Size = new System.Drawing.Size(249, 67);
            this.AddAppointmentButton.TabIndex = 11;
            this.AddAppointmentButton.Text = "Add Appointment";
            this.AddAppointmentButton.UseVisualStyleBackColor = false;
            this.AddAppointmentButton.Click += new System.EventHandler(this.AddAppointmentButton_Click);
            // 
            // UpdateAppointmentButton
            // 
            this.UpdateAppointmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.UpdateAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAppointmentButton.Location = new System.Drawing.Point(335, 37);
            this.UpdateAppointmentButton.Name = "UpdateAppointmentButton";
            this.UpdateAppointmentButton.Size = new System.Drawing.Size(299, 67);
            this.UpdateAppointmentButton.TabIndex = 12;
            this.UpdateAppointmentButton.Text = "Update Appointment";
            this.UpdateAppointmentButton.UseVisualStyleBackColor = false;
            this.UpdateAppointmentButton.Click += new System.EventHandler(this.UpdateAppointmentButton_Click);
            // 
            // DeleteAppointmentButton
            // 
            this.DeleteAppointmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAppointmentButton.Location = new System.Drawing.Point(673, 37);
            this.DeleteAppointmentButton.Name = "DeleteAppointmentButton";
            this.DeleteAppointmentButton.Size = new System.Drawing.Size(292, 67);
            this.DeleteAppointmentButton.TabIndex = 13;
            this.DeleteAppointmentButton.Text = "Delete Appointment";
            this.DeleteAppointmentButton.UseVisualStyleBackColor = false;
            this.DeleteAppointmentButton.Click += new System.EventHandler(this.DeleteAppointmentButton_Click);
            // 
            // AppointmentButton
            // 
            this.AppointmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentButton.Location = new System.Drawing.Point(31, 40);
            this.AppointmentButton.Name = "AppointmentButton";
            this.AppointmentButton.Size = new System.Drawing.Size(359, 67);
            this.AppointmentButton.TabIndex = 14;
            this.AppointmentButton.Text = "Appointments by Month";
            this.AppointmentButton.UseVisualStyleBackColor = false;
            this.AppointmentButton.Click += new System.EventHandler(this.AppointmentButton_Click);
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleButton.Location = new System.Drawing.Point(415, 40);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.Size = new System.Drawing.Size(357, 67);
            this.ScheduleButton.TabIndex = 15;
            this.ScheduleButton.Text = "Schedule by Consultant";
            this.ScheduleButton.UseVisualStyleBackColor = false;
            this.ScheduleButton.Click += new System.EventHandler(this.ScheduleButton_Click);
            // 
            // apptGroupBox
            // 
            this.apptGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.apptGroupBox.Controls.Add(this.AddAppointmentButton);
            this.apptGroupBox.Controls.Add(this.UpdateAppointmentButton);
            this.apptGroupBox.Controls.Add(this.DeleteAppointmentButton);
            this.apptGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptGroupBox.Location = new System.Drawing.Point(12, 261);
            this.apptGroupBox.Name = "apptGroupBox";
            this.apptGroupBox.Size = new System.Drawing.Size(999, 126);
            this.apptGroupBox.TabIndex = 17;
            this.apptGroupBox.TabStop = false;
            this.apptGroupBox.Text = "Appointments";
            // 
            // CustGroupBox
            // 
            this.CustGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CustGroupBox.Controls.Add(this.CreateCustomerButton);
            this.CustGroupBox.Controls.Add(this.UpdateCustomerButton);
            this.CustGroupBox.Controls.Add(this.DeleteCustomerButton);
            this.CustGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustGroupBox.Location = new System.Drawing.Point(12, 104);
            this.CustGroupBox.Name = "CustGroupBox";
            this.CustGroupBox.Size = new System.Drawing.Size(999, 129);
            this.CustGroupBox.TabIndex = 18;
            this.CustGroupBox.TabStop = false;
            this.CustGroupBox.Text = "Customers";
            // 
            // ReportGroupBox
            // 
            this.ReportGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ReportGroupBox.Controls.Add(this.AppointmentButton);
            this.ReportGroupBox.Controls.Add(this.ScheduleButton);
            this.ReportGroupBox.Controls.Add(this.LogInReportButton);
            this.ReportGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportGroupBox.Location = new System.Drawing.Point(1042, 104);
            this.ReportGroupBox.Name = "ReportGroupBox";
            this.ReportGroupBox.Size = new System.Drawing.Size(804, 283);
            this.ReportGroupBox.TabIndex = 19;
            this.ReportGroupBox.TabStop = false;
            this.ReportGroupBox.Text = "Reports";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1885, 1000);
            this.Controls.Add(this.ReportGroupBox);
            this.Controls.Add(this.CustGroupBox);
            this.Controls.Add(this.apptGroupBox);
            this.Controls.Add(this.MonthViewRadioButton);
            this.Controls.Add(this.WeekRadioButton);
            this.Controls.Add(this.AppointmentCalendar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentCalendar)).EndInit();
            this.apptGroupBox.ResumeLayout(false);
            this.CustGroupBox.ResumeLayout(false);
            this.ReportGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView AppointmentCalendar;
        private System.Windows.Forms.RadioButton WeekRadioButton;
        private System.Windows.Forms.RadioButton MonthViewRadioButton;
        private System.Windows.Forms.Button CreateCustomerButton;
        private System.Windows.Forms.Button UpdateCustomerButton;
        private System.Windows.Forms.Button DeleteCustomerButton;
        private System.Windows.Forms.Button LogInReportButton;
        private System.Windows.Forms.Button AddAppointmentButton;
        private System.Windows.Forms.Button UpdateAppointmentButton;
        private System.Windows.Forms.Button DeleteAppointmentButton;
        private System.Windows.Forms.Button AppointmentButton;
        private System.Windows.Forms.Button ScheduleButton;
        private System.Windows.Forms.GroupBox apptGroupBox;
        private System.Windows.Forms.GroupBox CustGroupBox;
        private System.Windows.Forms.GroupBox ReportGroupBox;
    }
}