namespace RobertOgden
{
    partial class FrmAddresses
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
            this._timers = new System.Windows.Forms.Timer(this.components);
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCalendar = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAppointments = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAddresses = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMenu = new System.Windows.Forms.MenuStrip();
            this.MnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LblCity = new System.Windows.Forms.Label();
            this.LblPhone = new System.Windows.Forms.Label();
            this.GrpAddresses = new System.Windows.Forms.GroupBox();
            this.LblCityId = new System.Windows.Forms.Label();
            this.CboCityId = new System.Windows.Forms.ComboBox();
            this.TxtAddressId = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnDeleteAddress = new System.Windows.Forms.Button();
            this.DtpLastUpdate = new System.Windows.Forms.DateTimePicker();
            this.LblLastUpdate = new System.Windows.Forms.Label();
            this.BtnModifyAddress = new System.Windows.Forms.Button();
            this.BtnAddAddress = new System.Windows.Forms.Button();
            this.DgvAddresses = new System.Windows.Forms.DataGridView();
            this.DtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.LblHeader = new System.Windows.Forms.Label();
            this.LblPostalCode = new System.Windows.Forms.Label();
            this.TxtPostalCode = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.LblAddress2 = new System.Windows.Forms.Label();
            this.TxtAddress2 = new System.Windows.Forms.TextBox();
            this.LblAddress1 = new System.Windows.Forms.Label();
            this.TxtAddress1 = new System.Windows.Forms.TextBox();
            this.LblLastUpdateBy = new System.Windows.Forms.Label();
            this.TxtLastUpdateBy = new System.Windows.Forms.TextBox();
            this.LblAddressIda = new System.Windows.Forms.Label();
            this.LblCreatedBy = new System.Windows.Forms.Label();
            this.TxtCreatedBy = new System.Windows.Forms.TextBox();
            this.LblCreateDate = new System.Windows.Forms.Label();
            this.MnuMenu.SuspendLayout();
            this.GrpAddresses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddresses)).BeginInit();
            this.SuspendLayout();
            // 
            // _timers
            // 
            this._timers.Interval = 1000;
            this._timers.Tick += new System.EventHandler(this._timers_Tick);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(37, 20);
            this.MnuExit.Text = "E&xit";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // MnuReports
            // 
            this.MnuReports.Name = "MnuReports";
            this.MnuReports.Size = new System.Drawing.Size(150, 22);
            this.MnuReports.Text = "&Reports";
            this.MnuReports.Click += new System.EventHandler(this.MnuReports_Click);
            // 
            // MnuCustomers
            // 
            this.MnuCustomers.Name = "MnuCustomers";
            this.MnuCustomers.Size = new System.Drawing.Size(150, 22);
            this.MnuCustomers.Text = "C&ustomers";
            this.MnuCustomers.Click += new System.EventHandler(this.MnuCustomers_Click);
            // 
            // MnuCalendar
            // 
            this.MnuCalendar.Name = "MnuCalendar";
            this.MnuCalendar.Size = new System.Drawing.Size(150, 22);
            this.MnuCalendar.Text = "&Calendar";
            this.MnuCalendar.Click += new System.EventHandler(this.MnuCalendar_Click);
            // 
            // MnuAppointments
            // 
            this.MnuAppointments.Name = "MnuAppointments";
            this.MnuAppointments.ShortcutKeyDisplayString = "";
            this.MnuAppointments.Size = new System.Drawing.Size(150, 22);
            this.MnuAppointments.Text = "&Appointments";
            this.MnuAppointments.Click += new System.EventHandler(this.MnuAppointments_Click);
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
            this.MnuAddresses.Checked = true;
            this.MnuAddresses.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuAddresses.Name = "MnuAddresses";
            this.MnuAddresses.Size = new System.Drawing.Size(150, 22);
            this.MnuAddresses.Text = "Addresses";
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
            this.MnuMenu.TabIndex = 21;
            this.MnuMenu.Text = "menuStrip1";
            // 
            // MnuHelp
            // 
            this.MnuHelp.Name = "MnuHelp";
            this.MnuHelp.Size = new System.Drawing.Size(44, 20);
            this.MnuHelp.Text = "H&elp";
            this.MnuHelp.Click += new System.EventHandler(this.MnuHelp_Click);
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LblCity.Location = new System.Drawing.Point(192, 410);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(30, 13);
            this.LblCity.TabIndex = 12;
            this.LblCity.Text = "City: ";
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Location = new System.Drawing.Point(8, 471);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(84, 13);
            this.LblPhone.TabIndex = 16;
            this.LblPhone.Text = "Phone Number: ";
            // 
            // GrpAddresses
            // 
            this.GrpAddresses.Controls.Add(this.LblCityId);
            this.GrpAddresses.Controls.Add(this.CboCityId);
            this.GrpAddresses.Controls.Add(this.TxtAddressId);
            this.GrpAddresses.Controls.Add(this.LblCity);
            this.GrpAddresses.Controls.Add(this.LblPhone);
            this.GrpAddresses.Controls.Add(this.TxtPhone);
            this.GrpAddresses.Controls.Add(this.TxtSearch);
            this.GrpAddresses.Controls.Add(this.BtnSearch);
            this.GrpAddresses.Controls.Add(this.BtnDeleteAddress);
            this.GrpAddresses.Controls.Add(this.DtpLastUpdate);
            this.GrpAddresses.Controls.Add(this.LblLastUpdate);
            this.GrpAddresses.Controls.Add(this.BtnModifyAddress);
            this.GrpAddresses.Controls.Add(this.BtnAddAddress);
            this.GrpAddresses.Controls.Add(this.DgvAddresses);
            this.GrpAddresses.Controls.Add(this.DtpCreateDate);
            this.GrpAddresses.Controls.Add(this.LblHeader);
            this.GrpAddresses.Controls.Add(this.LblPostalCode);
            this.GrpAddresses.Controls.Add(this.TxtPostalCode);
            this.GrpAddresses.Controls.Add(this.TxtCity);
            this.GrpAddresses.Controls.Add(this.LblAddress2);
            this.GrpAddresses.Controls.Add(this.TxtAddress2);
            this.GrpAddresses.Controls.Add(this.LblAddress1);
            this.GrpAddresses.Controls.Add(this.TxtAddress1);
            this.GrpAddresses.Controls.Add(this.LblLastUpdateBy);
            this.GrpAddresses.Controls.Add(this.TxtLastUpdateBy);
            this.GrpAddresses.Controls.Add(this.LblAddressIda);
            this.GrpAddresses.Controls.Add(this.LblCreatedBy);
            this.GrpAddresses.Controls.Add(this.TxtCreatedBy);
            this.GrpAddresses.Controls.Add(this.LblCreateDate);
            this.GrpAddresses.Location = new System.Drawing.Point(10, 27);
            this.GrpAddresses.Name = "GrpAddresses";
            this.GrpAddresses.Size = new System.Drawing.Size(986, 535);
            this.GrpAddresses.TabIndex = 26;
            this.GrpAddresses.TabStop = false;
            // 
            // LblCityId
            // 
            this.LblCityId.AutoSize = true;
            this.LblCityId.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LblCityId.Location = new System.Drawing.Point(48, 410);
            this.LblCityId.Name = "LblCityId";
            this.LblCityId.Size = new System.Drawing.Size(44, 13);
            this.LblCityId.TabIndex = 10;
            this.LblCityId.Text = "City ID: ";
            // 
            // CboCityId
            // 
            this.CboCityId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCityId.Enabled = false;
            this.CboCityId.FormattingEnabled = true;
            this.CboCityId.ItemHeight = 13;
            this.CboCityId.Location = new System.Drawing.Point(101, 407);
            this.CboCityId.Name = "CboCityId";
            this.CboCityId.Size = new System.Drawing.Size(85, 21);
            this.CboCityId.TabIndex = 59;
            this.CboCityId.SelectedIndexChanged += new System.EventHandler(this.CboCityId_SelectedIndexChanged);
            // 
            // TxtAddressId
            // 
            this.TxtAddressId.Enabled = false;
            this.TxtAddressId.Location = new System.Drawing.Point(101, 315);
            this.TxtAddressId.Name = "TxtAddressId";
            this.TxtAddressId.Size = new System.Drawing.Size(90, 20);
            this.TxtAddressId.TabIndex = 5;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Enabled = false;
            this.TxtPhone.Location = new System.Drawing.Point(101, 468);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(252, 20);
            this.TxtPhone.TabIndex = 17;
            this.TxtPhone.TextChanged += new System.EventHandler(this.TxtPhone_TextChanged);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtSearch.Location = new System.Drawing.Point(687, 10);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(212, 23);
            this.TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(905, 10);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(59, 23);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnDeleteAddress
            // 
            this.BtnDeleteAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteAddress.Location = new System.Drawing.Point(417, 374);
            this.BtnDeleteAddress.Name = "BtnDeleteAddress";
            this.BtnDeleteAddress.Size = new System.Drawing.Size(155, 23);
            this.BtnDeleteAddress.TabIndex = 19;
            this.BtnDeleteAddress.Text = "Delete Address";
            this.BtnDeleteAddress.UseVisualStyleBackColor = true;
            this.BtnDeleteAddress.Click += new System.EventHandler(this.BtnDeleteAddress_Click);
            // 
            // DtpLastUpdate
            // 
            this.DtpLastUpdate.CustomFormat = "ddddd, MMMM dd, yyyy hh:mm:ss tt";
            this.DtpLastUpdate.Enabled = false;
            this.DtpLastUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpLastUpdate.Location = new System.Drawing.Point(702, 412);
            this.DtpLastUpdate.Name = "DtpLastUpdate";
            this.DtpLastUpdate.Size = new System.Drawing.Size(263, 20);
            this.DtpLastUpdate.TabIndex = 49;
            this.DtpLastUpdate.TabStop = false;
            // 
            // LblLastUpdate
            // 
            this.LblLastUpdate.AutoSize = true;
            this.LblLastUpdate.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LblLastUpdate.Location = new System.Drawing.Point(625, 415);
            this.LblLastUpdate.Name = "LblLastUpdate";
            this.LblLastUpdate.Size = new System.Drawing.Size(71, 13);
            this.LblLastUpdate.TabIndex = 25;
            this.LblLastUpdate.Text = "Last Update: ";
            // 
            // BtnModifyAddress
            // 
            this.BtnModifyAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifyAddress.Location = new System.Drawing.Point(416, 405);
            this.BtnModifyAddress.Name = "BtnModifyAddress";
            this.BtnModifyAddress.Size = new System.Drawing.Size(155, 23);
            this.BtnModifyAddress.TabIndex = 20;
            this.BtnModifyAddress.Text = "Modify Address";
            this.BtnModifyAddress.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnModifyAddress.UseVisualStyleBackColor = true;
            this.BtnModifyAddress.Click += new System.EventHandler(this.BtnModifyAddress_Click);
            // 
            // BtnAddAddress
            // 
            this.BtnAddAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddAddress.Location = new System.Drawing.Point(416, 343);
            this.BtnAddAddress.Name = "BtnAddAddress";
            this.BtnAddAddress.Size = new System.Drawing.Size(155, 23);
            this.BtnAddAddress.TabIndex = 18;
            this.BtnAddAddress.Text = "Add  Address";
            this.BtnAddAddress.UseVisualStyleBackColor = true;
            this.BtnAddAddress.Click += new System.EventHandler(this.BtnAddAddress_Click);
            // 
            // DgvAddresses
            // 
            this.DgvAddresses.AllowUserToAddRows = false;
            this.DgvAddresses.AllowUserToDeleteRows = false;
            this.DgvAddresses.AllowUserToResizeRows = false;
            this.DgvAddresses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAddresses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvAddresses.Location = new System.Drawing.Point(21, 39);
            this.DgvAddresses.Name = "DgvAddresses";
            this.DgvAddresses.RowHeadersVisible = false;
            this.DgvAddresses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAddresses.Size = new System.Drawing.Size(944, 262);
            this.DgvAddresses.TabIndex = 3;
            this.DgvAddresses.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvAddresses_CellMouseDoubleClick);
            this.DgvAddresses.SelectionChanged += new System.EventHandler(this.DgvAddresses_SelectionChanged);
            // 
            // DtpCreateDate
            // 
            this.DtpCreateDate.CustomFormat = "ddddd, MMMM dd, yyyy hh:mm:ss tt";
            this.DtpCreateDate.Enabled = false;
            this.DtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpCreateDate.Location = new System.Drawing.Point(702, 386);
            this.DtpCreateDate.Name = "DtpCreateDate";
            this.DtpCreateDate.Size = new System.Drawing.Size(263, 20);
            this.DtpCreateDate.TabIndex = 48;
            this.DtpCreateDate.TabStop = false;
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.Location = new System.Drawing.Point(17, 10);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(89, 20);
            this.LblHeader.TabIndex = 0;
            this.LblHeader.Text = "Addresses:";
            // 
            // LblPostalCode
            // 
            this.LblPostalCode.AutoSize = true;
            this.LblPostalCode.Location = new System.Drawing.Point(25, 440);
            this.LblPostalCode.Name = "LblPostalCode";
            this.LblPostalCode.Size = new System.Drawing.Size(70, 13);
            this.LblPostalCode.TabIndex = 14;
            this.LblPostalCode.Text = "Postal Code: ";
            // 
            // TxtPostalCode
            // 
            this.TxtPostalCode.Enabled = false;
            this.TxtPostalCode.Location = new System.Drawing.Point(101, 437);
            this.TxtPostalCode.Name = "TxtPostalCode";
            this.TxtPostalCode.Size = new System.Drawing.Size(252, 20);
            this.TxtPostalCode.TabIndex = 15;
            this.TxtPostalCode.TextChanged += new System.EventHandler(this.TxtPostalCode_TextChanged);
            // 
            // TxtCity
            // 
            this.TxtCity.Enabled = false;
            this.TxtCity.Location = new System.Drawing.Point(228, 407);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(125, 20);
            this.TxtCity.TabIndex = 13;
            // 
            // LblAddress2
            // 
            this.LblAddress2.AutoSize = true;
            this.LblAddress2.Location = new System.Drawing.Point(12, 374);
            this.LblAddress2.Name = "LblAddress2";
            this.LblAddress2.Size = new System.Drawing.Size(87, 13);
            this.LblAddress2.TabIndex = 8;
            this.LblAddress2.Text = "Address Line 2*: ";
            // 
            // TxtAddress2
            // 
            this.TxtAddress2.Enabled = false;
            this.TxtAddress2.Location = new System.Drawing.Point(101, 371);
            this.TxtAddress2.Name = "TxtAddress2";
            this.TxtAddress2.Size = new System.Drawing.Size(252, 20);
            this.TxtAddress2.TabIndex = 9;
            // 
            // LblAddress1
            // 
            this.LblAddress1.AutoSize = true;
            this.LblAddress1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LblAddress1.Location = new System.Drawing.Point(12, 347);
            this.LblAddress1.Name = "LblAddress1";
            this.LblAddress1.Size = new System.Drawing.Size(83, 13);
            this.LblAddress1.TabIndex = 6;
            this.LblAddress1.Text = "Address Line 1: ";
            // 
            // TxtAddress1
            // 
            this.TxtAddress1.Enabled = false;
            this.TxtAddress1.Location = new System.Drawing.Point(101, 344);
            this.TxtAddress1.Name = "TxtAddress1";
            this.TxtAddress1.Size = new System.Drawing.Size(252, 20);
            this.TxtAddress1.TabIndex = 7;
            this.TxtAddress1.TextChanged += new System.EventHandler(this.TxtAddress1_TextChanged);
            // 
            // LblLastUpdateBy
            // 
            this.LblLastUpdateBy.AutoSize = true;
            this.LblLastUpdateBy.Location = new System.Drawing.Point(610, 348);
            this.LblLastUpdateBy.Name = "LblLastUpdateBy";
            this.LblLastUpdateBy.Size = new System.Drawing.Size(86, 13);
            this.LblLastUpdateBy.TabIndex = 23;
            this.LblLastUpdateBy.Text = "Last Update By: ";
            // 
            // TxtLastUpdateBy
            // 
            this.TxtLastUpdateBy.Enabled = false;
            this.TxtLastUpdateBy.Location = new System.Drawing.Point(702, 345);
            this.TxtLastUpdateBy.Name = "TxtLastUpdateBy";
            this.TxtLastUpdateBy.Size = new System.Drawing.Size(263, 20);
            this.TxtLastUpdateBy.TabIndex = 34;
            this.TxtLastUpdateBy.TabStop = false;
            // 
            // LblAddressIda
            // 
            this.LblAddressIda.AutoSize = true;
            this.LblAddressIda.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LblAddressIda.Location = new System.Drawing.Point(30, 319);
            this.LblAddressIda.Name = "LblAddressIda";
            this.LblAddressIda.Size = new System.Drawing.Size(65, 13);
            this.LblAddressIda.TabIndex = 4;
            this.LblAddressIda.Text = "Address ID: ";
            // 
            // LblCreatedBy
            // 
            this.LblCreatedBy.AutoSize = true;
            this.LblCreatedBy.Location = new System.Drawing.Point(631, 322);
            this.LblCreatedBy.Name = "LblCreatedBy";
            this.LblCreatedBy.Size = new System.Drawing.Size(65, 13);
            this.LblCreatedBy.TabIndex = 22;
            this.LblCreatedBy.Text = "Created By: ";
            // 
            // TxtCreatedBy
            // 
            this.TxtCreatedBy.Enabled = false;
            this.TxtCreatedBy.Location = new System.Drawing.Point(702, 319);
            this.TxtCreatedBy.Name = "TxtCreatedBy";
            this.TxtCreatedBy.Size = new System.Drawing.Size(263, 20);
            this.TxtCreatedBy.TabIndex = 30;
            this.TxtCreatedBy.TabStop = false;
            // 
            // LblCreateDate
            // 
            this.LblCreateDate.AutoSize = true;
            this.LblCreateDate.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LblCreateDate.Location = new System.Drawing.Point(625, 389);
            this.LblCreateDate.Name = "LblCreateDate";
            this.LblCreateDate.Size = new System.Drawing.Size(70, 13);
            this.LblCreateDate.TabIndex = 24;
            this.LblCreateDate.Text = "Create Date: ";
            // 
            // FrmAddresses
            // 
            this.AcceptButton = this.BtnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 613);
            this.Controls.Add(this.MnuMenu);
            this.Controls.Add(this.GrpAddresses);
            this.Name = "FrmAddresses";
            this.Text = "Addresses";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmAddresses_MouseMove);
            this.MnuMenu.ResumeLayout(false);
            this.MnuMenu.PerformLayout();
            this.GrpAddresses.ResumeLayout(false);
            this.GrpAddresses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddresses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer _timers;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem MnuReports;
        private System.Windows.Forms.ToolStripMenuItem MnuCustomers;
        private System.Windows.Forms.ToolStripMenuItem MnuCalendar;
        private System.Windows.Forms.ToolStripMenuItem MnuAppointments;
        private System.Windows.Forms.ToolStripMenuItem MnuApplications;
        private System.Windows.Forms.MenuStrip MnuMenu;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.GroupBox GrpAddresses;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnDeleteAddress;
        private System.Windows.Forms.DateTimePicker DtpLastUpdate;
        private System.Windows.Forms.Label LblLastUpdate;
        private System.Windows.Forms.Button BtnModifyAddress;
        private System.Windows.Forms.Button BtnAddAddress;
        private System.Windows.Forms.DataGridView DgvAddresses;
        private System.Windows.Forms.DateTimePicker DtpCreateDate;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Label LblPostalCode;
        private System.Windows.Forms.TextBox TxtPostalCode;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.Label LblAddress2;
        private System.Windows.Forms.TextBox TxtAddress2;
        private System.Windows.Forms.Label LblAddress1;
        private System.Windows.Forms.TextBox TxtAddress1;
        private System.Windows.Forms.Label LblLastUpdateBy;
        private System.Windows.Forms.TextBox TxtLastUpdateBy;
        private System.Windows.Forms.Label LblAddressIda;
        private System.Windows.Forms.Label LblCreatedBy;
        private System.Windows.Forms.TextBox TxtCreatedBy;
        private System.Windows.Forms.Label LblCreateDate;
        private System.Windows.Forms.ToolStripMenuItem MnuAddresses;
        private System.Windows.Forms.TextBox TxtAddressId;
        private System.Windows.Forms.Label LblCityId;
        private System.Windows.Forms.ComboBox CboCityId;
        private System.Windows.Forms.ToolStripMenuItem MnuHelp;
    }
}