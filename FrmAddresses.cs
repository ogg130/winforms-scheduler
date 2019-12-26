using RobertOgden.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RobertOgden
{
    public partial class FrmAddresses : Form
    {
        private Scheduler _scheduler; // Scheduler data
        private List<string> _reminders; // Reminder data
        private readonly int _userId; // The currently logged in users user ID
        private readonly string _currentUser; // The currently logged in users name
        private string _state = "VIEW"; // The state of the form

        public FrmAddresses()
        {
            InitializeComponent();
        }

        public FrmAddresses(Scheduler scheduler, int userId, List<string> reminders)
        {
            // Set up gloablly used objects that are passed into the form
            _userId = userId;
            _scheduler = scheduler;
            _reminders = reminders;
            _currentUser = _scheduler.Users.FirstOrDefault(r => r.UserId == _userId).UserName;

            InitializeComponent();

            // Populate grid and comboboxes
            PopulateDataBoundControls();
        }

        /* Method which populates databound controls when the form is initialized */

        private void PopulateDataBoundControls()
        {
            // Init datource
            DgvAddresses.DataSource = _scheduler.Addresses;

            // Init dropdown data
            // *Valuemember needs to be set prior to the next line or there is failure
            CboCityId.ValueMember = "CityId";
            CboCityId.DataSource = _scheduler.Cities;
            CboCityId.DisplayMember = "CityId";
        }

        private void MnuAppointments_Click(object sender, EventArgs e)
        {
            // Hide current form, show new form
            SharedUtils.OpenForm(this, new FrmAppointments(_scheduler, _userId, _reminders));
        }

        private void MnuCalendar_Click(object sender, EventArgs e)
        {
            // Hide current form, show new form
            SharedUtils.OpenForm(this, new FrmCalendar(_scheduler, _userId, _reminders));
        }

        private void MnuCustomers_Click(object sender, EventArgs e)
        {
            // Hide current form, show new form
            SharedUtils.OpenForm(this, new FrmCustomers(_scheduler, _userId, _reminders));
        }

        private void MnuReports_Click(object sender, EventArgs e)
        {
            // Hide current form, show new form
            SharedUtils.OpenForm(this, new FrmReports(_scheduler, _userId, _reminders));
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Handle Search button click
            SharedUtils.HandleSearch(DgvAddresses, _scheduler, TxtSearch.Text);
        }

        private void CboCityId_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Throw tooltip if improper entry has occured
            SharedUtils.ValidateCbo(CboCityId, ToolTip, LblCityId);

            // Set the city for the currently selected cityId
            var cityId = Convert.ToInt32(CboCityId.SelectedValue);
            var city = _scheduler.Cities.FirstOrDefault(r => r.CityId == cityId).CityName;
            TxtCity.Text = city; //Set the city
        }

        private void BtnAddAddress_Click(object sender, EventArgs e)
        {
            HandleAdd(); // Handle Add button click
        }

        private void BtnDeleteAddress_Click(object sender, EventArgs e)
        {
            HandleDelete(); // Handle Delete button click
        }

        private void BtnModifyAddress_Click(object sender, EventArgs e)
        {
            HandleModify(); // Handle modify button click
        }

        private void DgvAddresses_SelectionChanged(object sender, EventArgs e)
        {
            SelectionChange(); // Process events that occur when a selection change occurs
        }

        private void TxtAddress1_TextChanged(object sender, EventArgs e)
        {
            // Throw tooltip messages if any invalid conditions occur
            var message = "Addresses must have a street address.";
            var condition = TxtAddress1.Text == "";
            SharedUtils.ValidateInputs(condition, LblAddress1, message, ToolTip);
        }

        private void TxtPostalCode_TextChanged(object sender, EventArgs e)
        {
            // Throw tooltip messages if any invalid conditions occur
            var message = "Addresses must have a postal code.";
            var condition = TxtPostalCode.Text == "";
            SharedUtils.ValidateInputs(condition, LblPostalCode, message, ToolTip);
        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {
            // Throw tooltip messages if any invalid conditions occur
            var message = "Addresses must have a phone number.";
            var condition = TxtPostalCode.Text == "";
            SharedUtils.ValidateInputs(condition, LblPhone, message, ToolTip);
        }

        private void DgvAddresses_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Handle Modify
            HandleModify();
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
            if (DgvAddresses.CurrentRow == null)
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
                ModifyAddress();
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

        // Method which ends modify state and puts the form back in VIEW state */
        private void ModifyAddress()
        {
            // Save the Address to the DB
            if (!AddAddress(true))
            {
                return;
            }

            // Toggle the form state to VIEW mode
            _state = "VIEW";

            // Toggle necessary form changes
            BtnAddAddress.Enabled = true;
            BtnModifyAddress.Text = "Modify Address";
            ToggleDataEntryFields(false);

            // Exit
            return;
        }

        /* Method which changes the form state to modify mode to allow data entry */

        private void StartModify()
        {
            // Setup necessary variables
            var addressId = Convert.ToInt32(TxtAddressId.Text);
            var used = _scheduler.Customers.FirstOrDefault(r => r.AddressId == addressId);

            // Detect if address is in use in customer records
            if (used != null)
            {
                // Warn and exit
                const string MESSAGE = "This address is in use in one or more customer records and cannot be modified.";
                MessageBox.Show(MESSAGE);
                return;
            }

            // Toggle the form state to MODIFY MODE
            _state = "MODIFY";

            // Toggle necessary form changes
            BtnModifyAddress.Text = "Save Modifications";
            BtnDeleteAddress.Text = "Cancel Modifications";
            BtnAddAddress.Enabled = false;
            DtpLastUpdate.Value = DateTime.Now;
            TxtLastUpdateBy.Text = _currentUser;
            ToggleDataEntryFields(true);

            // Exit
            return;
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

        /* Method which deletes a record */

        private void FinishDelete()
        {
            // Create necessary variables
            var address = (Address)DgvAddresses.CurrentRow.DataBoundItem;
            var addressId = address.AddressId;
            var inUse = _scheduler.Customers.FirstOrDefault(r => r.AddressId == addressId);

            // If the address attempting to be deleted is in use
            if (inUse != null)
            {
                // Throw a warning, prevent action
                const string MESSAGE = "You cannot delete addresses that are used in customer records.";
                MessageBox.Show(MESSAGE);
                return;
            }
            // Open a yes/no dialog to confirm delete
            var message = $"Are you sure you wish to delete Address Id {addressId}?";
            var title = $"Delete Address Id {addressId}?";
            var response = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

            // If the user clicks yes - they want to delete the record
            if (response == DialogResult.Yes)
            {
                // Delete the record
                _scheduler.DeleteAddress(address, DgvAddresses);
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
            BtnAddAddress.Text = "Add Address";
            BtnModifyAddress.Text = "Modify Address";
            BtnDeleteAddress.Text = "Delete Address";
            BtnModifyAddress.Enabled = true;
            BtnAddAddress.Enabled = true;
            BtnDeleteAddress.Enabled = true;
            ToggleDataEntryFields(false);

            // Reload form
            PopulateInputs();
            return;
        }

        /* Method which handles Add button clicks */

        private void HandleAdd()
        {
            // If the form state is in ADD mode
            if (_state == "ADD")
            {
                //  save appointment, set state, toggle form fields, exit
                AddAddress(false);
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

        /* Method which cancels an add and places the form back into VIEW state */

        private void CancelAdd()
        {
            //  save appointment, set state, toggle form fields, reload the form
            PrepareForm("VIEW", "Add Address", "Delete Address", true);
            PopulateInputs();
            return;
        }

        /* Method which populates form inputs with data when the gridview selection changes */

        private void PopulateInputs()
        {
            // Create an address record from the currently selected row
            var address = (Address)DgvAddresses.CurrentRow.DataBoundItem;

            // Poplate the forms text boxes
            TxtAddressId.Text = address.AddressId.ToString();
            TxtAddress1.Text = address.Address1;
            TxtAddress2.Text = address.Address2;
            CboCityId.SelectedValue = Convert.ToInt32(address.CityId);
            TxtPostalCode.Text = address.PostalCode;
            TxtPhone.Text = address.Phone;
            DtpCreateDate.Value = address.CreateDate;
            TxtCreatedBy.Text = address.CreatedBy.ToString();
            DtpLastUpdate.Value = address.LastUpdate;
            TxtLastUpdateBy.Text = address.LastUpdateBy.ToString();
        }

        /* Method which saves added data and resets the form to view mode */

        private bool AddAddress(bool modify)
        {
            try
            {
                // Validate inputs / Decorate inputs with bad data
                ValidateInput();

                // Store all textbox data entry in a dictionary
                var formData = new Dictionary<string, string>
                {
                    { "AddressId", TxtAddressId.Text },
                    { "Address1", TxtAddress1.Text },
                    { "Address2", TxtAddress2.Text },
                    { "CityId", CboCityId.SelectedValue.ToString() },
                    { "PostalCode", TxtPostalCode.Text },
                    { "Phone", TxtPhone.Text },
                    { "CreateDate", DtpCreateDate.Value.ToString() },
                    { "CreatedBy", TxtCreatedBy.Text },
                    { "LastUpdate", DtpLastUpdate.Value.ToString()},
                    { "LastUpdateBy", TxtLastUpdateBy.Text }
                };

                // Create a new address using the dictionary
                var address = new Address(formData);

                // If this is an update
                if (modify)
                {
                    // Update the address
                    _scheduler.UpdateAddress(address);

                    // Reset the form to VIEW mode
                    PrepareForm("VIEW", "Add Address", "Delete Address", true);
                }
                else //If this is an add
                {
                    // Add the appointment
                    _scheduler.AddAddress(address);

                    // Reset the form to VIEW mode
                    PrepareForm("VIEW", "Add Address", "Delete Address", true);
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

        /* Method which validates text inputs for invalid data and throws exceptions to indicate problems*/

        private void ValidateInput()
        {
            // Setup regex for phone and postal code validations
            var phoneRegex = new Regex(@"^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$");
            var postalCodeRegex = new Regex(@"^[0-9]{5}(?:-[0-9]{4})?$");

            // Detect and throw any expected exceptions
            var condition = TxtAddress1.Text == "";
            var message = "Please enter a street address.";
            SharedUtils.ThrowException(condition, message);

            // Handle improper phone number entry
            condition = !phoneRegex.IsMatch(TxtPhone.Text);
            message = "Please enter a valid phone number.\n\nAppropriate style examples would be:\n\n123-456-7890\n(123)456-7890\n123 456 7890\n123.456.7890\n+ 91(123) 456-7890\n1234567890";
            SharedUtils.ThrowException(condition, message);

            // Handle improper postal code entry
            condition = !postalCodeRegex.IsMatch(TxtPostalCode.Text);
            message = "Please enter a postal code.\n\nAppropriate style examples would be:\n\n12345\n12345-6789";
            SharedUtils.ThrowException(condition, message);
        }

        /* Method which prepares the intial form state */

        private void PrepareForm(string state, string addButtonText, string deleteButtonText, bool modifyEnabled)
        {
            // Set form state
            _state = state;

            // If the current state is ADD
            if (state == "ADD")
            {
                var cityName = _scheduler.Cities[0].CityName;

                TxtCreatedBy.Text = _currentUser;
                CboCityId.SelectedIndex = 0;
                TxtCity.Text = cityName;
            }

            // Populate last update date
            TxtLastUpdateBy.Text = _currentUser;

            // Toggle button text and usablity
            BtnAddAddress.Text = addButtonText;
            BtnDeleteAddress.Text = deleteButtonText;
            BtnModifyAddress.Enabled = modifyEnabled;

            // Toggle data entry fields usability
            ToggleDataEntryFields(!modifyEnabled);
        }

        /* Method which toggles all form fields for data entry */

        private void ToggleDataEntryFields(bool value)
        {
            // Toggle fields used when moving in and out of MODIFY state
            TxtAddress1.Enabled = value;
            TxtAddress2.Enabled = value;
            CboCityId.Enabled = value;
            TxtPostalCode.Enabled = value;
            TxtPhone.Enabled = value;
            BtnSearch.Enabled = !value;
            TxtSearch.Enabled = !value;
            DgvAddresses.Enabled = !value;
        }

        /* Method which sets the form state to add and prepares it for data entry */

        private void StartAdd()
        {
            // Set state, save appointment, toggle form fields
            PrepareForm("ADD", "Save New Address", "Cancel New Address", false);

            // Clear data entry fields
            InitDataEntryFields();

            // Get the next recordID in sequence and set the default appointmentId using it
            var nextId = SharedUtils.GetIds(DgvAddresses).Max() + 1;
            TxtAddressId.Text = nextId.ToString();

            // Exit
            return;
        }

        /* Method which initializes all data entry fields */

        private void InitDataEntryFields()
        {
            // Clear all form fields
            var now = DateTime.Now;
            TxtAddressId.Text = "";
            TxtAddress1.Text = "";
            TxtAddress2.Text = "";
            TxtPostalCode.Text = "";
            TxtPhone.Text = "";
            DtpCreateDate.Value = now;
            DtpLastUpdate.Value = now;
        }

        private void TmrReminders_Tick(object sender, EventArgs e)
        {
            SharedUtils.ReminderCheck(_reminders, TmrReminders);
        }

        private void MnuHelp_Click(object sender, EventArgs e)
        {
            // Show help form
            var form = new FrmHelp();
            form.ShowDialog();
        }
    }
}