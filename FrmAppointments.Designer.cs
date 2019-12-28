namespace RobertOgden
{
    partial class FrmAppointments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAppointments));
            this.DgvAppointments = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnDeleteAppointment = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnModifyAppointment = new System.Windows.Forms.Button();
            this.BtnAddAppointment = new System.Windows.Forms.Button();
            this.GrpAppointmentData = new System.Windows.Forms.GroupBox();
            this.BtnLaunch = new System.Windows.Forms.Button();
            this.LblCustomerName = new System.Windows.Forms.Label();
            this.TxtCustomerName = new System.Windows.Forms.TextBox();
            this.LblUserName = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.DtpLastUpdate = new System.Windows.Forms.DateTimePicker();
            this.DtpEnd = new System.Windows.Forms.DateTimePicker();
            this.DtpStart = new System.Windows.Forms.DateTimePicker();
            this.DtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.CboCustomerId = new System.Windows.Forms.ComboBox();
            this.CboUserId = new System.Windows.Forms.ComboBox();
            this.LblLastUpdateBy = new System.Windows.Forms.Label();
            this.TxtLastUpdateBy = new System.Windows.Forms.TextBox();
            this.LblLastUpdate = new System.Windows.Forms.Label();
            this.LblCreatedBy = new System.Windows.Forms.Label();
            this.TxtCreatedBy = new System.Windows.Forms.TextBox();
            this.LblCreateDate = new System.Windows.Forms.Label();
            this.LblEnd = new System.Windows.Forms.Label();
            this.LblStart = new System.Windows.Forms.Label();
            this.LblUrl = new System.Windows.Forms.Label();
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.LblType = new System.Windows.Forms.Label();
            this.TxtType = new System.Windows.Forms.TextBox();
            this.LblContact = new System.Windows.Forms.Label();
            this.TxtContact = new System.Windows.Forms.TextBox();
            this.LblLocation = new System.Windows.Forms.Label();
            this.TxtLocation = new System.Windows.Forms.TextBox();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.LblUserId = new System.Windows.Forms.Label();
            this.LblCustomerId = new System.Windows.Forms.Label();
            this.LblAppointmentId = new System.Windows.Forms.Label();
            this.TxtAppointmentId = new System.Windows.Forms.TextBox();
            this.MnuMenu = new System.Windows.Forms.MenuStrip();
            this.MnuApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAddresses = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAppointments = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCalendar = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblHeader = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this._timers = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAppointments)).BeginInit();
            this.GrpAppointmentData.SuspendLayout();
            this.MnuMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvAppointments
            // 
            this.DgvAppointments.AllowUserToAddRows = false;
            this.DgvAppointments.AllowUserToDeleteRows = false;
            this.DgvAppointments.AllowUserToResizeRows = false;
            this.DgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvAppointments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvAppointments.Location = new System.Drawing.Point(26, 71);
            this.DgvAppointments.MultiSelect = false;
            this.DgvAppointments.Name = "DgvAppointments";
            this.DgvAppointments.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvAppointments.RowHeadersVisible = false;
            this.DgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAppointments.Size = new System.Drawing.Size(954, 298);
            this.DgvAppointments.TabIndex = 3;
            this.DgvAppointments.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvAppointments_CellMouseDoubleClick);
            this.DgvAppointments.SelectionChanged += new System.EventHandler(this.DgvAppointments_SelectionChanged);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtSearch.Location = new System.Drawing.Point(694, 13);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(212, 23);
            this.TxtSearch.TabIndex = 1;
            // 
            // BtnDeleteAppointment
            // 
            this.BtnDeleteAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteAppointment.Location = new System.Drawing.Point(352, 176);
            this.BtnDeleteAppointment.Name = "BtnDeleteAppointment";
            this.BtnDeleteAppointment.Size = new System.Drawing.Size(201, 23);
            this.BtnDeleteAppointment.TabIndex = 27;
            this.BtnDeleteAppointment.Text = "Delete Appointment";
            this.BtnDeleteAppointment.UseVisualStyleBackColor = true;
            this.BtnDeleteAppointment.Click += new System.EventHandler(this.BtnDeleteAppointment_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(912, 13);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(59, 23);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnModifyAppointment
            // 
            this.BtnModifyAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifyAppointment.Location = new System.Drawing.Point(351, 207);
            this.BtnModifyAppointment.Name = "BtnModifyAppointment";
            this.BtnModifyAppointment.Size = new System.Drawing.Size(201, 23);
            this.BtnModifyAppointment.TabIndex = 28;
            this.BtnModifyAppointment.Text = "Modify Appointment";
            this.BtnModifyAppointment.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnModifyAppointment.UseVisualStyleBackColor = true;
            this.BtnModifyAppointment.Click += new System.EventHandler(this.BtnModifyAppointment_Click);
            // 
            // BtnAddAppointment
            // 
            this.BtnAddAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddAppointment.Location = new System.Drawing.Point(351, 145);
            this.BtnAddAppointment.Name = "BtnAddAppointment";
            this.BtnAddAppointment.Size = new System.Drawing.Size(201, 23);
            this.BtnAddAppointment.TabIndex = 26;
            this.BtnAddAppointment.Text = "Add Appointment";
            this.BtnAddAppointment.UseVisualStyleBackColor = true;
            this.BtnAddAppointment.Click += new System.EventHandler(this.BtnAddAppointment_Click);
            // 
            // GrpAppointmentData
            // 
            this.GrpAppointmentData.Controls.Add(this.BtnLaunch);
            this.GrpAppointmentData.Controls.Add(this.LblCustomerName);
            this.GrpAppointmentData.Controls.Add(this.TxtCustomerName);
            this.GrpAppointmentData.Controls.Add(this.LblUserName);
            this.GrpAppointmentData.Controls.Add(this.TxtUserName);
            this.GrpAppointmentData.Controls.Add(this.DtpLastUpdate);
            this.GrpAppointmentData.Controls.Add(this.DtpEnd);
            this.GrpAppointmentData.Controls.Add(this.DtpStart);
            this.GrpAppointmentData.Controls.Add(this.DtpCreateDate);
            this.GrpAppointmentData.Controls.Add(this.CboCustomerId);
            this.GrpAppointmentData.Controls.Add(this.CboUserId);
            this.GrpAppointmentData.Controls.Add(this.BtnDeleteAppointment);
            this.GrpAppointmentData.Controls.Add(this.LblLastUpdateBy);
            this.GrpAppointmentData.Controls.Add(this.TxtLastUpdateBy);
            this.GrpAppointmentData.Controls.Add(this.LblLastUpdate);
            this.GrpAppointmentData.Controls.Add(this.LblCreatedBy);
            this.GrpAppointmentData.Controls.Add(this.TxtCreatedBy);
            this.GrpAppointmentData.Controls.Add(this.BtnModifyAppointment);
            this.GrpAppointmentData.Controls.Add(this.LblCreateDate);
            this.GrpAppointmentData.Controls.Add(this.BtnAddAppointment);
            this.GrpAppointmentData.Controls.Add(this.LblEnd);
            this.GrpAppointmentData.Controls.Add(this.LblStart);
            this.GrpAppointmentData.Controls.Add(this.LblUrl);
            this.GrpAppointmentData.Controls.Add(this.TxtUrl);
            this.GrpAppointmentData.Controls.Add(this.LblType);
            this.GrpAppointmentData.Controls.Add(this.TxtType);
            this.GrpAppointmentData.Controls.Add(this.LblContact);
            this.GrpAppointmentData.Controls.Add(this.TxtContact);
            this.GrpAppointmentData.Controls.Add(this.LblLocation);
            this.GrpAppointmentData.Controls.Add(this.TxtLocation);
            this.GrpAppointmentData.Controls.Add(this.LblDescription);
            this.GrpAppointmentData.Controls.Add(this.TxtDescription);
            this.GrpAppointmentData.Controls.Add(this.LblTitle);
            this.GrpAppointmentData.Controls.Add(this.TxtTitle);
            this.GrpAppointmentData.Controls.Add(this.LblUserId);
            this.GrpAppointmentData.Controls.Add(this.LblCustomerId);
            this.GrpAppointmentData.Controls.Add(this.LblAppointmentId);
            this.GrpAppointmentData.Controls.Add(this.TxtAppointmentId);
            this.GrpAppointmentData.Location = new System.Drawing.Point(17, 346);
            this.GrpAppointmentData.Name = "GrpAppointmentData";
            this.GrpAppointmentData.Size = new System.Drawing.Size(954, 341);
            this.GrpAppointmentData.TabIndex = 39;
            this.GrpAppointmentData.TabStop = false;
            // 
            // BtnLaunch
            // 
            this.BtnLaunch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLaunch.BackgroundImage")));
            this.BtnLaunch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLaunch.Location = new System.Drawing.Point(162, 70);
            this.BtnLaunch.Name = "BtnLaunch";
            this.BtnLaunch.Size = new System.Drawing.Size(23, 22);
            this.BtnLaunch.TabIndex = 12;
            this.BtnLaunch.UseVisualStyleBackColor = true;
            this.BtnLaunch.Click += new System.EventHandler(this.BtnLaunch_Click);
            this.BtnLaunch.MouseHover += new System.EventHandler(this.BtnLaunch_MouseHover);
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.AutoSize = true;
            this.LblCustomerName.Location = new System.Drawing.Point(196, 71);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(38, 13);
            this.LblCustomerName.TabIndex = 13;
            this.LblCustomerName.Text = "Name:";
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Enabled = false;
            this.TxtCustomerName.Location = new System.Drawing.Point(240, 69);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.ReadOnly = true;
            this.TxtCustomerName.Size = new System.Drawing.Size(199, 20);
            this.TxtCustomerName.TabIndex = 14;
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(196, 47);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(38, 13);
            this.LblUserName.TabIndex = 8;
            this.LblUserName.Text = "Name:";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Enabled = false;
            this.TxtUserName.Location = new System.Drawing.Point(240, 44);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.ReadOnly = true;
            this.TxtUserName.Size = new System.Drawing.Size(199, 20);
            this.TxtUserName.TabIndex = 9;
            // 
            // DtpLastUpdate
            // 
            this.DtpLastUpdate.CustomFormat = "ddddd, MMMM dd, yyyy hh:mm:ss tt";
            this.DtpLastUpdate.Enabled = false;
            this.DtpLastUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpLastUpdate.Location = new System.Drawing.Point(668, 174);
            this.DtpLastUpdate.Name = "DtpLastUpdate";
            this.DtpLastUpdate.Size = new System.Drawing.Size(268, 20);
            this.DtpLastUpdate.TabIndex = 33;
            this.DtpLastUpdate.TabStop = false;
            // 
            // DtpEnd
            // 
            this.DtpEnd.CustomFormat = "ddddd, MMMM dd, yyyy hh:mm:ss tt";
            this.DtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpEnd.Location = new System.Drawing.Point(667, 99);
            this.DtpEnd.Name = "DtpEnd";
            this.DtpEnd.Size = new System.Drawing.Size(269, 20);
            this.DtpEnd.TabIndex = 29;
            this.DtpEnd.ValueChanged += new System.EventHandler(this.DtpEnd_ValueChanged);
            // 
            // DtpStart
            // 
            this.DtpStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpStart.CustomFormat = "ddddd, MMMM dd, yyyy hh:mm:ss tt";
            this.DtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpStart.Location = new System.Drawing.Point(667, 70);
            this.DtpStart.Name = "DtpStart";
            this.DtpStart.Size = new System.Drawing.Size(269, 20);
            this.DtpStart.TabIndex = 27;
            this.DtpStart.ValueChanged += new System.EventHandler(this.DtpStart_ValueChanged);
            // 
            // DtpCreateDate
            // 
            this.DtpCreateDate.CustomFormat = "ddddd, MMMM dd, yyyy hh:mm:ss tt";
            this.DtpCreateDate.Enabled = false;
            this.DtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpCreateDate.Location = new System.Drawing.Point(667, 148);
            this.DtpCreateDate.Name = "DtpCreateDate";
            this.DtpCreateDate.Size = new System.Drawing.Size(269, 20);
            this.DtpCreateDate.TabIndex = 31;
            this.DtpCreateDate.TabStop = false;
            // 
            // CboCustomerId
            // 
            this.CboCustomerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCustomerId.Enabled = false;
            this.CboCustomerId.FormattingEnabled = true;
            this.CboCustomerId.ItemHeight = 13;
            this.CboCustomerId.Location = new System.Drawing.Point(99, 70);
            this.CboCustomerId.Name = "CboCustomerId";
            this.CboCustomerId.Size = new System.Drawing.Size(57, 21);
            this.CboCustomerId.TabIndex = 12;
            this.CboCustomerId.SelectedIndexChanged += new System.EventHandler(this.CboCustomerId_SelectedIndexChanged);
            // 
            // CboUserId
            // 
            this.CboUserId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboUserId.Enabled = false;
            this.CboUserId.FormattingEnabled = true;
            this.CboUserId.ItemHeight = 13;
            this.CboUserId.Location = new System.Drawing.Point(100, 43);
            this.CboUserId.Name = "CboUserId";
            this.CboUserId.Size = new System.Drawing.Size(85, 21);
            this.CboUserId.TabIndex = 10;
            this.CboUserId.SelectedIndexChanged += new System.EventHandler(this.CboUserId_SelectedIndexChanged);
            // 
            // LblLastUpdateBy
            // 
            this.LblLastUpdateBy.AutoSize = true;
            this.LblLastUpdateBy.Location = new System.Drawing.Point(579, 205);
            this.LblLastUpdateBy.Name = "LblLastUpdateBy";
            this.LblLastUpdateBy.Size = new System.Drawing.Size(83, 13);
            this.LblLastUpdateBy.TabIndex = 34;
            this.LblLastUpdateBy.Text = "Last Update By:";
            // 
            // TxtLastUpdateBy
            // 
            this.TxtLastUpdateBy.Enabled = false;
            this.TxtLastUpdateBy.Location = new System.Drawing.Point(668, 202);
            this.TxtLastUpdateBy.Name = "TxtLastUpdateBy";
            this.TxtLastUpdateBy.Size = new System.Drawing.Size(268, 20);
            this.TxtLastUpdateBy.TabIndex = 35;
            this.TxtLastUpdateBy.TabStop = false;
            // 
            // LblLastUpdate
            // 
            this.LblLastUpdate.AutoSize = true;
            this.LblLastUpdate.Location = new System.Drawing.Point(592, 177);
            this.LblLastUpdate.Name = "LblLastUpdate";
            this.LblLastUpdate.Size = new System.Drawing.Size(68, 13);
            this.LblLastUpdate.TabIndex = 32;
            this.LblLastUpdate.Text = "Last Update:";
            // 
            // LblCreatedBy
            // 
            this.LblCreatedBy.AutoSize = true;
            this.LblCreatedBy.Location = new System.Drawing.Point(600, 230);
            this.LblCreatedBy.Name = "LblCreatedBy";
            this.LblCreatedBy.Size = new System.Drawing.Size(62, 13);
            this.LblCreatedBy.TabIndex = 36;
            this.LblCreatedBy.Text = "Created By:";
            // 
            // TxtCreatedBy
            // 
            this.TxtCreatedBy.Enabled = false;
            this.TxtCreatedBy.Location = new System.Drawing.Point(667, 228);
            this.TxtCreatedBy.Name = "TxtCreatedBy";
            this.TxtCreatedBy.Size = new System.Drawing.Size(268, 20);
            this.TxtCreatedBy.TabIndex = 37;
            this.TxtCreatedBy.TabStop = false;
            // 
            // LblCreateDate
            // 
            this.LblCreateDate.AutoSize = true;
            this.LblCreateDate.Location = new System.Drawing.Point(593, 152);
            this.LblCreateDate.Name = "LblCreateDate";
            this.LblCreateDate.Size = new System.Drawing.Size(67, 13);
            this.LblCreateDate.TabIndex = 30;
            this.LblCreateDate.Text = "Create Date:";
            // 
            // LblEnd
            // 
            this.LblEnd.AutoSize = true;
            this.LblEnd.Location = new System.Drawing.Point(631, 102);
            this.LblEnd.Name = "LblEnd";
            this.LblEnd.Size = new System.Drawing.Size(29, 13);
            this.LblEnd.TabIndex = 28;
            this.LblEnd.Text = "End:";
            // 
            // LblStart
            // 
            this.LblStart.AutoSize = true;
            this.LblStart.Location = new System.Drawing.Point(628, 73);
            this.LblStart.Name = "LblStart";
            this.LblStart.Size = new System.Drawing.Size(32, 13);
            this.LblStart.TabIndex = 26;
            this.LblStart.Text = "Start:";
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Location = new System.Drawing.Point(629, 22);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(32, 13);
            this.LblUrl.TabIndex = 24;
            this.LblUrl.Text = "URL:";
            // 
            // TxtUrl
            // 
            this.TxtUrl.Enabled = false;
            this.TxtUrl.Location = new System.Drawing.Point(667, 19);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(269, 20);
            this.TxtUrl.TabIndex = 25;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(59, 232);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(34, 13);
            this.LblType.TabIndex = 20;
            this.LblType.Text = "Type:";
            // 
            // TxtType
            // 
            this.TxtType.Enabled = false;
            this.TxtType.Location = new System.Drawing.Point(99, 229);
            this.TxtType.Multiline = true;
            this.TxtType.Name = "TxtType";
            this.TxtType.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtType.Size = new System.Drawing.Size(191, 43);
            this.TxtType.TabIndex = 21;
            // 
            // LblContact
            // 
            this.LblContact.AutoSize = true;
            this.LblContact.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblContact.Location = new System.Drawing.Point(49, 181);
            this.LblContact.Name = "LblContact";
            this.LblContact.Size = new System.Drawing.Size(47, 13);
            this.LblContact.TabIndex = 18;
            this.LblContact.Text = "Contact:";
            // 
            // TxtContact
            // 
            this.TxtContact.Enabled = false;
            this.TxtContact.Location = new System.Drawing.Point(100, 178);
            this.TxtContact.Multiline = true;
            this.TxtContact.Name = "TxtContact";
            this.TxtContact.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtContact.Size = new System.Drawing.Size(190, 43);
            this.TxtContact.TabIndex = 19;
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.Location = new System.Drawing.Point(43, 284);
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(51, 13);
            this.LblLocation.TabIndex = 22;
            this.LblLocation.Text = "Location:";
            // 
            // TxtLocation
            // 
            this.TxtLocation.Enabled = false;
            this.TxtLocation.Location = new System.Drawing.Point(100, 281);
            this.TxtLocation.Multiline = true;
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtLocation.Size = new System.Drawing.Size(190, 43);
            this.TxtLocation.TabIndex = 23;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(32, 128);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(63, 13);
            this.LblDescription.TabIndex = 16;
            this.LblDescription.Text = "Description:";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Enabled = false;
            this.TxtDescription.Location = new System.Drawing.Point(100, 125);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDescription.Size = new System.Drawing.Size(190, 43);
            this.TxtDescription.TabIndex = 17;
            this.TxtDescription.TextChanged += new System.EventHandler(this.TxtDescription_TextChanged);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(61, 99);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(30, 13);
            this.LblTitle.TabIndex = 15;
            this.LblTitle.Text = "Title:";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Enabled = false;
            this.TxtTitle.Location = new System.Drawing.Point(98, 96);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(341, 20);
            this.TxtTitle.TabIndex = 15;
            this.TxtTitle.TextChanged += new System.EventHandler(this.TxtTitle_TextChanged);
            // 
            // LblUserId
            // 
            this.LblUserId.AutoSize = true;
            this.LblUserId.Location = new System.Drawing.Point(49, 47);
            this.LblUserId.Name = "LblUserId";
            this.LblUserId.Size = new System.Drawing.Size(46, 13);
            this.LblUserId.TabIndex = 6;
            this.LblUserId.Text = "User ID:";
            // 
            // LblCustomerId
            // 
            this.LblCustomerId.AutoSize = true;
            this.LblCustomerId.Location = new System.Drawing.Point(27, 75);
            this.LblCustomerId.Name = "LblCustomerId";
            this.LblCustomerId.Size = new System.Drawing.Size(68, 13);
            this.LblCustomerId.TabIndex = 10;
            this.LblCustomerId.Text = "Customer ID:";
            // 
            // LblAppointmentId
            // 
            this.LblAppointmentId.AutoSize = true;
            this.LblAppointmentId.Location = new System.Drawing.Point(13, 18);
            this.LblAppointmentId.Name = "LblAppointmentId";
            this.LblAppointmentId.Size = new System.Drawing.Size(83, 13);
            this.LblAppointmentId.TabIndex = 4;
            this.LblAppointmentId.Text = "Appointment ID:";
            // 
            // TxtAppointmentId
            // 
            this.TxtAppointmentId.Enabled = false;
            this.TxtAppointmentId.Location = new System.Drawing.Point(100, 15);
            this.TxtAppointmentId.Name = "TxtAppointmentId";
            this.TxtAppointmentId.Size = new System.Drawing.Size(85, 20);
            this.TxtAppointmentId.TabIndex = 5;
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
            this.MnuMenu.TabIndex = 29;
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
            this.MnuAppointments.Checked = true;
            this.MnuAppointments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuAppointments.Name = "MnuAppointments";
            this.MnuAppointments.ShortcutKeyDisplayString = "";
            this.MnuAppointments.Size = new System.Drawing.Size(150, 22);
            this.MnuAppointments.Text = "&Appointments";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GrpAppointmentData);
            this.groupBox1.Controls.Add(this.LblHeader);
            this.groupBox1.Controls.Add(this.TxtSearch);
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Location = new System.Drawing.Point(9, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(987, 705);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.Location = new System.Drawing.Point(13, 16);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(112, 20);
            this.LblHeader.TabIndex = 0;
            this.LblHeader.Text = "Appointments:";
            // 
            // _timers
            // 
            this._timers.Enabled = true;
            this._timers.Interval = 1000;
            //this._timers.Tick += new System.EventHandler(this._timers_Tick);
            // 
            // FrmAppointments
            // 
            this.AcceptButton = this.BtnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1008, 741);
            this.Controls.Add(this.DgvAppointments);
            this.Controls.Add(this.MnuMenu);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.MnuMenu;
            this.Name = "FrmAppointments";
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.FrmAppointments_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmAppointments_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAppointments)).EndInit();
            this.GrpAppointmentData.ResumeLayout(false);
            this.GrpAppointmentData.PerformLayout();
            this.MnuMenu.ResumeLayout(false);
            this.MnuMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvAppointments;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnDeleteAppointment;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnModifyAppointment;
        private System.Windows.Forms.Button BtnAddAppointment;
        private System.Windows.Forms.GroupBox GrpAppointmentData;
        private System.Windows.Forms.Label LblAppointmentId;
        private System.Windows.Forms.TextBox TxtAppointmentId;
        private System.Windows.Forms.Label LblLastUpdateBy;
        private System.Windows.Forms.TextBox TxtLastUpdateBy;
        private System.Windows.Forms.Label LblLastUpdate;
        private System.Windows.Forms.Label LblCreatedBy;
        private System.Windows.Forms.TextBox TxtCreatedBy;
        private System.Windows.Forms.Label LblCreateDate;
        private System.Windows.Forms.Label LblEnd;
        private System.Windows.Forms.Label LblStart;
        private System.Windows.Forms.Label LblUrl;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.TextBox TxtType;
        private System.Windows.Forms.Label LblContact;
        private System.Windows.Forms.TextBox TxtContact;
        private System.Windows.Forms.Label LblLocation;
        private System.Windows.Forms.TextBox TxtLocation;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label LblUserId;
        private System.Windows.Forms.Label LblCustomerId;
        private System.Windows.Forms.MenuStrip MnuMenu;
        private System.Windows.Forms.ToolStripMenuItem MnuApplications;
        private System.Windows.Forms.ToolStripMenuItem MnuAppointments;
        private System.Windows.Forms.ToolStripMenuItem MnuCalendar;
        private System.Windows.Forms.ToolStripMenuItem MnuCustomers;
        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.ComboBox CboUserId;
        private System.Windows.Forms.ComboBox CboCustomerId;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem MnuReports;
        private System.Windows.Forms.DateTimePicker DtpLastUpdate;
        private System.Windows.Forms.DateTimePicker DtpEnd;
        private System.Windows.Forms.DateTimePicker DtpStart;
        private System.Windows.Forms.DateTimePicker DtpCreateDate;
        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.TextBox TxtCustomerName;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.ToolTip ToolTip;
        public System.Windows.Forms.Timer _timers;
        private System.Windows.Forms.ToolStripMenuItem MnuAddresses;
        private System.Windows.Forms.Button BtnLaunch;
        private System.Windows.Forms.ToolStripMenuItem MnuHelp;
    }
}

