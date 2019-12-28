namespace RobertOgden
{
    partial class FrmReports
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
            this.MnuMenu = new System.Windows.Forms.MenuStrip();
            this.MnuApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAddresses = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAppointments = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCalendar = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.GrpReports = new System.Windows.Forms.GroupBox();
            this.LblInstructions = new System.Windows.Forms.Label();
            this.GrpReportChoices = new System.Windows.Forms.GroupBox();
            this.RdoOption3 = new System.Windows.Forms.RadioButton();
            this.RdoOption2 = new System.Windows.Forms.RadioButton();
            this.RdoOption1 = new System.Windows.Forms.RadioButton();
            this.DgvReportPreview = new System.Windows.Forms.DataGridView();
            this.LblHeader = new System.Windows.Forms.Label();
            this.MnuMenu.SuspendLayout();
            this.GrpReports.SuspendLayout();
            this.GrpReportChoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReportPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // MnuMenu
            // 
            this.MnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuApplications,
            this.MnuExit,
            this.MnuHelp});
            this.MnuMenu.Location = new System.Drawing.Point(0, 0);
            this.MnuMenu.Name = "MnuMenu";
            this.MnuMenu.Size = new System.Drawing.Size(1008, 24);
            this.MnuMenu.TabIndex = 5;
            this.MnuMenu.Text = "menuStrip1";
            // 
            // MnuApplications
            // 
            this.MnuApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAddresses,
            this.MnuAppointments,
            this.MnuCalendar,
            this.MnuCustomers,
            this.MnuReports});
            this.MnuApplications.Name = "MnuApplications";
            this.MnuApplications.Size = new System.Drawing.Size(85, 20);
            this.MnuApplications.Text = "A&pplications";
            // 
            // MnuAddresses
            // 
            this.MnuAddresses.Name = "MnuAddresses";
            this.MnuAddresses.Size = new System.Drawing.Size(150, 22);
            this.MnuAddresses.Text = "Addresses";
            this.MnuAddresses.Click += new System.EventHandler(this.MnuAddresses_Click);
            // 
            // MnuAppointments
            // 
            this.MnuAppointments.Name = "MnuAppointments";
            this.MnuAppointments.ShortcutKeyDisplayString = "";
            this.MnuAppointments.Size = new System.Drawing.Size(150, 22);
            this.MnuAppointments.Text = "&Appointments";
            this.MnuAppointments.Click += new System.EventHandler(this.MnuAppointments_Click);
            // 
            // MnuCalendar
            // 
            this.MnuCalendar.Name = "MnuCalendar";
            this.MnuCalendar.Size = new System.Drawing.Size(150, 22);
            this.MnuCalendar.Text = "&Calendar";
            this.MnuCalendar.Click += new System.EventHandler(this.MnuCalendar_Click);
            // 
            // MnuCustomers
            // 
            this.MnuCustomers.Name = "MnuCustomers";
            this.MnuCustomers.Size = new System.Drawing.Size(150, 22);
            this.MnuCustomers.Text = "C&ustomers";
            this.MnuCustomers.Click += new System.EventHandler(this.MnuCustomers_Click);
            // 
            // MnuReports
            // 
            this.MnuReports.Checked = true;
            this.MnuReports.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuReports.Name = "MnuReports";
            this.MnuReports.Size = new System.Drawing.Size(150, 22);
            this.MnuReports.Text = "&Reports";
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(37, 20);
            this.MnuExit.Text = "E&xit";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // MnuHelp
            // 
            this.MnuHelp.Name = "MnuHelp";
            this.MnuHelp.Size = new System.Drawing.Size(44, 20);
            this.MnuHelp.Text = "H&elp";
            this.MnuHelp.Click += new System.EventHandler(this.MnuHelp_Click);
            // 
            // GrpReports
            // 
            this.GrpReports.Controls.Add(this.LblInstructions);
            this.GrpReports.Controls.Add(this.GrpReportChoices);
            this.GrpReports.Controls.Add(this.DgvReportPreview);
            this.GrpReports.Controls.Add(this.LblHeader);
            this.GrpReports.Location = new System.Drawing.Point(12, 27);
            this.GrpReports.Name = "GrpReports";
            this.GrpReports.Size = new System.Drawing.Size(984, 447);
            this.GrpReports.TabIndex = 6;
            this.GrpReports.TabStop = false;
            // 
            // LblInstructions
            // 
            this.LblInstructions.AutoSize = true;
            this.LblInstructions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInstructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblInstructions.Location = new System.Drawing.Point(270, 13);
            this.LblInstructions.Name = "LblInstructions";
            this.LblInstructions.Size = new System.Drawing.Size(425, 20);
            this.LblInstructions.TabIndex = 1;
            this.LblInstructions.Text = "Currently displaying number of appointment types by month";
            // 
            // GrpReportChoices
            // 
            this.GrpReportChoices.Controls.Add(this.RdoOption3);
            this.GrpReportChoices.Controls.Add(this.RdoOption2);
            this.GrpReportChoices.Controls.Add(this.RdoOption1);
            this.GrpReportChoices.Location = new System.Drawing.Point(26, 315);
            this.GrpReportChoices.Name = "GrpReportChoices";
            this.GrpReportChoices.Size = new System.Drawing.Size(311, 116);
            this.GrpReportChoices.TabIndex = 3;
            this.GrpReportChoices.TabStop = false;
            this.GrpReportChoices.Text = "Select the report to run: ";
            // 
            // RdoOption3
            // 
            this.RdoOption3.AutoSize = true;
            this.RdoOption3.Location = new System.Drawing.Point(22, 82);
            this.RdoOption3.Name = "RdoOption3";
            this.RdoOption3.Size = new System.Drawing.Size(272, 17);
            this.RdoOption3.TabIndex = 2;
            this.RdoOption3.Text = "Appointments for the city with the most appointments";
            this.RdoOption3.UseVisualStyleBackColor = true;
            this.RdoOption3.CheckedChanged += new System.EventHandler(this.RdoOption3_CheckedChanged);
            // 
            // RdoOption2
            // 
            this.RdoOption2.AutoSize = true;
            this.RdoOption2.Location = new System.Drawing.Point(22, 56);
            this.RdoOption2.Name = "RdoOption2";
            this.RdoOption2.Size = new System.Drawing.Size(160, 17);
            this.RdoOption2.TabIndex = 1;
            this.RdoOption2.Text = "Schedules for all consultants";
            this.RdoOption2.UseVisualStyleBackColor = true;
            this.RdoOption2.CheckedChanged += new System.EventHandler(this.RdoOption2_CheckedChanged);
            // 
            // RdoOption1
            // 
            this.RdoOption1.AutoSize = true;
            this.RdoOption1.Checked = true;
            this.RdoOption1.Location = new System.Drawing.Point(22, 31);
            this.RdoOption1.Name = "RdoOption1";
            this.RdoOption1.Size = new System.Drawing.Size(209, 17);
            this.RdoOption1.TabIndex = 4;
            this.RdoOption1.TabStop = true;
            this.RdoOption1.Text = "Number of appointment types by month";
            this.RdoOption1.UseVisualStyleBackColor = true;
            this.RdoOption1.CheckedChanged += new System.EventHandler(this.RdoOption1_CheckedChanged);
            // 
            // DgvReportPreview
            // 
            this.DgvReportPreview.AllowUserToAddRows = false;
            this.DgvReportPreview.AllowUserToDeleteRows = false;
            this.DgvReportPreview.AllowUserToResizeRows = false;
            this.DgvReportPreview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvReportPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReportPreview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvReportPreview.Location = new System.Drawing.Point(21, 39);
            this.DgvReportPreview.Name = "DgvReportPreview";
            this.DgvReportPreview.RowHeadersVisible = false;
            this.DgvReportPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvReportPreview.Size = new System.Drawing.Size(942, 262);
            this.DgvReportPreview.TabIndex = 2;
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.Location = new System.Drawing.Point(17, 13);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(74, 20);
            this.LblHeader.TabIndex = 0;
            this.LblHeader.Text = "Reports: ";
            // 
            // FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 482);
            this.Controls.Add(this.GrpReports);
            this.Controls.Add(this.MnuMenu);
            this.Name = "FrmReports";
            this.Text = "FrmReports";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmReports_MouseMove);
            this.MnuMenu.ResumeLayout(false);
            this.MnuMenu.PerformLayout();
            this.GrpReports.ResumeLayout(false);
            this.GrpReports.PerformLayout();
            this.GrpReportChoices.ResumeLayout(false);
            this.GrpReportChoices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReportPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MnuMenu;
        private System.Windows.Forms.ToolStripMenuItem MnuApplications;
        private System.Windows.Forms.ToolStripMenuItem MnuAddresses;
        private System.Windows.Forms.ToolStripMenuItem MnuAppointments;
        private System.Windows.Forms.ToolStripMenuItem MnuCalendar;
        private System.Windows.Forms.ToolStripMenuItem MnuCustomers;
        private System.Windows.Forms.ToolStripMenuItem MnuReports;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.GroupBox GrpReports;
        private System.Windows.Forms.DataGridView DgvReportPreview;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.GroupBox GrpReportChoices;
        private System.Windows.Forms.RadioButton RdoOption3;
        private System.Windows.Forms.RadioButton RdoOption2;
        private System.Windows.Forms.RadioButton RdoOption1;
        private System.Windows.Forms.Label LblInstructions;
        private System.Windows.Forms.ToolStripMenuItem MnuHelp;
    }
}