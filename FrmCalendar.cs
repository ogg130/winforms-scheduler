using RobertOgden.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace RobertOgden
{
    public partial class FrmCalendar : Form
    {
        private Scheduler _scheduler; // Scheduler data
        private List<string> _reminders; // Reminder data
        private int _userId; // The currently logged in users user ID
        private Timer _timer; // Reminder timer

        public FrmCalendar()
        {
            InitializeComponent();
        }

        public FrmCalendar(Scheduler scheduler, int userId)
        {
            InitializeComponent();

            // Set up gloablly used objects that are passed into the form
            _userId = userId;
            _scheduler = scheduler;

            // Define timer
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Enabled = true;
            _timer.Tick += new System.EventHandler(OnTimerEvent);

            SharedUtils.PopulateScheduler(_scheduler); // Popluate the scheduler object

            PopulateReminders(); // Populate the reminders object

            PopulateDataBoundControls(); //Populate data bound controls
        }

        public FrmCalendar(Scheduler scheduler, int userId, List<string> reminders, Timer timer)
        {
            //Set up gloablly used objects that are passed into the form
            _userId = userId;
            _scheduler = scheduler;
            _reminders = reminders;
            _timer = timer;

            InitializeComponent();
            PopulateDataBoundControls(); // Populate grid and comboboxes
        }

        private void FrmCalendar_Load(object sender, EventArgs e)
        {
            if (DgvCalendar.Columns.Count > 0)
            {
                // Hide unnecessary columns
                var hiddenColumns = new List<int> { 0, 1, 2, 11, 12, 13, 14 };
                SharedUtils.HideColumns(DgvCalendar, hiddenColumns);
            }
        }

        private void MnuHelp_Click(object sender, EventArgs e)
        {
            var form = new FrmHelp(_reminders, _scheduler, _timer);
            form.ShowDialog();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Handle Search button click
            SharedUtils.HandleSearch(DgvCalendar, _scheduler, TxtSearch.Text);
        }

        private void DgvCalendar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Create a part using the selected grid item
            var appointmentId = Convert.ToInt32(DgvCalendar.CurrentRow.Cells[0].Value.ToString());
            SharedUtils.OpenForm(this, new FrmAppointments(_scheduler, _userId, _reminders, appointmentId, _timer));
        }

        private void RdoMonth_CheckedChanged(object sender, EventArgs e)
        {
            // Update the form to view by month
            var selectedAppointments = SharedUtils.ViewByMonth(_scheduler, _userId, DtpDate);

            // Update Form controls
            UpdateFormControls(selectedAppointments, "MMMM");
        }

        private void RdoWeek_CheckedChanged(object sender, EventArgs e)
        {
            // Update the form to view by week
            var selectedAppointments = SharedUtils.ViewByWeek(_scheduler, _userId, DtpDate);

            // Update form controls
            UpdateFormControls(selectedAppointments, "ddddd, MMMM dd, yyyy hh: mm:ss tt");
        }

        private void MnuAddresses_Click(object sender, EventArgs e)
        {
            // Hide current form, show new form
            SharedUtils.OpenForm(this, new FrmAddresses(_scheduler, _userId, _reminders, _timer));
        }

        private void DtpDate_ValueChanged(object sender, EventArgs e)
        {
            // Update the grid for the selected option
            SetView();
        }

        private void MnuAppointments_Click(object sender, EventArgs e)
        {
            // Hide current form, show new form
            SharedUtils.OpenForm(this, new FrmAppointments(_scheduler, _userId, _reminders, _timer));
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

        private void MnuExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

        /* Method which populates databound controls when the form is initialized */

        private void PopulateDataBoundControls()
        {
            // Update the form to view by month
            var selectedAppointments = SharedUtils.ViewByMonth(_scheduler, _userId, DtpDate, true);

            // Update Form controls
            UpdateFormControls(selectedAppointments, "MMMM");
        }

        /* Method which creates a list of reminders based off of the users appointments */

        private void PopulateReminders()
        {
            var reminders = new List<string>();
            var nowMinusFifteen = DateTime.Now.AddMinutes(15);
            var usersAppointments = _scheduler.Appointments
                .Where(a => a.UserId == _userId && a.Start > nowMinusFifteen);

            // Iterate over all appointments, and create a list of reminder times
            foreach (var appointment in usersAppointments)
            {
                // Define reminder text
                var reminderText = appointment.Start.AddMinutes(-15).ToString() + "-" + appointment.Title + "-" +
                    "" + appointment.Description + "-" + appointment.AppointmentId + "-" + appointment.CustomerId;

                // Add Reminder
                reminders.Add(reminderText);
            }

            //Sorte reminders
            reminders = reminders.OrderBy(c => DateTime.Parse(c.Split('-')[0])).ToList();

            _reminders = reminders;
        }

        /* Method which sets the screen to be viewed by month or week when option buttons are changed */

        private void SetView()
        {
            var selectedAppointments = new List<Appointment>();

            // If view by month is selected
            if (RdoMonth.Checked)
            {
                // Update the form to view by month
                selectedAppointments = SharedUtils.ViewByMonth(_scheduler, _userId, DtpDate);

                // Update Form controls
                UpdateFormControls(selectedAppointments, "MMMM");
            }
            else // If view by month is not selected
            {
                // Update the form to view by week
                selectedAppointments = SharedUtils.ViewByWeek(_scheduler, _userId, DtpDate);

                // Update form controls
                UpdateFormControls(selectedAppointments, "ddddd, MMMM dd, yyyy hh: mm:ss tt");
            }
        }

        /* Method which updates form controls when toggling between month and week view */

        private void UpdateFormControls(List<Appointment> selectedAppointments, string formatText)
        {
            // If the list has no values
            if (selectedAppointments.Count == 0)
            {
                // Display no records found message
                LblInstructions.Text = "No appointments have been found for the selected date.";
                DgvCalendar.DataSource = new BindingList<Appointment>();
            }
            else // If it has values
            {
                // Update the grid and set the date time picker value
                DgvCalendar.DataSource = new BindingList<Appointment>(selectedAppointments);
                DtpDate.Value = selectedAppointments[0].Start;
                LblInstructions.Text = "Double click on any row to open the associated appointment.";
            }

            //Format datetimepicker
            DtpDate.CustomFormat = formatText;
        }

        private void FrmCalendar_MouseMove(object sender, MouseEventArgs e)
        {
            _timers.Start();
        }

        public void OnTimerEvent(object source, EventArgs e)
        {
            SharedUtils.ReminderCheck(_reminders, _scheduler, _timer);
        }
    }
}