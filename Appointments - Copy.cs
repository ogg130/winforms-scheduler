using MySql.Data.MySqlClient;
using RobertOgden.Models;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace RobertOgden
{
    public partial class FrmAppointments : Form
    {
        // Creates a new instance of the inventory class for the app to use

        private MySqlConnection _connection = new MySqlConnection("server=3.227.166.251;user id=U059rN;persistsecurityinfo=True;database=U059rN;allowuservariables=True;password=53688441700");
        private Scheduler _scheduler = new Scheduler();
        private string _state = "VIEW";

        
        public FrmAppointments()
        {
            InitializeComponent();

            //Open a database connection
            _connection.Open();

            // Create the SQL command, run it and uses its results to fill the grid's datasource property
            var command = new MySqlCommand($"SELECT * FROM appointment", _connection);
            var adapter = new MySqlDataAdapter(command);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);

            var appointments = new BindingList<Appointment>();

            for (var i = 0; i < dataTable.Rows.Count; ++i)
            {
                appointments.Add(new Appointment(dataTable.Rows[i]));
            }

            _scheduler.Appointments = appointments;

            DgvAppointments.DataSource = _scheduler.Appointments;

            command = new MySqlCommand($"SELECT * FROM user where userid = {appointments[0].UserId}", _connection);
            adapter = new MySqlDataAdapter(command);
            dataTable = new DataTable();
            adapter.Fill(dataTable);

            var users = new BindingList<User>();

            for (var i = 0; i < dataTable.Rows.Count; ++i)
            {
                users.Add(new User(dataTable.Rows[i]));
            }

            _scheduler.Users = users;

            DgvRelatedUser.DataSource = _scheduler.Users;




            command = new MySqlCommand($"SELECT * FROM customer where customerid = {appointments[0].CustomerId}", _connection);
            adapter = new MySqlDataAdapter(command);
            dataTable = new DataTable();
            adapter.Fill(dataTable);

            var customers = new BindingList<Customer>();

            for (var i = 0; i < dataTable.Rows.Count; ++i)
            {
                customers.Add(new Customer(dataTable.Rows[i]));
            }

            _scheduler.Customers = customers;

            DgvRelatedCustomer.DataSource = _scheduler.Customers;

            // DgvAppointments.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // TODO: Iterate over databound object to fill class








            // Hide the 5th-14th column from the datagrid view
            for (var i = 5; i < 14; ++i)
            {
                DgvAppointments.Columns[i].Visible = false;
            }

            // Place all record data in the texboxes on the right side of the form




            // TODO: ASSIGN GRIDVIEW DATA TO PRIVATE GLOBAL OBJECTS
        }

        private void FrmAppointments_Load(object sender, EventArgs e)
        {
            // TODO: Populate textboxes based on selected record

            var appointment = (Appointment)DgvAppointments.CurrentRow.DataBoundItem;

            TxtAppointmentId.Text = appointment.AppointmentId.ToString();
            TxtCustomerId.Text = appointment.CustomerId.ToString();
            TxtUserId.Text = appointment.UserId.ToString();
            TxtTitle.Text = appointment.Title.ToString();
            TxtDescription.Text = appointment.Description.ToString();
            TxtLocation.Text = appointment.Location.ToString();
            TxtContact.Text = appointment.Contact.ToString();
            TxtType.Text = appointment.Type.ToString();
            TxtUrl.Text = appointment.Url.ToString();
            TxtStart.Text = appointment.Start.ToString();
            TxtEnd.Text = appointment.End.ToString();
            TxtCreateDate.Text = appointment.CreateDate.ToString();
            TxtCreatedBy.Text = appointment.CreatedBy.ToString();
            TxtLastUpdate.Text = appointment.LastUpdate.ToString();
            TxtLastUpdateBy.Text = appointment.LastUpdateBy.ToString();
        }

        private void LblUserId_Click(object sender, EventArgs e)
        {

        }

        private void TxtUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            FrmAppointments_Load(sender, e);
        }

        private void BtnModifyAppointment_Click(object sender, EventArgs e)
        {
            if (_state == "MODIFY")
            {
                // Save here
                _state = "VIEW";

                BtnAddAppointment.Enabled = true;

                BtnModifyAppointment.Text = "Modify Appointment";
                TxtCustomerId.Enabled = false;
                TxtUserId.Enabled = false;
                TxtTitle.Enabled = false;
                TxtDescription.Enabled = false;
                TxtLocation.Enabled = false;
                TxtContact.Enabled = false;
                TxtType.Enabled = false;
                TxtUrl.Enabled = false;
                TxtStart.Enabled = false;
                TxtEnd.Enabled = false;
                TxtTitle.Enabled = false;
                TxtCreateDate.Enabled = false;
                TxtCreatedBy.Enabled = false;
                TxtLastUpdate.Enabled = false;
                TxtLastUpdateBy.Enabled = false;
                return;
            }

            if (_state == "VIEW")
            {
                _state = "MODIFY";
                BtnModifyAppointment.Text = "Save Modifications";
                BtnDeleteAppointment.Text = "Cancel Modifications";
                BtnAddAppointment.Enabled = false;

                TxtCustomerId.Enabled = true;
                TxtUserId.Enabled = true;
                TxtTitle.Enabled = true;
                TxtDescription.Enabled = true;
                TxtLocation.Enabled = true;
                TxtContact.Enabled = true;
                TxtType.Enabled = true;
                TxtUrl.Enabled = true;
                TxtStart.Enabled = true;
                TxtEnd.Enabled = true;
                TxtTitle.Enabled = true;
                TxtCreateDate.Enabled = true;
                TxtCreatedBy.Enabled = true;
                TxtLastUpdate.Enabled = true;
                TxtLastUpdateBy.Enabled = true;
                return;
            } 
        }

        private void BtnAddAppointment_Click(object sender, EventArgs e)
        {
            if (_state == "ADD")
            {
                _state = "VIEW";
                BtnAddAppointment.Text = "Add Appointment";
                BtnDeleteAppointment.Text = "Delete Appointment";

                BtnModifyAppointment.Enabled = true;

                TxtCustomerId.Enabled = false;
                TxtUserId.Enabled = false;
                TxtTitle.Enabled = false;
                TxtDescription.Enabled = false;
                TxtLocation.Enabled = false;
                TxtContact.Enabled = false;
                TxtType.Enabled = false;
                TxtUrl.Enabled = false;
                TxtEnd.Enabled = false;
                TxtTitle.Enabled = false;
                TxtCreateDate.Enabled = false;
                TxtCreatedBy.Enabled = false;
                TxtLastUpdate.Enabled = false;
                TxtLastUpdateBy.Enabled = false;

                //TODO: Generate Appointment ID 
                return;
            }

            if (_state != "ADD")
            {
                _state = "ADD";
                BtnAddAppointment.Text = "Save New Appointment";
                BtnDeleteAppointment.Text = "Cancel New Appointment";

                BtnModifyAppointment.Enabled = false;

                TxtAppointmentId.Text = "";
                TxtCustomerId.Text = "";
                TxtCustomerId.Enabled = true;
                TxtUserId.Text = "";
                TxtUserId.Enabled = true;
                TxtTitle.Text = "";
                TxtTitle.Enabled = true;
                TxtDescription.Text = "";
                TxtDescription.Enabled = true;
                TxtLocation.Text = "";
                TxtLocation.Enabled = true;
                TxtContact.Text = "";
                TxtContact.Enabled = true;
                TxtType.Text = "";
                TxtType.Enabled = true;
                TxtUrl.Text = "";
                TxtUrl.Enabled = true;
                TxtStart.Text = "";
                TxtStart.Enabled = true;
                TxtEnd.Text = "";
                TxtEnd.Enabled = true;
                TxtTitle.Text = "";
                TxtTitle.Enabled = true;
                TxtCreateDate.Text = "";
                TxtCreateDate.Enabled = true;
                TxtCreatedBy.Text = "";
                TxtCreatedBy.Enabled = true;
                TxtLastUpdate.Text = "";
                TxtLastUpdate.Enabled = true;
                TxtLastUpdateBy.Text = "";
                TxtLastUpdateBy.Enabled = true;

                //TODO: Select new record in gridview

                return;
            }


        }

        private void BtnDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (_state == "ADD")
            {
                _state = "VIEW";

                BtnAddAppointment.Text = "Add Appointment";
                BtnDeleteAppointment.Text = "Delete Appointment";

                BtnModifyAppointment.Enabled = true;

                TxtCustomerId.Enabled = false;
                TxtUserId.Enabled = false;
                TxtTitle.Enabled = false;
                TxtDescription.Enabled = false;
                TxtLocation.Enabled = false;
                TxtContact.Enabled = false;
                TxtType.Enabled = false;
                TxtUrl.Enabled = false;
                TxtStart.Enabled = false;
                TxtEnd.Enabled = false;
                TxtTitle.Enabled = false;
                TxtCreateDate.Enabled = false;
                TxtCreatedBy.Enabled = false;
                TxtLastUpdate.Enabled = false;
                TxtLastUpdateBy.Enabled = false;

                FrmAppointments_Load(sender, e);
            }

            if (_state == "MODIFY")
            {
                _state = "VIEW";

                BtnAddAppointment.Text = "Add Appointment";
                BtnModifyAppointment.Text = "Modify Appointment";
                BtnDeleteAppointment.Text = "Delete Appointment";

                BtnModifyAppointment.Enabled = true;
                BtnAddAppointment.Enabled = true;
                BtnDeleteAppointment.Enabled = true;
                TxtCustomerId.Enabled = false;
                TxtUserId.Enabled = false;
                TxtTitle.Enabled = false;
                TxtDescription.Enabled = false;
                TxtLocation.Enabled = false;
                TxtContact.Enabled = false;
                TxtType.Enabled = false;
                TxtUrl.Enabled = false;
                TxtStart.Enabled = false;
                TxtEnd.Enabled = false;
                TxtTitle.Enabled = false;
                TxtCreateDate.Enabled = false;
                TxtCreatedBy.Enabled = false;
                TxtLastUpdate.Enabled = false;
                TxtLastUpdateBy.Enabled = false;

                FrmAppointments_Load(sender, e);
            }

            if (_state == "VIEW") {
                // TODO: Delete the currently selected line2
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void GrpAppointmentData_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
    }
