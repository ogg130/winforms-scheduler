namespace RobertOgden
{
    partial class FrmCalendar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MnuMenu = new System.Windows.Forms.MenuStrip();
            this.MnuApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAddresses = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAppointments = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCalendar = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.GrpCalendar = new System.Windows.Forms.GroupBox();
            this.LblInstructions = new System.Windows.Forms.Label();
            this.LblOf = new System.Windows.Forms.Label();
            this.GrpViewType = new System.Windows.Forms.GroupBox();
            this.RdoWeek = new System.Windows.Forms.RadioButton();
            this.RdoMonth = new System.Windows.Forms.RadioButton();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.LblViewType = new System.Windows.Forms.Label();
            this.LblHeader = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DgvCalendar = new System.Windows.Forms.DataGridView();
            this._timers = new System.Windows.Forms.Timer(this.components);
            this.MnuMenu.SuspendLayout();
            this.GrpCalendar.SuspendLayout();
            this.GrpViewType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCalendar)).BeginInit();
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
            this.MnuMenu.TabIndex = 10;
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
            this.MnuCalendar.Checked = true;
            this.MnuCalendar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuCalendar.Name = "MnuCalendar";
            this.MnuCalendar.Size = new System.Drawing.Size(150, 22);
            this.MnuCalendar.Text = "&Calendar";
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
            this.MnuReports.Name = "MnuReports";
            this.MnuReports.Size = new System.Drawing.Size(150, 22);
            this.MnuReports.Text = "&Reports";
            this.MnuReports.Click += new System.EventHandler(this.MnuReports_Click);
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
            // GrpCalendar
            // 
            this.GrpCalendar.Controls.Add(this.LblInstructions);
            this.GrpCalendar.Controls.Add(this.LblOf);
            this.GrpCalendar.Controls.Add(this.GrpViewType);
            this.GrpCalendar.Controls.Add(this.DtpDate);
            this.GrpCalendar.Controls.Add(this.LblViewType);
            this.GrpCalendar.Controls.Add(this.LblHeader);
            this.GrpCalendar.Controls.Add(this.TxtSearch);
            this.GrpCalendar.Controls.Add(this.BtnSearch);
            this.GrpCalendar.Controls.Add(this.DgvCalendar);
            this.GrpCalendar.Location = new System.Drawing.Point(5, 27);
            this.GrpCalendar.Name = "GrpCalendar";
            this.GrpCalendar.Size = new System.Drawing.Size(991, 410);
            this.GrpCalendar.TabIndex = 11;
            this.GrpCalendar.TabStop = false;
            // 
            // LblInstructions
            // 
            this.LblInstructions.AutoSize = true;
            this.LblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInstructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblInstructions.Location = new System.Drawing.Point(207, 16);
            this.LblInstructions.Name = "LblInstructions";
            this.LblInstructions.Size = new System.Drawing.Size(262, 20);
            this.LblInstructions.TabIndex = 1;
            this.LblInstructions.Text = "You have no appointments to show.";
            // 
            // LblOf
            // 
            this.LblOf.AutoSize = true;
            this.LblOf.Location = new System.Drawing.Point(300, 353);
            this.LblOf.Name = "LblOf";
            this.LblOf.Size = new System.Drawing.Size(16, 13);
            this.LblOf.TabIndex = 8;
            this.LblOf.Text = "of";
            // 
            // GrpViewType
            // 
            this.GrpViewType.Controls.Add(this.RdoWeek);
            this.GrpViewType.Controls.Add(this.RdoMonth);
            this.GrpViewType.Location = new System.Drawing.Point(229, 340);
            this.GrpViewType.Name = "GrpViewType";
            this.GrpViewType.Size = new System.Drawing.Size(65, 61);
            this.GrpViewType.TabIndex = 6;
            this.GrpViewType.TabStop = false;
            // 
            // RdoWeek
            // 
            this.RdoWeek.AutoSize = true;
            this.RdoWeek.Location = new System.Drawing.Point(6, 34);
            this.RdoWeek.Name = "RdoWeek";
            this.RdoWeek.Size = new System.Drawing.Size(51, 17);
            this.RdoWeek.TabIndex = 1;
            this.RdoWeek.Text = "week";
            this.RdoWeek.UseVisualStyleBackColor = true;
            this.RdoWeek.CheckedChanged += new System.EventHandler(this.RdoWeek_CheckedChanged);
            // 
            // RdoMonth
            // 
            this.RdoMonth.AutoSize = true;
            this.RdoMonth.Checked = true;
            this.RdoMonth.Location = new System.Drawing.Point(6, 11);
            this.RdoMonth.Name = "RdoMonth";
            this.RdoMonth.Size = new System.Drawing.Size(54, 17);
            this.RdoMonth.TabIndex = 0;
            this.RdoMonth.TabStop = true;
            this.RdoMonth.Tag = "7";
            this.RdoMonth.Text = "month";
            this.RdoMonth.UseVisualStyleBackColor = true;
            this.RdoMonth.CheckedChanged += new System.EventHandler(this.RdoMonth_CheckedChanged);
            // 
            // DtpDate
            // 
            this.DtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDate.CustomFormat = "MMMM";
            this.DtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpDate.Location = new System.Drawing.Point(322, 349);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(251, 20);
            this.DtpDate.TabIndex = 9;
            this.DtpDate.ValueChanged += new System.EventHandler(this.DtpDate_ValueChanged);
            // 
            // LblViewType
            // 
            this.LblViewType.AutoSize = true;
            this.LblViewType.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LblViewType.Location = new System.Drawing.Point(20, 353);
            this.LblViewType.Name = "LblViewType";
            this.LblViewType.Size = new System.Drawing.Size(209, 13);
            this.LblViewType.TabIndex = 5;
            this.LblViewType.Text = "Currently viewing your appointments for the";
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.Location = new System.Drawing.Point(13, 16);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(115, 20);
            this.LblHeader.TabIndex = 0;
            this.LblHeader.Text = "Your Calendar:";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtSearch.Location = new System.Drawing.Point(693, 13);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(212, 23);
            this.TxtSearch.TabIndex = 2;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(911, 13);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(59, 23);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DgvCalendar
            // 
            this.DgvCalendar.AllowUserToAddRows = false;
            this.DgvCalendar.AllowUserToDeleteRows = false;
            this.DgvCalendar.AllowUserToResizeRows = false;
            this.DgvCalendar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCalendar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCalendar.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCalendar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvCalendar.Location = new System.Drawing.Point(17, 42);
            this.DgvCalendar.MultiSelect = false;
            this.DgvCalendar.Name = "DgvCalendar";
            this.DgvCalendar.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCalendar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCalendar.RowHeadersVisible = false;
            this.DgvCalendar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCalendar.Size = new System.Drawing.Size(954, 298);
            this.DgvCalendar.TabIndex = 4;
            this.DgvCalendar.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCalendar_CellMouseDoubleClick);
            // 
            // _timers
            // 
            this._timers.Enabled = true;
            this._timers.Interval = 1000;
            //this._timers.Tick += new System.EventHandler(this._timers_Tick);
            // 
            // FrmCalendar
            // 
            this.AcceptButton = this.BtnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 445);
            this.Controls.Add(this.GrpCalendar);
            this.Controls.Add(this.MnuMenu);
            this.Name = "FrmCalendar";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.FrmCalendar_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmCalendar_MouseMove);
            this.MnuMenu.ResumeLayout(false);
            this.MnuMenu.PerformLayout();
            this.GrpCalendar.ResumeLayout(false);
            this.GrpCalendar.PerformLayout();
            this.GrpViewType.ResumeLayout(false);
            this.GrpViewType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCalendar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MnuMenu;
        private System.Windows.Forms.ToolStripMenuItem MnuApplications;
        private System.Windows.Forms.ToolStripMenuItem MnuAppointments;
        private System.Windows.Forms.ToolStripMenuItem MnuCalendar;
        private System.Windows.Forms.ToolStripMenuItem MnuCustomers;
        private System.Windows.Forms.ToolStripMenuItem MnuReports;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.GroupBox GrpCalendar;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView DgvCalendar;
        private System.Windows.Forms.Label LblViewType;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.Label LblOf;
        private System.Windows.Forms.GroupBox GrpViewType;
        private System.Windows.Forms.RadioButton RdoWeek;
        private System.Windows.Forms.RadioButton RdoMonth;
        private System.Windows.Forms.Label LblInstructions;
        private System.Windows.Forms.Timer _timers;
        private System.Windows.Forms.ToolStripMenuItem MnuAddresses;
        private System.Windows.Forms.ToolStripMenuItem MnuHelp;
    }
}