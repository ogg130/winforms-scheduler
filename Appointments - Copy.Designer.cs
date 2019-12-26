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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrpViewAppointments = new System.Windows.Forms.GroupBox();
            this.RdoAll = new System.Windows.Forms.RadioButton();
            this.RdoMonth = new System.Windows.Forms.RadioButton();
            this.RdoWeek = new System.Windows.Forms.RadioButton();
            this.LblHeader = new System.Windows.Forms.Label();
            this.DgvAppointments = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.BtnDeleteAppointment = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnModifyAppointment = new System.Windows.Forms.Button();
            this.BtnAddAppointment = new System.Windows.Forms.Button();
            this.GrpAppointmentData = new System.Windows.Forms.GroupBox();
            this.LblLastUpdateBy = new System.Windows.Forms.Label();
            this.TxtLastUpdateBy = new System.Windows.Forms.TextBox();
            this.LblLastUpdate = new System.Windows.Forms.Label();
            this.TxtLastUpdate = new System.Windows.Forms.TextBox();
            this.LblCreatedBy = new System.Windows.Forms.Label();
            this.TxtCreatedBy = new System.Windows.Forms.TextBox();
            this.LblCreateDate = new System.Windows.Forms.Label();
            this.TxtCreateDate = new System.Windows.Forms.TextBox();
            this.LblEnd = new System.Windows.Forms.Label();
            this.TxtEnd = new System.Windows.Forms.TextBox();
            this.LblStart = new System.Windows.Forms.Label();
            this.TxtStart = new System.Windows.Forms.TextBox();
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
            this.TxtUserId = new System.Windows.Forms.TextBox();
            this.LblCustomerId = new System.Windows.Forms.Label();
            this.TxtCustomerId = new System.Windows.Forms.TextBox();
            this.LblAppointmentId = new System.Windows.Forms.Label();
            this.TxtAppointmentId = new System.Windows.Forms.TextBox();
            this.DgvRelatedCustomer = new System.Windows.Forms.DataGridView();
            this.DgvRelatedUser = new System.Windows.Forms.DataGridView();
            this.LblRelatedCustomer = new System.Windows.Forms.Label();
            this.LblRelatedUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.process1 = new System.Diagnostics.Process();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GrpViewAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAppointments)).BeginInit();
            this.GrpAppointmentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRelatedCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRelatedUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpViewAppointments
            // 
            this.GrpViewAppointments.Controls.Add(this.RdoAll);
            this.GrpViewAppointments.Controls.Add(this.RdoMonth);
            this.GrpViewAppointments.Controls.Add(this.RdoWeek);
            this.GrpViewAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GrpViewAppointments.Location = new System.Drawing.Point(297, 19);
            this.GrpViewAppointments.Name = "GrpViewAppointments";
            this.GrpViewAppointments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GrpViewAppointments.Size = new System.Drawing.Size(166, 94);
            this.GrpViewAppointments.TabIndex = 37;
            this.GrpViewAppointments.TabStop = false;
            this.GrpViewAppointments.Text = "View Appointments by:";
            this.GrpViewAppointments.UseCompatibleTextRendering = true;
            // 
            // RdoAll
            // 
            this.RdoAll.AutoSize = true;
            this.RdoAll.Checked = true;
            this.RdoAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.RdoAll.Location = new System.Drawing.Point(26, 19);
            this.RdoAll.Name = "RdoAll";
            this.RdoAll.Size = new System.Drawing.Size(73, 20);
            this.RdoAll.TabIndex = 38;
            this.RdoAll.TabStop = true;
            this.RdoAll.Text = "View All";
            this.RdoAll.UseVisualStyleBackColor = true;
            // 
            // RdoMonth
            // 
            this.RdoMonth.AutoSize = true;
            this.RdoMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.RdoMonth.Location = new System.Drawing.Point(26, 42);
            this.RdoMonth.Name = "RdoMonth";
            this.RdoMonth.Size = new System.Drawing.Size(112, 20);
            this.RdoMonth.TabIndex = 1;
            this.RdoMonth.Text = "View by Month";
            this.RdoMonth.UseVisualStyleBackColor = true;
            // 
            // RdoWeek
            // 
            this.RdoWeek.AutoSize = true;
            this.RdoWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.RdoWeek.Location = new System.Drawing.Point(26, 65);
            this.RdoWeek.Name = "RdoWeek";
            this.RdoWeek.Size = new System.Drawing.Size(112, 20);
            this.RdoWeek.TabIndex = 0;
            this.RdoWeek.Text = "View by Week";
            this.RdoWeek.UseVisualStyleBackColor = true;
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.Location = new System.Drawing.Point(14, 14);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(133, 20);
            this.LblHeader.TabIndex = 36;
            this.LblHeader.Text = "All Appointments:";
            // 
            // DgvAppointments
            // 
            this.DgvAppointments.AllowUserToAddRows = false;
            this.DgvAppointments.AllowUserToDeleteRows = false;
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
            this.DgvAppointments.Location = new System.Drawing.Point(18, 52);
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
            this.DgvAppointments.Size = new System.Drawing.Size(507, 331);
            this.DgvAppointments.TabIndex = 32;
            this.DgvAppointments.SelectionChanged += new System.EventHandler(this.DgvAppointments_SelectionChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearch.Location = new System.Drawing.Point(313, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 23);
            this.txtSearch.TabIndex = 30;
            // 
            // BtnDeleteAppointment
            // 
            this.BtnDeleteAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteAppointment.Location = new System.Drawing.Point(828, 447);
            this.BtnDeleteAppointment.Name = "BtnDeleteAppointment";
            this.BtnDeleteAppointment.Size = new System.Drawing.Size(182, 23);
            this.BtnDeleteAppointment.TabIndex = 35;
            this.BtnDeleteAppointment.Text = "Delete Appointment";
            this.BtnDeleteAppointment.UseVisualStyleBackColor = true;
            this.BtnDeleteAppointment.Click += new System.EventHandler(this.BtnDeleteAppointment_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(248, 11);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(59, 23);
            this.BtnSearch.TabIndex = 31;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // BtnModifyAppointment
            // 
            this.BtnModifyAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifyAppointment.Location = new System.Drawing.Point(828, 418);
            this.BtnModifyAppointment.Name = "BtnModifyAppointment";
            this.BtnModifyAppointment.Size = new System.Drawing.Size(182, 23);
            this.BtnModifyAppointment.TabIndex = 34;
            this.BtnModifyAppointment.Text = "Modify Appointment";
            this.BtnModifyAppointment.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnModifyAppointment.UseVisualStyleBackColor = true;
            this.BtnModifyAppointment.Click += new System.EventHandler(this.BtnModifyAppointment_Click);
            // 
            // BtnAddAppointment
            // 
            this.BtnAddAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddAppointment.Location = new System.Drawing.Point(828, 389);
            this.BtnAddAppointment.Name = "BtnAddAppointment";
            this.BtnAddAppointment.Size = new System.Drawing.Size(182, 23);
            this.BtnAddAppointment.TabIndex = 33;
            this.BtnAddAppointment.Text = "Add Appointment";
            this.BtnAddAppointment.UseVisualStyleBackColor = true;
            this.BtnAddAppointment.Click += new System.EventHandler(this.BtnAddAppointment_Click);
            // 
            // GrpAppointmentData
            // 
            this.GrpAppointmentData.Controls.Add(this.pictureBox1);
            this.GrpAppointmentData.Controls.Add(this.LblLastUpdateBy);
            this.GrpAppointmentData.Controls.Add(this.TxtLastUpdateBy);
            this.GrpAppointmentData.Controls.Add(this.GrpViewAppointments);
            this.GrpAppointmentData.Controls.Add(this.LblLastUpdate);
            this.GrpAppointmentData.Controls.Add(this.TxtLastUpdate);
            this.GrpAppointmentData.Controls.Add(this.LblCreatedBy);
            this.GrpAppointmentData.Controls.Add(this.TxtCreatedBy);
            this.GrpAppointmentData.Controls.Add(this.LblCreateDate);
            this.GrpAppointmentData.Controls.Add(this.TxtCreateDate);
            this.GrpAppointmentData.Controls.Add(this.LblEnd);
            this.GrpAppointmentData.Controls.Add(this.TxtEnd);
            this.GrpAppointmentData.Controls.Add(this.LblStart);
            this.GrpAppointmentData.Controls.Add(this.TxtStart);
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
            this.GrpAppointmentData.Controls.Add(this.TxtUserId);
            this.GrpAppointmentData.Controls.Add(this.LblCustomerId);
            this.GrpAppointmentData.Controls.Add(this.TxtCustomerId);
            this.GrpAppointmentData.Controls.Add(this.LblAppointmentId);
            this.GrpAppointmentData.Controls.Add(this.TxtAppointmentId);
            this.GrpAppointmentData.Location = new System.Drawing.Point(531, 11);
            this.GrpAppointmentData.Name = "GrpAppointmentData";
            this.GrpAppointmentData.Size = new System.Drawing.Size(477, 372);
            this.GrpAppointmentData.TabIndex = 39;
            this.GrpAppointmentData.TabStop = false;
            this.GrpAppointmentData.Text = "Appointment Data for appointment #:";
            this.GrpAppointmentData.Enter += new System.EventHandler(this.GrpAppointmentData_Enter);
            // 
            // LblLastUpdateBy
            // 
            this.LblLastUpdateBy.AutoSize = true;
            this.LblLastUpdateBy.Location = new System.Drawing.Point(241, 338);
            this.LblLastUpdateBy.Name = "LblLastUpdateBy";
            this.LblLastUpdateBy.Size = new System.Drawing.Size(83, 13);
            this.LblLastUpdateBy.TabIndex = 29;
            this.LblLastUpdateBy.Text = "Last Update By:";
            // 
            // TxtLastUpdateBy
            // 
            this.TxtLastUpdateBy.Enabled = false;
            this.TxtLastUpdateBy.Location = new System.Drawing.Point(330, 335);
            this.TxtLastUpdateBy.Name = "TxtLastUpdateBy";
            this.TxtLastUpdateBy.Size = new System.Drawing.Size(135, 20);
            this.TxtLastUpdateBy.TabIndex = 28;
            // 
            // LblLastUpdate
            // 
            this.LblLastUpdate.AutoSize = true;
            this.LblLastUpdate.Location = new System.Drawing.Point(255, 309);
            this.LblLastUpdate.Name = "LblLastUpdate";
            this.LblLastUpdate.Size = new System.Drawing.Size(68, 13);
            this.LblLastUpdate.TabIndex = 27;
            this.LblLastUpdate.Text = "Last Update:";
            // 
            // TxtLastUpdate
            // 
            this.TxtLastUpdate.Enabled = false;
            this.TxtLastUpdate.Location = new System.Drawing.Point(330, 307);
            this.TxtLastUpdate.Name = "TxtLastUpdate";
            this.TxtLastUpdate.Size = new System.Drawing.Size(135, 20);
            this.TxtLastUpdate.TabIndex = 26;
            // 
            // LblCreatedBy
            // 
            this.LblCreatedBy.AutoSize = true;
            this.LblCreatedBy.Location = new System.Drawing.Point(24, 336);
            this.LblCreatedBy.Name = "LblCreatedBy";
            this.LblCreatedBy.Size = new System.Drawing.Size(62, 13);
            this.LblCreatedBy.TabIndex = 25;
            this.LblCreatedBy.Text = "Created By:";
            // 
            // TxtCreatedBy
            // 
            this.TxtCreatedBy.Enabled = false;
            this.TxtCreatedBy.Location = new System.Drawing.Point(92, 334);
            this.TxtCreatedBy.Name = "TxtCreatedBy";
            this.TxtCreatedBy.Size = new System.Drawing.Size(135, 20);
            this.TxtCreatedBy.TabIndex = 24;
            // 
            // LblCreateDate
            // 
            this.LblCreateDate.AutoSize = true;
            this.LblCreateDate.Location = new System.Drawing.Point(17, 309);
            this.LblCreateDate.Name = "LblCreateDate";
            this.LblCreateDate.Size = new System.Drawing.Size(67, 13);
            this.LblCreateDate.TabIndex = 23;
            this.LblCreateDate.Text = "Create Date:";
            // 
            // TxtCreateDate
            // 
            this.TxtCreateDate.Enabled = false;
            this.TxtCreateDate.Location = new System.Drawing.Point(92, 306);
            this.TxtCreateDate.Name = "TxtCreateDate";
            this.TxtCreateDate.Size = new System.Drawing.Size(135, 20);
            this.TxtCreateDate.TabIndex = 22;
            // 
            // LblEnd
            // 
            this.LblEnd.AutoSize = true;
            this.LblEnd.Location = new System.Drawing.Point(294, 279);
            this.LblEnd.Name = "LblEnd";
            this.LblEnd.Size = new System.Drawing.Size(29, 13);
            this.LblEnd.TabIndex = 21;
            this.LblEnd.Text = "End:";
            // 
            // TxtEnd
            // 
            this.TxtEnd.Enabled = false;
            this.TxtEnd.Location = new System.Drawing.Point(330, 277);
            this.TxtEnd.Name = "TxtEnd";
            this.TxtEnd.Size = new System.Drawing.Size(135, 20);
            this.TxtEnd.TabIndex = 20;
            // 
            // LblStart
            // 
            this.LblStart.AutoSize = true;
            this.LblStart.Location = new System.Drawing.Point(52, 277);
            this.LblStart.Name = "LblStart";
            this.LblStart.Size = new System.Drawing.Size(32, 13);
            this.LblStart.TabIndex = 19;
            this.LblStart.Text = "Start:";
            // 
            // TxtStart
            // 
            this.TxtStart.Enabled = false;
            this.TxtStart.Location = new System.Drawing.Point(91, 275);
            this.TxtStart.Name = "TxtStart";
            this.TxtStart.Size = new System.Drawing.Size(135, 20);
            this.TxtStart.TabIndex = 18;
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Location = new System.Drawing.Point(54, 208);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(32, 13);
            this.LblUrl.TabIndex = 17;
            this.LblUrl.Text = "URL:";
            // 
            // TxtUrl
            // 
            this.TxtUrl.Enabled = false;
            this.TxtUrl.Location = new System.Drawing.Point(92, 205);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(371, 20);
            this.TxtUrl.TabIndex = 16;
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.Location = new System.Drawing.Point(51, 180);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(34, 13);
            this.LblType.TabIndex = 15;
            this.LblType.Text = "Type:";
            // 
            // TxtType
            // 
            this.TxtType.Enabled = false;
            this.TxtType.Location = new System.Drawing.Point(91, 177);
            this.TxtType.Name = "TxtType";
            this.TxtType.Size = new System.Drawing.Size(372, 20);
            this.TxtType.TabIndex = 14;
            // 
            // LblContact
            // 
            this.LblContact.AutoSize = true;
            this.LblContact.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblContact.Location = new System.Drawing.Point(39, 152);
            this.LblContact.Name = "LblContact";
            this.LblContact.Size = new System.Drawing.Size(47, 13);
            this.LblContact.TabIndex = 13;
            this.LblContact.Text = "Contact:";
            // 
            // TxtContact
            // 
            this.TxtContact.Enabled = false;
            this.TxtContact.Location = new System.Drawing.Point(91, 149);
            this.TxtContact.Name = "TxtContact";
            this.TxtContact.Size = new System.Drawing.Size(372, 20);
            this.TxtContact.TabIndex = 12;
            // 
            // LblLocation
            // 
            this.LblLocation.AutoSize = true;
            this.LblLocation.Location = new System.Drawing.Point(34, 96);
            this.LblLocation.Name = "LblLocation";
            this.LblLocation.Size = new System.Drawing.Size(51, 13);
            this.LblLocation.TabIndex = 11;
            this.LblLocation.Text = "Location:";
            // 
            // TxtLocation
            // 
            this.TxtLocation.Enabled = false;
            this.TxtLocation.Location = new System.Drawing.Point(91, 93);
            this.TxtLocation.Name = "TxtLocation";
            this.TxtLocation.Size = new System.Drawing.Size(177, 20);
            this.TxtLocation.TabIndex = 10;
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(23, 236);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(63, 13);
            this.LblDescription.TabIndex = 9;
            this.LblDescription.Text = "Description:";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Enabled = false;
            this.TxtDescription.Location = new System.Drawing.Point(91, 233);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(372, 20);
            this.TxtDescription.TabIndex = 8;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(54, 125);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(30, 13);
            this.LblTitle.TabIndex = 7;
            this.LblTitle.Text = "Title:";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Enabled = false;
            this.TxtTitle.Location = new System.Drawing.Point(91, 121);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(372, 20);
            this.TxtTitle.TabIndex = 6;
            // 
            // LblUserId
            // 
            this.LblUserId.AutoSize = true;
            this.LblUserId.Location = new System.Drawing.Point(40, 59);
            this.LblUserId.Name = "LblUserId";
            this.LblUserId.Size = new System.Drawing.Size(46, 13);
            this.LblUserId.TabIndex = 5;
            this.LblUserId.Text = "User ID:";
            this.LblUserId.Click += new System.EventHandler(this.LblUserId_Click);
            // 
            // TxtUserId
            // 
            this.TxtUserId.Enabled = false;
            this.TxtUserId.Location = new System.Drawing.Point(92, 56);
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.Size = new System.Drawing.Size(35, 20);
            this.TxtUserId.TabIndex = 4;
            this.TxtUserId.TextChanged += new System.EventHandler(this.TxtUserId_TextChanged);
            // 
            // LblCustomerId
            // 
            this.LblCustomerId.AutoSize = true;
            this.LblCustomerId.Location = new System.Drawing.Point(133, 59);
            this.LblCustomerId.Name = "LblCustomerId";
            this.LblCustomerId.Size = new System.Drawing.Size(68, 13);
            this.LblCustomerId.TabIndex = 3;
            this.LblCustomerId.Text = "Customer ID:";
            // 
            // TxtCustomerId
            // 
            this.TxtCustomerId.Enabled = false;
            this.TxtCustomerId.Location = new System.Drawing.Point(207, 56);
            this.TxtCustomerId.Name = "TxtCustomerId";
            this.TxtCustomerId.Size = new System.Drawing.Size(35, 20);
            this.TxtCustomerId.TabIndex = 2;
            // 
            // LblAppointmentId
            // 
            this.LblAppointmentId.AutoSize = true;
            this.LblAppointmentId.Location = new System.Drawing.Point(3, 32);
            this.LblAppointmentId.Name = "LblAppointmentId";
            this.LblAppointmentId.Size = new System.Drawing.Size(83, 13);
            this.LblAppointmentId.TabIndex = 1;
            this.LblAppointmentId.Text = "Appointment ID:";
            // 
            // TxtAppointmentId
            // 
            this.TxtAppointmentId.Enabled = false;
            this.TxtAppointmentId.Location = new System.Drawing.Point(92, 29);
            this.TxtAppointmentId.Name = "TxtAppointmentId";
            this.TxtAppointmentId.Size = new System.Drawing.Size(34, 20);
            this.TxtAppointmentId.TabIndex = 0;
            // 
            // DgvRelatedCustomer
            // 
            this.DgvRelatedCustomer.AllowUserToAddRows = false;
            this.DgvRelatedCustomer.AllowUserToDeleteRows = false;
            this.DgvRelatedCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRelatedCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvRelatedCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvRelatedCustomer.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvRelatedCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvRelatedCustomer.Location = new System.Drawing.Point(18, 418);
            this.DgvRelatedCustomer.MultiSelect = false;
            this.DgvRelatedCustomer.Name = "DgvRelatedCustomer";
            this.DgvRelatedCustomer.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRelatedCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvRelatedCustomer.RowHeadersVisible = false;
            this.DgvRelatedCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRelatedCustomer.Size = new System.Drawing.Size(789, 53);
            this.DgvRelatedCustomer.TabIndex = 40;
            // 
            // DgvRelatedUser
            // 
            this.DgvRelatedUser.AllowUserToAddRows = false;
            this.DgvRelatedUser.AllowUserToDeleteRows = false;
            this.DgvRelatedUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRelatedUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvRelatedUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvRelatedUser.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvRelatedUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvRelatedUser.Location = new System.Drawing.Point(18, 500);
            this.DgvRelatedUser.MultiSelect = false;
            this.DgvRelatedUser.Name = "DgvRelatedUser";
            this.DgvRelatedUser.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRelatedUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvRelatedUser.RowHeadersVisible = false;
            this.DgvRelatedUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRelatedUser.Size = new System.Drawing.Size(793, 53);
            this.DgvRelatedUser.TabIndex = 41;
            // 
            // LblRelatedCustomer
            // 
            this.LblRelatedCustomer.AutoSize = true;
            this.LblRelatedCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRelatedCustomer.Location = new System.Drawing.Point(14, 392);
            this.LblRelatedCustomer.Name = "LblRelatedCustomer";
            this.LblRelatedCustomer.Size = new System.Drawing.Size(142, 20);
            this.LblRelatedCustomer.TabIndex = 42;
            this.LblRelatedCustomer.Text = "Related Customer:";
            this.LblRelatedCustomer.Click += new System.EventHandler(this.Label1_Click);
            // 
            // LblRelatedUser
            // 
            this.LblRelatedUser.AutoSize = true;
            this.LblRelatedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRelatedUser.Location = new System.Drawing.Point(14, 477);
            this.LblRelatedUser.Name = "LblRelatedUser";
            this.LblRelatedUser.Size = new System.Drawing.Size(107, 20);
            this.LblRelatedUser.TabIndex = 43;
            this.LblRelatedUser.Text = "Related User:";
            this.LblRelatedUser.Click += new System.EventHandler(this.Label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(249, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 20);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(826, 530);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(182, 23);
            this.BtnExit.TabIndex = 44;
            this.BtnExit.Text = "Exit ";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FrmAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 566);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LblRelatedUser);
            this.Controls.Add(this.LblRelatedCustomer);
            this.Controls.Add(this.DgvRelatedUser);
            this.Controls.Add(this.DgvRelatedCustomer);
            this.Controls.Add(this.BtnDeleteAppointment);
            this.Controls.Add(this.GrpAppointmentData);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.DgvAppointments);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnModifyAppointment);
            this.Controls.Add(this.BtnAddAppointment);
            this.Name = "FrmAppointments";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.FrmAppointments_Load);
            this.GrpViewAppointments.ResumeLayout(false);
            this.GrpViewAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAppointments)).EndInit();
            this.GrpAppointmentData.ResumeLayout(false);
            this.GrpAppointmentData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRelatedCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRelatedUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpViewAppointments;
        private System.Windows.Forms.RadioButton RdoMonth;
        private System.Windows.Forms.RadioButton RdoWeek;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.DataGridView DgvAppointments;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button BtnDeleteAppointment;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnModifyAppointment;
        private System.Windows.Forms.Button BtnAddAppointment;
        private System.Windows.Forms.RadioButton RdoAll;
        private System.Windows.Forms.GroupBox GrpAppointmentData;
        private System.Windows.Forms.Label LblAppointmentId;
        private System.Windows.Forms.TextBox TxtAppointmentId;
        private System.Windows.Forms.Label LblLastUpdateBy;
        private System.Windows.Forms.TextBox TxtLastUpdateBy;
        private System.Windows.Forms.Label LblLastUpdate;
        private System.Windows.Forms.TextBox TxtLastUpdate;
        private System.Windows.Forms.Label LblCreatedBy;
        private System.Windows.Forms.TextBox TxtCreatedBy;
        private System.Windows.Forms.Label LblCreateDate;
        private System.Windows.Forms.TextBox TxtCreateDate;
        private System.Windows.Forms.Label LblEnd;
        private System.Windows.Forms.TextBox TxtEnd;
        private System.Windows.Forms.Label LblStart;
        private System.Windows.Forms.TextBox TxtStart;
        private System.Windows.Forms.Label LblUrl;
        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.TextBox TxtType;
        private System.Windows.Forms.Label LblContact;
        private System.Windows.Forms.TextBox TxtContact;
        private System.Windows.Forms.Label LblLocation;
        private System.Windows.Forms.TextBox TxtLocation;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label LblUserId;
        private System.Windows.Forms.TextBox TxtUserId;
        private System.Windows.Forms.Label LblCustomerId;
        private System.Windows.Forms.TextBox TxtCustomerId;
        private System.Windows.Forms.DataGridView DgvRelatedCustomer;
        private System.Windows.Forms.DataGridView DgvRelatedUser;
        private System.Windows.Forms.Label LblRelatedCustomer;
        private System.Windows.Forms.Label LblRelatedUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Button BtnExit;
    }
}

