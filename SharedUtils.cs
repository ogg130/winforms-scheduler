using RobertOgden.Data.Models;
using RobertOgden.Data.Models.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RobertOgden
{
    public static class SharedUtils
    {
        /* Method which adds a reminder */

        public static void AddReminder(Appointment appointment, Timer timer, List<string> reminders)
        {
            var start = appointment.Start;
            var minus15 = start.AddMinutes(-15);
            // If this reminder is before the current time
            if (minus15 < DateTime.Now)
            {
                // Exit, no reminder is created
                return;
            }

            // Setup reminder text
            string reminderText = SetReminderText(appointment);

            // Add the new reminder and sort the reminders object
            reminders.Insert(0, reminderText);
            _ = reminders.OrderBy(r => DateTime.Parse(r.Split('-')[0])).ToList();
        }

        /* Method which sets reminder text */

        private static string SetReminderText(Appointment appointment)
        {
            // Setup reused variables
            var id = appointment.AppointmentId;
            var title = appointment.Title;
            var description = appointment.Description;
            var start = appointment.Start.AddMinutes(-15).ToString();
            var customerId = appointment.CustomerId;
            var reminderText = $"{start}-{title}-{description}-{id}-{customerId}";
            return reminderText;
        }

        /* Method which is used to display reminders if they occur during the timer tick */

        public static void ReminderCheck(List<string> reminders, Scheduler scheduler, Timer timer)
        {
            // Split the reminder on -
            var reminder = reminders[0].Split('-');
            var start = reminder[0];
            var title = reminder[1];
            var description = reminder[2];
            var customerId = reminder[4];
            var customerName = scheduler.Customers.FirstOrDefault(r => r.CustomerId.ToString() == customerId).CustomerName.ToString();

            // If the start date extracted from the reminder is the same time as now
            if (start == DateTime.Now.ToString())
            {
                // Remove the reminder, display message
                reminders.RemoveAt(0);
                var message = $"The following meeting is occuring in 15 minutes:\n\nTitle: {title} \nDescription: {description} \nCustomer: {customerName}";
                timer.Stop();
                MessageBox.Show(message);
            }
        }

        /* Method which modifies exisiting reminder text */

        public static void ModifyReminder(Appointment appointment, Timer timer, List<string> reminders)
        {
            // Setup reminder text and necessary variables
            string reminderText = SetReminderText(appointment);
            var id = appointment.AppointmentId;
            var start = appointment.Start.AddMinutes(-15).ToString();

            // If the timer is not enabled because there are no reminders
            if (reminders.Count == 0)
            {
                // Add the reminder and start the timer
                reminders.Add(reminderText);
            }
            else // If the timer is enabled because there are reminders
            {
                //iterate over each reminder
                for (var i = 0; i < reminders.Count; ++i)
                {
                    var reminderId = reminders[i].Split('-')[3]; // Extract appointment ID from reminder
                    var reminderStart = reminders[i].Split('-')[0]; //Extract start date from reminder

                    // If a reminder has a valid start date change and already exists
                    if ((reminderId == id.ToString()) && (reminderStart != start))
                    {
                        // If this reminder is before the current time
                        if (appointment.Start.AddMinutes(-15) < DateTime.Now)
                        {
                            // Exit, no reminder is created
                            return;
                        }
                        // Update the reminder with the new date
                        reminders[i] = reminderText;
                        return;
                    }
                }

                // If you have returned, no reminder needed to be created
                // or the reminder that existed was updated. Now, the only
                // remaining option is that a past record that didnt alread
                // have a reminder is being modified. If so, the reminder
                // needs to be added:

                reminders.Insert(0, reminderText);
                _ = reminders.OrderBy(r => DateTime.Parse(r.Split('-')[0])).ToList();
            }
        }

        /* Method which deletes a reminder */

        public static void DeleteReminder(Appointment appointment, Timer timer, List<string> reminders)
        {
            var id = appointment.AppointmentId;

            // If the timer is not enabled because there are no reminders
            if (reminders.Count == 0)
            {
                // There is nothing to be doing, exit
                return;
            }
            else // If the timer is enabled because there are reminders
            {
                //iterate over each reminder
                for (var i = 0; i < reminders.Count; ++i)
                {
                    var reminderId = reminders[i].Split('-')[3]; // Extract appointment ID from reminder

                    // If a reminder matching the id is found
                    if (reminderId == id.ToString())
                    {
                        // Update the reminder with the new date
                        reminders.RemoveAt(i);
                    }
                }
            }
        }

        /* Method which closes the existing form (1st param) and
         * opens a new form (2nd param) */

        public static void OpenForm(Form source, Form target)
        {
            // Hide current form, show new form
            source.Hide();
            target.ShowDialog();
            source.Close();
        }

        /* Method which recieves a datagridview object and returns the next ID in
 * sequence to use with an add*/

        public static int GetNextId(DataGridView grid)
        {
            var rows = grid.Rows; // Rows
            var topRow = rows[rows.Count - 1].Cells[0].Value; // Top ID value
            var converted = Convert.ToInt32(topRow) + 1; // Add one
            return converted; // Return it
        }

        /* Method which recieves a datagridview object and returns a list of
         * ids that the datagridview object contains */

        public static List<int> GetIds(DataGridView grid)
        {
            // Create a list to store records in so we can use Max to grab the highest value of the ID column
            List<int> ids = new List<int>();

            // Iterate over datagridview_parts
            foreach (DataGridViewRow row in grid.Rows)
            {
                // If the currently iterated over row and its value are both not null
                if (row != null && row.Cells[0].Value != null)
                {
                    //Convert the value of the cell into a string, and then into an int to add it to the list
                    var id = Convert.ToInt32(row.Cells[0].Value.ToString());
                    ids.Add(id);
                }
            }

            // Return the list of ids
            return ids;
        }

        /* Method which iterates over each cell in a datagridview and returns
        * the partID where a match occurs */

        public static int GetId(string userInput, DataGridView grid)
        {
            // If no search input has been entered by the user but the button was clicked...
            if (userInput == "")
            {
                MessageBox.Show("Please enter search text.");
                return -1;
            }

            // Iterate over the datagridviews collection of rows...
            foreach (DataGridViewRow row in grid.Rows)
            {
                // If no match has been made yet, iterate over the collection of cells inside of the collection of rows
                for (var i = 0; i < row.Cells.Count; ++i)
                {
                    // If the current cell that is being iterated over contains the users search input
                    if (row.Cells[i].Value.ToString().Contains(userInput))
                    {
                        var id = Convert.ToInt32(row.Cells[0].Value); //Set the row id for the match
                        return id; // Return row id
                    }
                }
            }
            return -1; // Stop code execution
        }

        public static string FormatDate(string date)
        {
            // Make sure the input string is a valid date, format it as a real date if so
            DateTime.TryParse(date, out DateTime formattedDate);

            // Define the UTC offset for the date
            var offSet = TimeSpan.Zero;
            var utcTime = new DateTimeOffset(formattedDate, offSet);

            // Set users timezone from windows settings
            var timeZone = TimeZoneInfo.Local;
            var userTimeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZone.Id);

            // Convert UTC offset time to the users local time
            var userOffset = TimeZoneInfo.ConvertTime(utcTime, userTimeZone);

            // Return the offset as a formatted date string
            return userOffset.ToString("MM/dd/yyyy H:mm:ss tt");
        }

        public static string FormatSqlDateTime(DateTime inDate)
        {
            var outDate = TimeZoneInfo.ConvertTimeToUtc(inDate);
            return outDate.ToString("yyyy-MM-dd H:mm:ss");
        }

        /* Method which, given a textbox as input, changes the background
        * color of the textbox, and removes all tooltips if valid */

        public static void Valid(Label label, ToolTip toolTip)
        {
            label.ForeColor = Color.Black;
        }

        /* Method which, given a textbox as label and a message to
         * display, changes the background color of the textbox,
         * and displays a tooltip using the message */

        public static void NotValid(Label label, string message, ToolTip toolTip)
        {
            toolTip.Hide(label);
            label.ForeColor = Color.Red;
            toolTip.Show(message, label, 3000);
        }

        /* Method which writes to a file given the filename and a string to write */

        public static void WriteToLog(string fileName, string message)
        {
            using (var fileStream = new FileStream(fileName, FileMode.Append))
            using (var stream = new StreamWriter(fileStream))
            {
                stream.Write(message);
            }
        }

        /* Method which hides unnecessary gridview columns given a datagridview and
         * a list of column indexes to hide*/

        public static void HideColumns(DataGridView grid, List<int> hiddenColumns)
        {
            // Hide the 0th-3rd column from the datagridview
            foreach (var column in hiddenColumns)
            {
                // Hide the column
                grid.Columns[column].Visible = false;
            }
        }

        // Method which throws an exception given a boolean conditon and an exception message
        public static void ThrowException(bool condition, string message)
        {
            // If condition is true
            if (condition)
            {
                // Throw IO exception
                throw new InvalidOperationException(message);
            }
        }

        ///* Method which, given a textbox containing data and a tooltip control,
        //* valicontrols the texbox, changes its color and shows a tooltip describing
        //* the issue*/

        public static void ValidateText(TextBox input, ToolTip toolTip, Label label)
        {
            if (input.Text == "")
            {
                var message = $"Value for {label.Text} must be filled out";
                NotValid(label, message, toolTip);
                return;
            }
            Valid(label, toolTip);
        }

        ///* Method which, given a combobox with a selected item and a tooltip control,
        //* valicontrols the texbox, changes its color and shows a tooltip describing
        //* the issue */

        public static void ValidateCbo(ComboBox input, ToolTip toolTip, Label label)
        {
            if (input.SelectedIndex == -1)
            {
                var message = $"Value for {label.Text} must be selected";
                NotValid(label, message, toolTip);
                return;
            }
            Valid(label, toolTip);
        }

        /* Method which, given a datetimepicker containing data and a tooltip control,
        * validates the texbox, changes its color and shows a tooltip describing
        * the issue*/

        public static void ValidateInputs(bool condition, Label label, string message, ToolTip toolTip)
        {
            if (condition)
            {
                NotValid(label, message, toolTip);
                return;
            }

            Valid(label, toolTip);
        }

        /* This function highlights a row in a gridbox, given a gridbox and
        * textbox where a search string is entered by the user */

        public static void HandleSearch(DataGridView grid, Scheduler scheduler, string searchText, bool? bypassTextSearch = false)
        {
            // Setup necessary variables
            var rows = grid.Rows;
            var id = GetId(searchText, grid);
            var searchType = grid.GetType().GetProperty("Name").GetValue(grid, null).ToString();
            int recordId = 0;
            TimeStampBase record;

            //If the 4th param is true
            if (bypassTextSearch == true)
            {
                // Set the id using the third param instead (this is an automated and not a user search)
                id = Convert.ToInt32(searchText);
            }

            // If this is an addresses gridview
            if (searchType.Contains("Address"))
            {
                // Setup the record and recordid to work with
                record = scheduler.LookupAddress(id);
                var actualRecord = (Address)record;
                recordId = actualRecord.AddressId;
            }
            // If this is a customer gridview
            if (searchType.Contains("Customer"))
            {
                // Setup the record and recordid to work with
                record = scheduler.LookupCustomer(id);
                Customer actualRecord = (Customer)record;
                recordId = actualRecord.CustomerId;
            }
            // If this is an appointment or calendar gridview
            if (searchType.Contains("Appointment") || (searchType.Contains("Calendar")))
            {
                // Setup the record and recordid to work with
                record = scheduler.LookupAppointment(id);
                Appointment actualRecord = (Appointment)record;
                recordId = actualRecord.AppointmentId;
            }

            // If the record id is not a valid recordid
            if (recordId < 1)
            {
                return; // Exit
            }

            // Iterate over all rows
            for (var i = 0; i < rows.Count; ++i)
            {
                // if the record Id we've calculated matches the current iterations recordid column
                if (Convert.ToInt32(rows[i].Cells[0].Value) == recordId)
                {
                    rows[i].Selected = true; // Select the matched row
                    grid.CurrentCell = rows[i].Cells[3]; // Select the matched cell
                    break;
                }
            }
        }

        /* Method which, given a combobox, a texbox and a bindingList of T, updates a the texbox
         * based off of the combobox value */

        public static string UpdateName<T>(Control control, BindingList<T> list)
        {
            // Setup variables
            var comboBox = new ComboBox();
            var textBox = new TextBox();
            var selectedValue = "";
            var selectedUser = 0;
            var incomingClassName = list[0].GetType().Name.ToString().ToLower();
            var name = "";

            // If the control is a combobox
            if (control.Name.Contains("Cbo"))
            {
                comboBox = (ComboBox)control;
                selectedValue = comboBox.SelectedValue.ToString();
                selectedUser = Convert.ToInt32(selectedValue);
            }

            // If the control is a textbox
            if (control.Name.Contains("Txt"))
            {
                textBox = (TextBox)control;
                selectedValue = textBox.Text;
                selectedUser = Convert.ToInt32(selectedValue);
            }
            // Setup user informaition if this is for a user
            if (incomingClassName.Contains("user"))
            {
                var firstRecord =
                    list.FirstOrDefault(u => u.GetType().GetProperty("UserId").GetValue(u, null).ToString() == selectedUser.ToString());

                name =
                    firstRecord.GetType().GetProperty("UserName").GetValue(firstRecord, null).ToString();
            }

            //Setuo customer information if this is for a customer
            if (incomingClassName.Contains("customer"))
            {
                var firstRecord =
                    list.FirstOrDefault(u => u.GetType().GetProperty("CustomerId").GetValue(u, null).ToString() == selectedUser.ToString());

                name =
                    firstRecord.GetType().GetProperty("CustomerName").GetValue(firstRecord, null).ToString();
            }

            return name;
        }

        /* Method which populates the scheduler object when the form is initialized */

        public static void PopulateScheduler(Scheduler scheduler)
        {
            // Query the appointment table, return results into scheduler.appointments
            scheduler.Appointments = Repository.PopulateAppointments();

            // Populate defaults
            scheduler.Users = Repository.PopulateDefaults(new User());
            FormatDates(scheduler.Users); // Format dates to local timezone

            // Populate defaults
            scheduler.Customers = Repository.PopulateDefaults(new Customer());
            FormatDates(scheduler.Customers); // Format dates to local timezone

            // Populate defaults
            scheduler.Countries = Repository.PopulateDefaults(new Country());
            FormatDates(scheduler.Countries); // Format dates to local timezone

            // Populate defaults
            scheduler.Addresses = Repository.PopulateDefaults(new Address());
            FormatDates(scheduler.Addresses); // Format dates to local timezone

            // Populate defaults
            scheduler.Cities = Repository.PopulateDefaults(new City());
            FormatDates(scheduler.Cities); // Format dates to local timezone
        }

        /* Method which an appointmnet, city, country or cusomter can be passed into to have its dates converted from
         * UTC to the users local timezone */

        private static void FormatDates<T>(BindingList<T> records)
        {
            foreach (var record in records)
            {
                // Using reflection, get the properties and values we are working with for createdate and lastupdate
                var createDate = record.GetType().GetProperty("CreateDate");
                var createDateValue = Convert.ToDateTime(FormatDate(createDate.GetValue(record, null).ToString()));
                var updateDate = record.GetType().GetProperty("CreateDate");
                var updateDateValue = Convert.ToDateTime(FormatDate(updateDate.GetValue(record, null).ToString()));

                // Using reflection, update the createDate and lastUpdateDate
                createDate.SetValue(record, createDateValue);
                updateDate.SetValue(record, updateDateValue);
            }
        }

        /* Method which shows the current weeks worth of appointmnets for the user
        * and updates the date time picker for choice specific options */

        public static List<Appointment> ViewByWeek(Scheduler scheduler, int userId, DateTimePicker picker)
        {
            // Get all of the current users appointments, ordered by date ascending
            var allAppointments = scheduler.Appointments
                .Where(r => r.UserId == userId)
                .OrderBy(r => r.Start)
                .ToList();

            // Parse out the appointments for the week
            var selectedAppointments = SharedUtils.DefineWeekLogic(allAppointments, picker);
            return selectedAppointments;
        }

        /* Method which shows the current months worth of appointmnets for the user
         * and updates the date time picker for choice specific options */

        public static List<Appointment> ViewByMonth(Scheduler scheduler, int userId, DateTimePicker picker, bool? init = false)
        {
            // Get all of the current users appointments, ordered by date ascending
            var allAppointments = scheduler.Appointments
                .Where(r => r.UserId == userId)
                .OrderBy(r => r.Start)
                .ToList();

            // Set the month/year to use for init
            var month = allAppointments[0].Start.Month;
            var year = allAppointments[0].Start.Year;

            if (init == false)
            {
                // Use dropdown if this isnt being ran during init
                month = picker.Value.Month;
                year = picker.Value.Year;
            }

            // Parse out the months worth of appointments
            var selectedAppointments = allAppointments
                .Where(r => r.Start.Month == month && r.Start.Year == year)
                .ToList();

            return selectedAppointments;
        }

        /* Method which defines logic to search by week */

        private static List<Appointment> DefineWeekLogic(List<Appointment> allAppointments, DateTimePicker date)
        {
            // Build startOfWeek, starting with the startdate
            var startOfWeek = date.Value;

            // Get the delta between the day of the week of the appointment and monday
            int delta = DayOfWeek.Monday - startOfWeek.DayOfWeek;

            // Add delta to start of week to define the start day
            startOfWeek = startOfWeek.AddDays(delta);

            // Add 7 days to define the end date
            var endOfWeek = startOfWeek.AddDays(7);

            // Return the appointment list
            var selectedAppointments = allAppointments
                .Where(r => r.Start >= startOfWeek && r.Start < endOfWeek)
                .ToList();

            return selectedAppointments;
        }

        /* Method which runs a report showing the number of appointment types per month */

        public static void RunOption1Report(DataGridView grid, Label label)
        {
            // Get the data for the option 1 report
            var report = new Option1();
            var reportList = report.ToBindingList<Option1>(grid); //this sets a datasource

            // Update form controls
            label.Text = "Currently displaying number of appointment types by month";
        }

        /* Method which runs a report showing the schedule of all consultants */

        public static void RunOption2Report(DataGridView grid, Label label)
        {
            // Get the data for the option 2 report
            var report = new Option2();
            var reportList = report.ToBindingList<Option2>(grid); //this sets a datasource

            // Format dates for local time
            foreach (var record in reportList)
            {
                record.Start = Convert.ToDateTime(FormatDate(record.Start.ToString()));
                record.End = Convert.ToDateTime(FormatDate(record.End.ToString()));
            }

            // Update form controls
            grid.Columns["UserName"].DisplayIndex = 0;
            label.Text = "Currently displaying the schedules for all consultants";
        }

        /* Method which runs a report that shows the appointments for the city with
         * the most appointments */

        public static void RunOption3Report(DataGridView grid, Label label)
        {
            // Get the data for the option 3 report
            var report = new Option3();
            var reportList = report.ToBindingList<Option3>(grid);

            // Format dates for local time
            foreach (var record in reportList)
            {
                record.Start = Convert.ToDateTime(FormatDate(record.Start.ToString()));
                record.End = Convert.ToDateTime(FormatDate(record.End.ToString()));
            }

            // Update form controls
            var cityName = grid.Rows[0].Cells[0].Value;
            grid.Columns["City"].DisplayIndex = 0;
            label.Text = $"Currently displaying all appointments for {cityName}";
        }

        /* Method which restarts a timer if its stopped */

        public static void RestartTimer(Timer timer)
        {
            if (timer == null)
            {
                return;
            }
            if (timer.Enabled)
            {
                return;
            }
            timer.Start();
        }
    }
}