namespace RobertOgden
{
    partial class FrmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
            this.LblCustomerId = new System.Windows.Forms.Label();
            this.LblCustomerName = new System.Windows.Forms.Label();
            this.TxtCustomerName = new System.Windows.Forms.TextBox();
            this.LblCreatedBy = new System.Windows.Forms.Label();
            this.TxtCreatedBy = new System.Windows.Forms.TextBox();
            this.LblCreateDate = new System.Windows.Forms.Label();
            this.CboAddressId = new System.Windows.Forms.ComboBox();
            this.LblAddressId = new System.Windows.Forms.Label();
            this.TxtLastUpdateBy = new System.Windows.Forms.TextBox();
            this.LblLastUpdateBy = new System.Windows.Forms.Label();
            this.LblLastUpdate = new System.Windows.Forms.Label();
            this.LblPostalCode = new System.Windows.Forms.Label();
            this.TxtPostalCode = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.LblAddress2 = new System.Windows.Forms.Label();
            this.TxtAddress2 = new System.Windows.Forms.TextBox();
            this.LblAddress1 = new System.Windows.Forms.Label();
            this.TxtAddress1 = new System.Windows.Forms.TextBox();
            this.GrpCustomers = new System.Windows.Forms.GroupBox();
            this.BtnLaunch = new System.Windows.Forms.Button();
            this.LblCity = new System.Windows.Forms.Label();
            this.LblPhone = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtCustomerId = new System.Windows.Forms.TextBox();
            this.BtnDeleteCustomer = new System.Windows.Forms.Button();
            this.DtpLastUpdate = new System.Windows.Forms.DateTimePicker();
            this.BtnModifyCustomer = new System.Windows.Forms.Button();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.DgvCustomers = new System.Windows.Forms.DataGridView();
            this.DtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.ChkActive = new System.Windows.Forms.CheckBox();
            this.LblHeader = new System.Windows.Forms.Label();
            this.MnuMenu = new System.Windows.Forms.MenuStrip();
            this.MnuApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAddresses = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAppointments = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCalendar = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TmrReminders = new System.Windows.Forms.Timer(this.components);
            this.MnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.GrpCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).BeginInit();
            this.MnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblCustomerId
            // 
            this.LblCustomerId.AutoSize = true;
            this.LblCustomerId.Location = new System.Drawing.Point(26, 331);
            this.LblCustomerId.Name = "LblCustomerId";
            this.LblCustomerId.Size = new System.Drawing.Size(71, 13);
            this.LblCustomerId.TabIndex = 4;
            this.LblCustomerId.Text = "Customer ID: ";
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.AutoSize = true;
            this.LblCustomerName.Location = new System.Drawing.Point(9, 357);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(88, 13);
            this.LblCustomerName.TabIndex = 7;
            this.LblCustomerName.Text = "Customer Name: ";
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Enabled = false;
            this.TxtCustomerName.Location = new System.Drawing.Point(103, 354);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(252, 20);
            this.TxtCustomerName.TabIndex = 8;
            this.TxtCustomerName.TextChanged += new System.EventHandler(this.TxtCustomerName_TextChanged);
            // 
            // LblCreatedBy
            // 
            this.LblCreatedBy.AutoSize = true;
            this.LblCreatedBy.Location = new System.Drawing.Point(632, 331);
            this.LblCreatedBy.Name = "LblCreatedBy";
            this.LblCreatedBy.Size = new System.Drawing.Size(65, 13);
            this.LblCreatedBy.TabIndex = 25;
            this.LblCreatedBy.Text = "Created By: ";
            // 
            // TxtCreatedBy
            // 
            this.TxtCreatedBy.Enabled = false;
            this.TxtCreatedBy.Location = new System.Drawing.Point(703, 328);
            this.TxtCreatedBy.Name = "TxtCreatedBy";
            this.TxtCreatedBy.Size = new System.Drawing.Size(263, 20);
            this.TxtCreatedBy.TabIndex = 26;
            this.TxtCreatedBy.TabStop = false;
            // 
            // LblCreateDate
            // 
            this.LblCreateDate.AutoSize = true;
            this.LblCreateDate.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LblCreateDate.Location = new System.Drawing.Point(626, 398);
            this.LblCreateDate.Name = "LblCreateDate";
            this.LblCreateDate.Size = new System.Drawing.Size(70, 13);
            this.LblCreateDate.TabIndex = 29;
            this.LblCreateDate.Text = "Create Date: ";
            // 
            // CboAddressId
            // 
            this.CboAddressId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAddressId.Enabled = false;
            this.CboAddressId.FormattingEnabled = true;
            this.CboAddressId.Location = new System.Drawing.Point(102, 396);
            this.CboAddressId.Name = "CboAddressId";
            this.CboAddressId.Size = new System.Drawing.Size(85, 21);
            this.CboAddressId.TabIndex = 10;
            this.CboAddressId.SelectedIndexChanged += new System.EventHandler(this.CboAddressId_SelectedIndexChanged);
            // 
            // LblAddressId
            // 
            this.LblAddressId.AutoSize = true;
            this.LblAddressId.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LblAddressId.Location = new System.Drawing.Point(31, 399);
            this.LblAddressId.Name = "LblAddressId";
            this.LblAddressId.Size = new System.Drawing.Size(65, 13);
            this.LblAddressId.TabIndex = 9;
            this.LblAddressId.Text = "Address ID: ";
            // 
            // TxtLastUpdateBy
            // 
            this.TxtLastUpdateBy.Enabled = false;
            this.TxtLastUpdateBy.Location = new System.Drawing.Point(703, 354);
            this.TxtLastUpdateBy.Name = "TxtLastUpdateBy";
            this.TxtLastUpdateBy.Size = new System.Drawing.Size(263, 20);
            this.TxtLastUpdateBy.TabIndex = 28;
            this.TxtLastUpdateBy.TabStop = false;
            // 
            // LblLastUpdateBy
            // 
            this.LblLastUpdateBy.AutoSize = true;
            this.LblLastUpdateBy.Location = new System.Drawing.Point(611, 357);
            this.LblLastUpdateBy.Name = "LblLastUpdateBy";
            this.LblLastUpdateBy.Size = new System.Drawing.Size(86, 13);
            this.LblLastUpdateBy.TabIndex = 27;
            this.LblLastUpdateBy.Text = "Last Update By: ";
            // 
            // LblLastUpdate
            // 
            this.LblLastUpdate.AutoSize = true;
            this.LblLastUpdate.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LblLastUpdate.Location = new System.Drawing.Point(626, 424);
            this.LblLastUpdate.Name = "LblLastUpdate";
            this.LblLastUpdate.Size = new System.Drawing.Size(71, 13);
            this.LblLastUpdate.TabIndex = 31;
            this.LblLastUpdate.Text = "Last Update: ";
            // 
            // LblPostalCode
            // 
            this.LblPostalCode.AutoSize = true;
            this.LblPostalCode.Location = new System.Drawing.Point(26, 520);
            this.LblPostalCode.Name = "LblPostalCode";
            this.LblPostalCode.Size = new System.Drawing.Size(70, 13);
            this.LblPostalCode.TabIndex = 18;
            this.LblPostalCode.Text = "Postal Code: ";
            // 
            // TxtPostalCode
            // 
            this.TxtPostalCode.Enabled = false;
            this.TxtPostalCode.Location = new System.Drawing.Point(102, 517);
            this.TxtPostalCode.Name = "TxtPostalCode";
            this.TxtPostalCode.Size = new System.Drawing.Size(252, 20);
            this.TxtPostalCode.TabIndex = 19;
            // 
            // TxtCity
            // 
            this.TxtCity.Enabled = false;
            this.TxtCity.Location = new System.Drawing.Point(102, 490);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(252, 20);
            this.TxtCity.TabIndex = 17;
            // 
            // LblAddress2
            // 
            this.LblAddress2.AutoSize = true;
            this.LblAddress2.Location = new System.Drawing.Point(13, 454);
            this.LblAddress2.Name = "LblAddress2";
            this.LblAddress2.Size = new System.Drawing.Size(83, 13);
            this.LblAddress2.TabIndex = 14;
            this.LblAddress2.Text = "Address Line 2: ";
            // 
            // TxtAddress2
            // 
            this.TxtAddress2.Enabled = false;
            this.TxtAddress2.Location = new System.Drawing.Point(102, 451);
            this.TxtAddress2.Name = "TxtAddress2";
            this.TxtAddress2.Size = new System.Drawing.Size(252, 20);
            this.TxtAddress2.TabIndex = 15;
            // 
            // LblAddress1
            // 
            this.LblAddress1.AutoSize = true;
            this.LblAddress1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LblAddress1.Location = new System.Drawing.Point(13, 427);
            this.LblAddress1.Name = "LblAddress1";
            this.LblAddress1.Size = new System.Drawing.Size(83, 13);
            this.LblAddress1.TabIndex = 12;
            this.LblAddress1.Text = "Address Line 1: ";
            // 
            // TxtAddress1
            // 
            this.TxtAddress1.Enabled = false;
            this.TxtAddress1.Location = new System.Drawing.Point(102, 424);
            this.TxtAddress1.Name = "TxtAddress1";
            this.TxtAddress1.Size = new System.Drawing.Size(252, 20);
            this.TxtAddress1.TabIndex = 13;
            // 
            // GrpCustomers
            // 
            this.GrpCustomers.Controls.Add(this.BtnLaunch);
            this.GrpCustomers.Controls.Add(this.LblCity);
            this.GrpCustomers.Controls.Add(this.LblPhone);
            this.GrpCustomers.Controls.Add(this.TxtPhone);
            this.GrpCustomers.Controls.Add(this.TxtSearch);
            this.GrpCustomers.Controls.Add(this.BtnSearch);
            this.GrpCustomers.Controls.Add(this.TxtCustomerId);
            this.GrpCustomers.Controls.Add(this.BtnDeleteCustomer);
            this.GrpCustomers.Controls.Add(this.DtpLastUpdate);
            this.GrpCustomers.Controls.Add(this.LblLastUpdate);
            this.GrpCustomers.Controls.Add(this.BtnModifyCustomer);
            this.GrpCustomers.Controls.Add(this.BtnAddCustomer);
            this.GrpCustomers.Controls.Add(this.DgvCustomers);
            this.GrpCustomers.Controls.Add(this.DtpCreateDate);
            this.GrpCustomers.Controls.Add(this.ChkActive);
            this.GrpCustomers.Controls.Add(this.LblHeader);
            this.GrpCustomers.Controls.Add(this.LblPostalCode);
            this.GrpCustomers.Controls.Add(this.TxtPostalCode);
            this.GrpCustomers.Controls.Add(this.TxtCity);
            this.GrpCustomers.Controls.Add(this.LblAddress2);
            this.GrpCustomers.Controls.Add(this.TxtAddress2);
            this.GrpCustomers.Controls.Add(this.LblAddress1);
            this.GrpCustomers.Controls.Add(this.TxtAddress1);
            this.GrpCustomers.Controls.Add(this.LblLastUpdateBy);
            this.GrpCustomers.Controls.Add(this.TxtLastUpdateBy);
            this.GrpCustomers.Controls.Add(this.LblAddressId);
            this.GrpCustomers.Controls.Add(this.CboAddressId);
            this.GrpCustomers.Controls.Add(this.LblCreatedBy);
            this.GrpCustomers.Controls.Add(this.TxtCreatedBy);
            this.GrpCustomers.Controls.Add(this.LblCreateDate);
            this.GrpCustomers.Controls.Add(this.LblCustomerName);
            this.GrpCustomers.Controls.Add(this.TxtCustomerName);
            this.GrpCustomers.Controls.Add(this.LblCustomerId);
            this.GrpCustomers.Location = new System.Drawing.Point(10, 27);
            this.GrpCustomers.Name = "GrpCustomers";
            this.GrpCustomers.Size = new System.Drawing.Size(986, 578);
            this.GrpCustomers.TabIndex = 34;
            this.GrpCustomers.TabStop = false;
            // 
            // BtnLaunch
            // 
            this.BtnLaunch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLaunch.BackgroundImage")));
            this.BtnLaunch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLaunch.Location = new System.Drawing.Point(193, 396);
            this.BtnLaunch.Name = "BtnLaunch";
            this.BtnLaunch.Size = new System.Drawing.Size(23, 22);
            this.BtnLaunch.TabIndex = 11;
            this.BtnLaunch.UseVisualStyleBackColor = true;
            this.BtnLaunch.Click += new System.EventHandler(this.BtnLaunch_Click);
            this.BtnLaunch.MouseHover += new System.EventHandler(this.BtnLaunch_MouseHover);
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.LblCity.Location = new System.Drawing.Point(63, 494);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(30, 13);
            this.LblCity.TabIndex = 16;
            this.LblCity.Text = "City: ";
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Location = new System.Drawing.Point(9, 551);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(84, 13);
            this.LblPhone.TabIndex = 20;
            this.LblPhone.Text = "Phone Number: ";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Enabled = false;
            this.TxtPhone.Location = new System.Drawing.Point(102, 548);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(252, 20);
            this.TxtPhone.TabIndex = 21;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TxtSearch.Location = new System.Drawing.Point(689, 10);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(212, 23);
            this.TxtSearch.TabIndex = 1;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(907, 10);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(59, 23);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtCustomerId
            // 
            this.TxtCustomerId.Enabled = false;
            this.TxtCustomerId.Location = new System.Drawing.Point(103, 328);
            this.TxtCustomerId.Name = "TxtCustomerId";
            this.TxtCustomerId.Size = new System.Drawing.Size(84, 20);
            this.TxtCustomerId.TabIndex = 5;
            // 
            // BtnDeleteCustomer
            // 
            this.BtnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteCustomer.Location = new System.Drawing.Point(415, 383);
            this.BtnDeleteCustomer.Name = "BtnDeleteCustomer";
            this.BtnDeleteCustomer.Size = new System.Drawing.Size(155, 23);
            this.BtnDeleteCustomer.TabIndex = 23;
            this.BtnDeleteCustomer.Text = "Delete Customer";
            this.BtnDeleteCustomer.UseVisualStyleBackColor = true;
            this.BtnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
            // 
            // DtpLastUpdate
            // 
            this.DtpLastUpdate.CustomFormat = "ddddd, MMMM dd, yyyy hh:mm:ss tt";
            this.DtpLastUpdate.Enabled = false;
            this.DtpLastUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpLastUpdate.Location = new System.Drawing.Point(703, 421);
            this.DtpLastUpdate.Name = "DtpLastUpdate";
            this.DtpLastUpdate.Size = new System.Drawing.Size(263, 20);
            this.DtpLastUpdate.TabIndex = 32;
            this.DtpLastUpdate.TabStop = false;
            // 
            // BtnModifyCustomer
            // 
            this.BtnModifyCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifyCustomer.Location = new System.Drawing.Point(414, 414);
            this.BtnModifyCustomer.Name = "BtnModifyCustomer";
            this.BtnModifyCustomer.Size = new System.Drawing.Size(155, 23);
            this.BtnModifyCustomer.TabIndex = 24;
            this.BtnModifyCustomer.Text = "Modify Customer";
            this.BtnModifyCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnModifyCustomer.UseVisualStyleBackColor = true;
            this.BtnModifyCustomer.Click += new System.EventHandler(this.BtnModifyCustomer_Click);
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCustomer.Location = new System.Drawing.Point(414, 352);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(155, 23);
            this.BtnAddCustomer.TabIndex = 22;
            this.BtnAddCustomer.Text = "Add Customer";
            this.BtnAddCustomer.UseVisualStyleBackColor = true;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // DgvCustomers
            // 
            this.DgvCustomers.AllowUserToAddRows = false;
            this.DgvCustomers.AllowUserToDeleteRows = false;
            this.DgvCustomers.AllowUserToResizeRows = false;
            this.DgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvCustomers.Location = new System.Drawing.Point(21, 39);
            this.DgvCustomers.Name = "DgvCustomers";
            this.DgvCustomers.RowHeadersVisible = false;
            this.DgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCustomers.Size = new System.Drawing.Size(945, 262);
            this.DgvCustomers.TabIndex = 3;
            this.DgvCustomers.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCustomers_CellMouseDoubleClick);
            this.DgvCustomers.SelectionChanged += new System.EventHandler(this.DgvCustomers_SelectionChanged);
            // 
            // DtpCreateDate
            // 
            this.DtpCreateDate.CustomFormat = "ddddd, MMMM dd, yyyy hh:mm:ss tt";
            this.DtpCreateDate.Enabled = false;
            this.DtpCreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpCreateDate.Location = new System.Drawing.Point(703, 395);
            this.DtpCreateDate.Name = "DtpCreateDate";
            this.DtpCreateDate.Size = new System.Drawing.Size(263, 20);
            this.DtpCreateDate.TabIndex = 30;
            this.DtpCreateDate.TabStop = false;
            // 
            // ChkActive
            // 
            this.ChkActive.AutoSize = true;
            this.ChkActive.Location = new System.Drawing.Point(292, 331);
            this.ChkActive.Name = "ChkActive";
            this.ChkActive.Size = new System.Drawing.Size(62, 17);
            this.ChkActive.TabIndex = 6;
            this.ChkActive.Text = "Active?";
            this.ChkActive.UseVisualStyleBackColor = true;
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.Location = new System.Drawing.Point(6, 16);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(90, 20);
            this.LblHeader.TabIndex = 0;
            this.LblHeader.Text = "Customers:";
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
            this.MnuMenu.TabIndex = 33;
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
            this.MnuCustomers.Checked = true;
            this.MnuCustomers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MnuCustomers.Name = "MnuCustomers";
            this.MnuCustomers.Size = new System.Drawing.Size(150, 22);
            this.MnuCustomers.Text = "C&ustomers";
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
            // TmrReminders
            // 
            this.TmrReminders.Enabled = true;
            this.TmrReminders.Tick += new System.EventHandler(this.TmrReminders_Tick);
            // 
            // MnuHelp
            // 
            this.MnuHelp.Name = "MnuHelp";
            this.MnuHelp.Size = new System.Drawing.Size(44, 20);
            this.MnuHelp.Text = "H&elp";
            this.MnuHelp.Click += new System.EventHandler(this.MnuHelp_Click);
            // 
            // FrmCustomers
            // 
            this.AcceptButton = this.BtnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 617);
            this.Controls.Add(this.MnuMenu);
            this.Controls.Add(this.GrpCustomers);
            this.Name = "FrmCustomers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            this.GrpCustomers.ResumeLayout(false);
            this.GrpCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).EndInit();
            this.MnuMenu.ResumeLayout(false);
            this.MnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblCustomerId;
        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.TextBox TxtCustomerName;
        private System.Windows.Forms.Label LblCreatedBy;
        private System.Windows.Forms.TextBox TxtCreatedBy;
        private System.Windows.Forms.ComboBox CboAddressId;
        private System.Windows.Forms.Label LblAddressId;
        private System.Windows.Forms.Label LblCreateDate;
        private System.Windows.Forms.TextBox TxtLastUpdateBy;
        private System.Windows.Forms.Label LblLastUpdateBy;
        private System.Windows.Forms.Label LblLastUpdate;
        private System.Windows.Forms.Label LblPostalCode;
        private System.Windows.Forms.TextBox TxtPostalCode;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.Label LblAddress2;
        private System.Windows.Forms.TextBox TxtAddress2;
        private System.Windows.Forms.Label LblAddress1;
        private System.Windows.Forms.TextBox TxtAddress1;
        private System.Windows.Forms.GroupBox GrpCustomers;
        private System.Windows.Forms.CheckBox ChkActive;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.DataGridView DgvCustomers;
        private System.Windows.Forms.DateTimePicker DtpLastUpdate;
        private System.Windows.Forms.DateTimePicker DtpCreateDate;
        private System.Windows.Forms.Button BtnDeleteCustomer;
        private System.Windows.Forms.Button BtnModifyCustomer;
        private System.Windows.Forms.Button BtnAddCustomer;
        private System.Windows.Forms.MenuStrip MnuMenu;
        private System.Windows.Forms.ToolStripMenuItem MnuApplications;
        private System.Windows.Forms.ToolStripMenuItem MnuAppointments;
        private System.Windows.Forms.ToolStripMenuItem MnuCalendar;
        private System.Windows.Forms.ToolStripMenuItem MnuCustomers;
        private System.Windows.Forms.ToolStripMenuItem MnuReports;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.TextBox TxtCustomerId;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Timer TmrReminders;
        private System.Windows.Forms.Label LblPhone;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.ToolStripMenuItem MnuAddresses;
        private System.Windows.Forms.Button BtnLaunch;
        private System.Windows.Forms.ToolStripMenuItem MnuHelp;
    }
}