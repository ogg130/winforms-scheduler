using RobertOgden.Data.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RobertOgden
{
    public partial class FrmAppointments : Form
    {
        private readonly Scheduler _scheduler = new Scheduler(); // Scheduler data
        private List<string> _reminders;  // Reminder data
        private string _state = "VIEW"; // The state of the form
        private bool _firstLoad = true; // Flag to indicate if this is the first load of the screen
        private readonly int _userId; // The currently logged in users user ID
        private readonly string _currentUser; // The currently logged in users name
        private readonly int _appoinmentId; // Appointmnet ID that gets passed into the form
        private Timer _timer;

        public FrmAppointments()
        {
            InitializeComponent();
        }

        public FrmAppointments(Scheduler scheduler, int userId, List<string> reminders, int appointmentId, Timer timer)
        {
            InitializeComponent();

            // Set up gloablly used objects that are passed into the form
            _userId = userId;
            _scheduler = scheduler;
            _reminders = reminders;
            _appoinmentId = appointmentId;
            _timer = timer;
            _currentUser = _scheduler.Users.FirstOrDefault(r => r.UserId == _userId).UserName;

            PopulateDataBoundControls(true); //Populate data bound controls
        }

        public FrmAppointments(Scheduler scheduler, int userId, List<string> reminders, Timer timer)
        {
            InitializeComponent();

            // Set up gloablly used objects that are passed into the form
            _userId = userId;
            _scheduler = scheduler;
            _reminders = reminders;
            _timer = timer;
            _currentUser = _scheduler.Users.FirstOrDefault(r => r.UserId == _userId).UserName;

            PopulateDataBoundControls(); //Populate data bound controls
        }

        private void FrmAppointments_Load(object sender, EventArgs e)
        {
            PopulateInputs(); // Populate text and date inputs
            ToggleDataEntryFields(false); // Toggle data entry field usability
        }

        private void DgvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            SelectionChange(); // Process events that occur when a selection change occurs
        }

        private void BtnModifyAppointment_Click(object sender, EventArgs e)
        {
            HandleModify(); // Handle modify button click
        }

        private void BtnAddAppointment_Click(object sender, EventArgs e)
        {
            HandleAdd(); // Handle Add button click
        }

        private void BtnDeleteAppointment_Click(object sender, EventArgs e)
        {
            HandleDelete(); // Handle Delete button click
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Handle Search button click
            SharedUtils.HandleSearch(DgvAppointments, _scheduler, TxtSearch.Text);
        }

        private void CboUserId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_firstLoad)
            {
                return;
            }
            // Set the name of the currently selected user
            TxtUserName.Text = SharedUtils.UpdateName(CboUserId, _scheduler.Users);
        }

        private void CboCustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If this is not the first form load
            if (_firstLoad)
            {
                return;
            }
            // Set the name of the currently selected customer
            TxtCustomerName.Text = SharedUtils.UpdateName(CboCustomerId, _scheduler.Customers);
        }

        private void TxtTitle_TextChanged(object sender, EventArgs e)
        {
            // Validate field input, indicate any problems visually
            SharedUtils.ValidateText(TxtTitle, ToolTip, LblTitle);
        }

        private void TxtDescription_TextChanged(object sender, EventArgs e)
        {
            // Validate field input, indicate any problems visually
            SharedUtils.ValidateText(TxtDescription, ToolTip, LblDescription);
        }

        private void DtpStart_ValueChanged(object sender, EventArgs e)
        {
            ResetDateLabels(); // Reset date labels if overlap have been corrected
        }

        private void DtpEnd_ValueChanged(object sender, EventArgs e)
        {
            ResetDateLabels(); // Reset date labels if overlap has been corrected
        }

        private void MnuCalendar_Click(object sender, EventArgs e)
        {
            // Hide current form, show new form
            SharedUtils.OpenForm(this, new FrmCalendar(_scheduler, _userId, _reminders, _timer));
        }

        private void MnuCustomers_Click(object sender, EventArgs e)
        {
            // Hide current form, show new form
            SharedUtils.OpenForm(this, new FrmCustomers(_scheduler, _userId, _reminders, _timer));
        }

        private void MnuReports_Click(object sender, EventArgs e)
        {
            // Hide current form, show new form
            SharedUtils.OpenForm(this, new FrmReports(_scheduler, _userId, _reminders, _timer));
        }

        private void MnuAddresses_Click(object sender, EventArgs e)
        {
            // Hide current form, show new form
            SharedUtils.OpenForm(this, new FrmAddresses(_scheduler, _userId, _reminders, _timer));
        }

        private void BtnLaunch_Click(object sender, EventArgs e)
        {
            LaunchCustomers();
        }

        private void DgvAppointments_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Handle Modify
            HandleModify();
        }

        private void BtnLaunch_MouseHover(object sender, EventArgs e)
        {
            // Hide any old tooltips, display new tooltip
            const string MESSAGE = "Click to add/modify customers.";
            ToolTip.Hide(BtnLaunch);
            ToolTip.Show(MESSAGE, BtnLaunch);
        }

        // Method which processes events that occur when a selection change occurs
        private void SelectionChange()
        {
            // If the form is not in VIEW mode
            if (_state != "VIEW")
            {
                return; // Exit
            }

            // If there is not a row that is selected
            if (DgvAppointments.CurrentRow == null)
            {
                return; // Exit
            }
            PopulateInputs(); // Populate input data for currently selected row
        }

        /* Method which handles modify button click events */

        private void HandleModify()
        {
            // If the current form state is in MODIFY mode
            if (_state == "MODIFY")
            {
                // Finish(save) modification and return
                ModifyAppointment();
                return;
            }

            // If the current form state is in VIEW mode
            if (_state == "VIEW")
            {
                // Convert the form to be used for data entry for modification
                StartModify();
                return;
            }
        }

        /* Method which handles Delete button clicks */

        private void HandleDelete()
        {
            // If the form state is in ADD mode
            if (_state == "ADD")
            {
                // Cancel the add
                CancelAdd();
                return;
            }

            // If the form state is in MODIFY mode
            if (_state == "MODIFY")
            {
                // Cancel the modification
                CancelModify();
                return;
            }

            // If the form state is in VIEW mode
            if (_state == "VIEW")
            {
                // This is an actual delete. Delete the record
                FinishDelete();
                return;
            }
        }

        /* Method which handles Add button clicks */

        private void HandleAdd()
        {
            // If the form state is in ADD mode
            if (_state == "ADD")
            {
                //  save appointment, set state, toggle form fields, exit
                AddAppointment(false);
                return;
            }

            // If the form state is not in ADD mode
            if (_state != "ADD")
            {
                // Prepare the form for data entry of a new record
                StartAdd();
                return;
            }
        }

        /* Method which prepares the intial form state */

        private void PrepareForm(string state, string addButtonText, string deleteButtonText, bool modifyEnabled)
        {
            // Set form state
            _state = state;

            // If the current state is ADD
            if (state == "ADD")
            {
                // Populate related controls
                CboUserId.SelectedValue = _userId;
                CboCustomerId.SelectedIndex = 0;
                TxtCreatedBy.Text = _currentUser;
            }

            // Populate last update date
            TxtLastUpdateBy.Text = _currentUser;

            // Toggle button text and usablity
            BtnAddAppointment.Text = addButtonText;
            BtnDeleteAppointment.Text = deleteButtonText;
            BtnModifyAppointment.Enabled = modifyEnabled;

            // Toggle data entry fields usability
            ToggleDataEntryFields(!modifyEnabled);
        }

        /* Method which initializes all data entry fields */

        private void InitDataEntryFields()
        {
            // Clear all form fields
            var now = DateTime.Now;
            TxtAppointmentId.Text = "";
            TxtTitle.Text = "";
            TxtDescription.Text = "";
            TxtLocation.Text = "";
            TxtContact.Text = "";
            TxtType.Text = "";
            TxtUrl.Text = "";
            DtpStart.Value = now;
            DtpEnd.Value = now;
            TxtTitle.Text = "";
            DtpCreateDate.Value = now;
            DtpLastUpdate.Value = now;
        }

        /* Method which toggles all form fields for data entry */

        private void ToggleDataEntryFields(bool value)
        {
            // Toggle fields used when moving in and out of MODIFY state
            CboCustomerId.Enabled = value;
            CboUserId.Enabled = value;
            TxtTitle.Enabled = value;
            TxtDescription.Enabled = value;
            TxtLocation.Enabled = value;
            TxtContact.Enabled = value;
            TxtType.Enabled = value;
            TxtUrl.Enabled = value;
            DtpStart.Enabled = value;
            DtpEnd.Enabled = value;
            TxtTitle.Enabled = value;
            BtnLaunch.Enabled = !value;
            BtnSearch.Enabled = !value;
            TxtSearch.Enabled = !value;
            DgvAppointments.Enabled = !value;
        }

        /* Method which checks to make sure date overlap conditions pass and
         * resets date label colors to black if so */

        private void ResetDateLabels()
        {
            // Set the date labels color to black
            LblStart.ForeColor = Color.Black;
            LblEnd.ForeColor = Color.Black;
        }

        /* Method which saves added data and resets the form to view mode */

        private bool AddAppointment(bool modify)
        {
            try
            {
                // Validate inputs / Decorate inputs with bad data
                ValidateInput();

                // Store all textbox data entry in a dictionary
                var formData = new Dictionary<string, string>
                {
                    { "AppointmentId", TxtAppointmentId.Text },
                    { "CustomerId",CboCustomerId.SelectedValue.ToString() },
                    { "UserId", CboUserId.SelectedValue.ToString() },
                    { "Title", TxtTitle.Text },
                    { "Description", TxtDescription.Text },
                    { "Location", TxtLocation.Text },
                    { "Contact", TxtContact.Text },
                    { "Type", TxtType.Text },
                    { "Url", TxtUrl.Text },
                    { "Start", DtpStart.Value.ToString()},
                    { "End", DtpEnd.Value.ToString()},
                    { "CreateDate", DtpCreateDate.Value.ToString() },
                    { "CreatedBy", TxtCreatedBy.Text },
                    { "LastUpdate", DtpLastUpdate.Value.ToString()},
                    { "LastUpdateBy", TxtLastUpdateBy.Text }
                };

                // Create a new appointment using the dictionary
                var appointment = new Appointment(formData);

                // If this is an update
                if (modify)
                {
                    // Update the appointment
                    _scheduler.UpdateAppointment(appointment, DgvAppointments);
                    SharedUtils.ModifyReminder(appointment, _timers, _reminders); // Modify the reminder if changed
                    //_reminders = _reminders.OrderBy(r => DateTime.Parse(r.Split('-')[0])).ToList(); // Sort reminders
                }
                else //If this is an add
                {
                    // Add the appointment
                    _scheduler.AddAppointment(appointment, DgvAppointments);
                    SharedUtils.AddReminder(appointment, _timers, _reminders); // Add the new reminder
                    PrepareForm("VIEW", "Add Appointment", "Delete Appointment", true); // Reset the form to VIEW mode

                    // Display the new record in the grid
                    SharedUtils.HandleSearch(DgvAppointments, _scheduler, appointment.AppointmentId.ToString(), true);
                }

                // Return true - success
                return true;
            }
            catch (InvalidOperationException ex)
            {
                // Display any invalidoperationexception error messages and return false - failure
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /* Method which populates form inputs with data when the gridview selection changes */

        private void PopulateInputs()
        {
            // Create an appointment record from the currently selected row
            if (DgvAppointments.CurrentRow == null)
            {
                return;
            }
            var appointment = (Appointment)DgvAppointments.CurrentRow.DataBoundItem;

            // Poplate the forms text boxes
            TxtAppointmentId.Text = appointment.AppointmentId.ToString();
            TxtTitle.Text = appointment.Title.ToString();
            CboUserId.SelectedValue = appointment.UserId;
            CboCustomerId.SelectedValue = appointment.CustomerId;
            TxtUserName.Text = SharedUtils.UpdateName(CboUserId, _scheduler.Users);
            TxtCustomerName.Text = SharedUtils.UpdateName(CboCustomerId, _scheduler.Customers);
            TxtDescription.Text = appointment.Description.ToString();
            TxtLocation.Text = appointment.Location.ToString();
            TxtContact.Text = appointment.Contact.ToString();
            TxtType.Text = appointment.Type.ToString();
            TxtUrl.Text = appointment.Url.ToString();
            DtpStart.Value = appointment.Start;
            DtpEnd.Value = appointment.End;
            DtpCreateDate.Value = appointment.CreateDate;
            TxtCreatedBy.Text = appointment.CreatedBy.ToString();
            DtpLastUpdate.Value = appointment.LastUpdate;
            TxtLastUpdateBy.Text = appointment.LastUpdateBy.ToString();
            _firstLoad = false; // Indicate that the first load has passed
        }

        /* Method which validates text inputs for invalid data and throws exceptions to indicate problems*/

        private void ValidateInput()
        {
            // Set the date labels color to red
            LblStart.ForeColor = Color.Red;
            LblEnd.ForeColor = Color.Red;

            // Handle missing title
            var message = "An appointment must have a title";
            var condition = TxtTitle.Text == "";
            SharedUtils.ThrowException(condition, message); // Handle no data

            // Handle missing description
            message = "An appointment must have a description.";
            condition = TxtDescription.Text == "";
            SharedUtils.ThrowException(condition, message); // Handle no data

            // Build variables for handling apppointment overlaps
            var startDate = DtpStart.Value;
            var endDate = DtpEnd.Value;
            var appointmentId = Convert.ToInt32(TxtAppointmentId.Text);

            var overlap = _scheduler.Appointments
                            .Where(a => a.AppointmentId != appointmentId)
                            .Where(a => startDate.Ticks > a.Start.Ticks)
                            .Where(a => startDate.Ticks < a.End.Ticks)
                            .Where(a => endDate.Ticks > a.Start.Ticks)
                            .Where(a => endDate.Ticks < a.End.Ticks)

                            //.Where(endDate <= a.End)
                            .ToList();

            if (overlap.Count > 0) // If there is appointment overlap
            {
                // Handle appointment overlap
                message = $"Your appointment time overlaps with appointment ID {overlap[0].AppointmentId}.";
                condition = overlap.Count != 0;
                SharedUtils.ThrowException(condition, message);
            }

            // Handle start date in past
            message = "Appointments cannot start in the past.";
            condition = DtpStart.Value < DateTime.Now;
            SharedUtils.ThrowException(condition, message);

            // Handle end date in the past
            message = "Appointments cannot end in the past.";
            condition = DtpEnd.Value < DateTime.Now;
            SharedUtils.ThrowException(condition, message);

            // Handle end before start
            message = "Appointments must start before they end.";
            condition = DtpStart.Value > DtpEnd.Value;
            SharedUtils.ThrowException(condition, message);

            // Setup variables needed for date/time comparison validations
            var openSpan = new TimeSpan(8, 0, 0);
            var closeSpan = new TimeSpan(17, 0, 0);
            var businessOpen = Convert.ToDateTime(SharedUtils.FormatDate(new DateTime(openSpan.Ticks).ToString()));
            var businessClose = Convert.ToDateTime(SharedUtils.FormatDate(new DateTime(closeSpan.Ticks).ToString()));
            var startTicks = new DateTime(DtpStart.Value.TimeOfDay.Ticks).ToString();
            var endTicks = new DateTime(DtpEnd.Value.TimeOfDay.Ticks).ToString();
            var startTime = Convert.ToDateTime(SharedUtils.FormatDate(startTicks).ToString());
            var endTime = Convert.ToDateTime(SharedUtils.FormatDate(endTicks).ToString());
            var startDay = DtpStart.Value.DayOfWeek;
            var endDay = DtpEnd.Value.DayOfWeek;

            // Handle appointment start on a weekday
            message = "Appointments must start on a weekday.";
            condition = (startDay == DayOfWeek.Saturday) || (startDay == DayOfWeek.Sunday);
            SharedUtils.ThrowException(condition, message);

            // Handle appointment end on a weekday
            message = "Appointments must end on a weekday.";
            condition = (endDay == DayOfWeek.Saturday) || (endDay == DayOfWeek.Sunday);
            SharedUtils.ThrowException(condition, message);

            // Handle start time outside of business hours
            message = "Appointment start date must be between the business hours of 8am and 5pm in your local timezone.";
            condition = (startTime < businessOpen) || (startTime > businessClose);
            SharedUtils.ThrowException(condition, message);

            // Handle end time outside of business hours
            message = "Appointment end date must be between the business hours of 8am and 5pm in your local timezone.";
            condition = (endTime < businessOpen) || (endTime > businessClose);
            SharedUtils.ThrowException(condition, message);

            // Set the date labels color to red
            LblStart.ForeColor = Color.Black;
            LblEnd.ForeColor = Color.Black;
        }

        /* Method which populates databound controls when the form is initialized */

        private void PopulateDataBoundControls(bool? fromCalendar = false)
        {
            // Init datource
            DgvAppointments.DataSource = _scheduler.Appointments;

            // If the page is being launched from the calendar
            if (fromCalendar == true)
            {
                SharedUtils.HandleSearch(DgvAppointments, _scheduler, _appoinmentId.ToString(), true);
            }

            // Hide unnecessary columns
            var hiddenColumns = new List<int> { 0, 1, 2, 5, 6, 7, 8 };
            SharedUtils.HideColumns(DgvAppointments, hiddenColumns);

            // Init dropdown data
            // *Valuemember needs to be set prior to the next line or there is failure
            CboCustomerId.ValueMember = "CustomerId";
            CboCustomerId.DataSource = Repository.PopulateDefaults(new Customer());
            CboCustomerId.DisplayMember = "CustomerId";

            // Init dropdown data
            // *Valuemember needs to be set prior to the next line or there is failure
            CboUserId.ValueMember = "UserId";
            CboUserId.DataSource = _scheduler.Users;
            CboUserId.DisplayMember = "UserId";
        }

        /* Method which changes the form state to modify mode to allow data entry */

        private void StartModify()
        {
            // Toggle the form state to MODIFY MODE
            _state = "MODIFY";

            // Toggle necessary form changes
            BtnModifyAppointment.Text = "Save Modifications";
            BtnDeleteAppointment.Text = "Cancel Modifications";
            BtnAddAppointment.Enabled = false;
            DtpLastUpdate.Value = DateTime.Now;
            TxtLastUpdateBy.Text = _currentUser;
            ToggleDataEntryFields(true);

            // Exit
            return;
        }

        // Method which ends modify state and puts the form back in VIEW state */
        private void ModifyAppointment()
        {
            // Save the appointment to the DB
            if (!AddAppointment(true))
            {
                return;
            }

            // Toggle the form state to VIEW mode
            _state = "VIEW";

            // Toggle necessary form changes
            BtnAddAppointment.Enabled = true;
            BtnModifyAppointment.Text = "Modify Appointment";
            ToggleDataEntryFields(false);

            // Exit
            return;
        }

        /* Method which sets the form state to add and prepares it for data entry */

        private void StartAdd()
        {
            // Set state, save appointment, toggle form fields
            PrepareForm("ADD", "Save New Appointment", "Cancel New Appointment", false);

            // Clear data entry fields
            InitDataEntryFields();

            //Get the next recordID in sequence and set the default appointmentId using it
            var nextId = SharedUtils.GetNextId(DgvAppointments);
            TxtAppointmentId.Text = nextId.ToString();

            // Exit
            return;
        }

        /* Method which deletes a record */

        private void FinishDelete()
        {
            // Create a part using the selected grid item
            var appointment = (Appointment)DgvAppointments.CurrentRow.DataBoundItem;
            var appointmentId = appointment.AppointmentId;

            // Open a yes/no dialog to confirm delete
            var message = $"Are you sure you wish to delete Appointment Id {appointmentId}?";
            var title = $"Delete Appointment Id {appointmentId}?";
            var response = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
            {
                // Delete if confirmed
                _scheduler.DeleteAppointment(appointment, DgvAppointments);
                SharedUtils.DeleteReminder(appointment, _timers, _reminders);
                // Select the first record in the grid
                DgvAppointments.Rows[0].Selected = true;
                DgvAppointments.CurrentCell = DgvAppointments.Rows[0].Cells[3];
            }
            else
            {
                // Return if not confirmed
                return;
            }
            return;
        }

        /* Method which places saves modification and places the form back into VIEW state */

        private void CancelModify()
        {
            // Set form state to VIEW mode
            _state = "VIEW";

            // Toggle form fields
            BtnAddAppointment.Text = "Add Appointment";
            BtnModifyAppointment.Text = "Modify Appointment";
            BtnDeleteAppointment.Text = "Delete Appointment";
            BtnModifyAppointment.Enabled = true;
            BtnAddAppointment.Enabled = true;
            BtnDeleteAppointment.Enabled = true;
            ToggleDataEntryFields(false);

            // Reload form
            PopulateInputs();
            return;
        }

        /* Method which cancels an add and places the form back into VIEW state */

        private void CancelAdd()
        {
            //  save appointment, set state, toggle form fields, reload the form
            PrepareForm("VIEW", "Add Appointment", "Delete Appointment", true);
            PopulateInputs();
            return;
        }

        private void LaunchCustomers()
        {
            // If the form state is in ADD mode
            if (_state == "ADD")
            {
                // Open a yes/no dialog to confirm delete
                var response = MessageBox.Show("Your new record will be cancelled if you open the customers screen. Do you wish to continue?", "Are you sure?", MessageBoxButtons.YesNo);

                if (response == DialogResult.Yes)
                {
                    SharedUtils.OpenForm(this, new FrmCustomers(_scheduler, _userId, _reminders, _timer));
                }
            }

            // If the form state is in MODIFY mode
            if (_state == "MODIFY")
            {
                var response = MessageBox.Show("Your record changes will be cancelled if you open the customers screen. Do you wish to continue?", "Are you sure?", MessageBoxButtons.YesNo);

                if (response == DialogResult.Yes)
                {
                    // Hide the current form, open the form that has been selected from the menu
                    SharedUtils.OpenForm(this, new FrmCustomers(_scheduler, _userId, _reminders, _timer));
                }
            }

            // If the form state is in VIEW mode
            if (_state == "VIEW")
            {
                SharedUtils.OpenForm(this, new FrmCustomers(_scheduler, _userId, _reminders, _timer));
            }
        }

        private void MnuHelp_Click(object sender, EventArgs e)
        {
            var form = new FrmHelp(_reminders, _scheduler, _timer);
            form.ShowDialog();
        }

        private void FrmAppointments_MouseMove(object sender, MouseEventArgs e)
        {
            SharedUtils.RestartTimer(_timer);
        }
    }
}