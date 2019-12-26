using RobertOgden.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RobertOgden
{
    public partial class FrmCustomers : Form
    {
        private readonly Scheduler _scheduler;  // Scheduler data
        private readonly List<string> _reminders;  // Reminder data
        private string _state = "VIEW"; // The state of the form
        private readonly int _userId; // The currently logged in users user ID
        private readonly string _currentUser; // The currently logged in users name

        public FrmCustomers()
        {
            InitializeComponent();
        }

        public FrmCustomers(Scheduler scheduler, int userId, List<string> reminders)
        {
            // Set up gloablly used objects that are passed into the form
            _userId = userId;
            _scheduler = scheduler;
            _reminders = reminders;
            _currentUser = _scheduler.Users.FirstOrDefault(r => r.UserId == _userId).UserName;

            InitializeComponent();
            PopulateDataBoundControls(); // Populate grid and comboboxes
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            PopulateInputs(); // Populate text and date inputs
            ToggleDataEntryFields(false); // Toggle data entry field usability
        }

        private void DgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            SelectionChange(); // Process events that occur when a selection change occurs
            PopulateInputs(); // Populate input data for currently selected row
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            HandleAdd(); //Handle the users action
        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            HandleDelete(); //Handle the users action
        }

        private void BtnModifyCustomer_Click(object sender, EventArgs e)
        {
            HandleModify(); //Handle the users action
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Handle Search button click
            SharedUtils.HandleSearch(DgvCustomers, _scheduler, TxtSearch.Text);
        }

        private void CboAddressId_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validate combobox contents
            SharedUtils.ValidateCbo(CboAddressId, ToolTip, LblAddressId);

            // Set the address for the currently selected addressid
            UpdateAddress();
        }

        private void MnuAppointments_Click(object sender, EventArgs e)
        {
            // Hide current form, show new form
            SharedUtils.OpenForm(this, new FrmAppointments(_scheduler, _userId, _reminders));
        }

        private void MnuAddresses_Click(object sender, EventArgs e)
        {
            // Hide current form, show new form
            SharedUtils.OpenForm(this, new FrmAddresses(_scheduler, _userId, _reminders));
        }

        private void MnuCalendar_Click(object sender, EventArgs e)
        {
            // Hide current form, show new form
            SharedUtils.OpenForm(this, new FrmCalendar(_scheduler, _userId, _reminders));
        }

        private void MnuReports_Click(object sender, EventArgs e)
        {
            // Hide current form, show new form
            SharedUtils.OpenForm(this, new FrmReports(_scheduler, _userId, _reminders));
        }

        private void TxtCustomerName_TextChanged(object sender, EventArgs e)
        {
            // Validate field input, indicate any problems visually
            SharedUtils.ValidateText(TxtCustomerName, ToolTip, LblCustomerName);
        }

        private void TmrReminders_Tick(object sender, EventArgs e)
        {
            // Display reminder if necessary
            SharedUtils.ReminderCheck(_reminders, TmrReminders);
        }

        private void BtnLaunch_Click(object sender, EventArgs e)
        {
            // Close this screen, open the new screen
            SharedUtils.OpenForm(this, new FrmAddresses(_scheduler, _userId, _reminders));
        }

        private void BtnLaunch_MouseHover(object sender, EventArgs e)
        {
            // Hide any open tooltips, show the new tooltip
            const string MESSAGE = "Click to add/modify addresses.";
            ToolTip.Hide(BtnLaunch);
            ToolTip.Show(MESSAGE, BtnLaunch);
        }

        private void DgvAddresses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle Modify
            HandleModify();
        }

        private void DgvCustomers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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
            if (DgvCustomers.CurrentRow == null)
            {
                return; // Exit
            }
            PopulateInputs(); // Populate input data for currently selected row
        }

        // Method which ends modify state and puts the form back in VIEW state */
        private void ModifyCustomer()
        {
            // Save the customer to the DB
            if (!AddCustomer(true, DgvCustomers))
            {
                return;
            }

            // Toggle the form state to VIEW mode
            _state = "VIEW";

            // Toggle necessary form changes
            BtnAddCustomer.Enabled = true;
            BtnModifyCustomer.Text = "Modify Customer";
            ToggleDataEntryFields(false);

            // Exit
            return;
        }

        /* Method which changes the form state to modify mode to allow data entry */

        private void StartModify()
        {
            // Toggle the form state to MODIFY MODE
            _state = "MODIFY";

            // Toggle necessary form changes
            BtnModifyCustomer.Text = "Save Modifications";
            BtnDeleteCustomer.Text = "Cancel Modifications";
            BtnAddCustomer.Enabled = false;
            DtpLastUpdate.Value = DateTime.Now;
            TxtLastUpdateBy.Text = _currentUser;
            ToggleDataEntryFields(true);

            // Exit
            return;
        }

        /* Method which handles modify button click events */

        private void HandleModify()
        {
            // If the current form state is in MODIFY mode
            if (_state == "MODIFY")
            {
                // Finish(save) modification and return
                ModifyCustomer();
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

        /* Method which populates databound controls when the form is initialized */

        private void PopulateDataBoundControls()
        {
            // Init datource
            DgvCustomers.DataSource = _scheduler.Customers;

            // Init dropdown data
            // *Valuemember needs to be set prior to the next line or there is failure
            CboAddressId.ValueMember = "AddressId";
            CboAddressId.DataSource = _scheduler.Addresses;
            CboAddressId.DisplayMember = "AddressId";
        }

        /* Method which populates form inputs with data when the gridview selection changes */

        private void PopulateInputs()
        {
            var addressId = -1;
            //Create necessary variables
            var customer = (Customer)DgvCustomers.CurrentRow.DataBoundItem;
            if (CboAddressId.SelectedIndex > -1)
            {
                addressId = (int)CboAddressId.SelectedValue;
                var cityId = _scheduler.Addresses.FirstOrDefault(c => c.AddressId == addressId).CityId;
                TxtCity.Text = _scheduler.Cities.FirstOrDefault(c => c.CityId == cityId).CityName.ToString();
                TxtAddress1.Text = _scheduler.Addresses.FirstOrDefault(c => c.AddressId == addressId).Address1.ToString();
                TxtAddress2.Text = _scheduler.Addresses.FirstOrDefault(c => c.AddressId == addressId).Address2.ToString();
                TxtPostalCode.Text = _scheduler.Addresses.FirstOrDefault(c => c.AddressId == addressId).PostalCode.ToString();
                TxtPhone.Text = _scheduler.Addresses.FirstOrDefault(c => c.AddressId == addressId).Phone.ToString();
            }
            // Poplate the forms data entry elements
            TxtCustomerId.Text = customer.CustomerId.ToString();
            TxtCustomerName.Text = SharedUtils.UpdateName(TxtCustomerId, _scheduler.Customers);

            ChkActive.Checked = customer.Active;
            CboAddressId.SelectedValue = customer.AddressId;
            DtpCreateDate.Value = customer.CreateDate;
            TxtCreatedBy.Text = customer.CreatedBy.ToString();
            DtpLastUpdate.Value = customer.LastUpdate;
            TxtLastUpdateBy.Text = customer.LastUpdateBy.ToString();
        }

        /* Method which toggles all form fields for data entry */

        private void ToggleDataEntryFields(bool value)
        {
            // Toggle fields used when moving in and out of MODIFY state
            TxtCustomerName.Enabled = value;
            ChkActive.Enabled = value;
            CboAddressId.Enabled = value;
            BtnSearch.Enabled = !value;
            TxtSearch.Enabled = !value;
            TxtSearch.Enabled = !value;
            BtnLaunch.Enabled = !value;
            DgvCustomers.Enabled = !value;
        }

        /* Method which handles Add button clicks */

        private void HandleAdd()
        {
            // If the form state is in ADD mode
            if (_state == "ADD")
            {
                //  save customer, set state, toggle form fields, exit
                AddCustomer(false, DgvCustomers);
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

        /* Method which sets the form state to add and prepares it for data entry */

        private void StartAdd()
        {
            // Set state, save record, toggle form fields
            PrepareForm("ADD", "Save New Customer", "Cancel New Customer", false);

            // Clear data entry fields
            InitDataEntryFields();

            //Get the next recordID in sequence and set the default recordId using it
            var nextId = SharedUtils.GetIds(DgvCustomers).Max() + 1;
            TxtCustomerId.Text = nextId.ToString();

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
            // Create a part using the selected grid item
            var customer = (Customer)DgvCustomers.CurrentRow.DataBoundItem;
            var customerId = customer.CustomerId;
            var inUse = _scheduler.Customers.FirstOrDefault(r => r.CustomerId == customerId);

            // If the address attempting to be deleted is in use
            if (inUse != null)
            {
                // Throw a warning, prevent action
                const string MESSAGE = "You cannot delete customers that are in use in other records.";
                MessageBox.Show(MESSAGE);
                return;
            }
            // Open a yes/no dialog to confirm delete
            var message = $"Are you sure you wish to delete Customer Id {customerId}?";
            var title = $"Delete Customer Id {customerId}?";
            var response = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
            {
                // Delete if confirmed
                _scheduler.DeleteCustomer(customer, DgvCustomers);
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
            BtnAddCustomer.Text = "Add Customer";
            BtnModifyCustomer.Text = "Modify Customer";
            BtnDeleteCustomer.Text = "Delete Customer";
            BtnModifyCustomer.Enabled = true;
            BtnAddCustomer.Enabled = true;
            BtnDeleteCustomer.Enabled = true;
            ToggleDataEntryFields(false);

            // Reload form
            PopulateInputs();
            return;
        }

        /* Method which cancels an add and places the form back into VIEW state */

        private void CancelAdd()
        {
            //  save customer, set state, toggle form fields, reload the form
            PrepareForm("VIEW", "Add Customer", "Delete Customer", true);
            PopulateInputs();
            return;
        }

        /* Method which saves added data and resets the form to view mode */

        private bool AddCustomer(bool modify, DataGridView grid)
        {
            try
            {
                // Validate inputs / Decorate inputs with bad data
                ValidateInput();

                // Store all customer data entry in a dictionary
                var customerData = new Dictionary<string, string>
                {
                    { "CustomerId", TxtCustomerId.Text },
                    { "Active", ChkActive.Checked.ToString() },
                    { "CustomerName", TxtCustomerName.Text },
                    { "AddressId", CboAddressId.SelectedValue.ToString()},
                    { "CreateDate", DtpCreateDate.Value.ToString() },
                    { "CreatedBy", TxtCreatedBy.Text },
                    { "LastUpdate", DtpLastUpdate.Value.ToString()},
                    { "LastUpdateBy", TxtLastUpdateBy.Text }
                };

                // Create a new customer using the dictionary
                var customer = new Customer(customerData);

                // If this is an update
                if (modify)
                {
                    // Update the customer
                    _scheduler.UpdateCustomer(customer, DgvCustomers);
                }
                else //If this is an add
                {
                    // Add the customer
                    _scheduler.AddCustomer(customer, DgvCustomers);

                    // Reset the form to VIEW mode
                    PrepareForm("VIEW", "Add Customer", "Delete Customer", true);

                    // Select the first record in the grid
                    DgvCustomers.Rows[0].Selected = true;
                    DgvCustomers.CurrentCell = DgvCustomers.Rows[0].Cells[3];
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
            // Handle missing customer name
            var condition = TxtCustomerName.Text == "";
            var message = "A customer must have a name.";
            SharedUtils.ThrowException(condition, message);

            // Handle missing address ID
            condition = CboAddressId.SelectedIndex == -1;
            message = "A customer must have an address.";
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
                // Populate related controls
                TxtCreatedBy.Text = _currentUser;
            }

            // Populate last update using txtUsernames text
            TxtLastUpdateBy.Text = _currentUser;

            // Toggle button text and usablity
            BtnAddCustomer.Text = addButtonText;
            BtnDeleteCustomer.Text = deleteButtonText;
            BtnModifyCustomer.Enabled = modifyEnabled;

            // Toggle data entry fields usability
            ToggleDataEntryFields(!modifyEnabled);
        }

        // Method which initialized data entry fields
        private void InitDataEntryFields()
        {
            // Clear all form fields
            TxtCustomerName.Text = "";
            TxtAddress1.Text = "";
            TxtAddress2.Text = "";
            TxtCity.Text = "";
            TxtPostalCode.Text = "";
            TxtPhone.Text = "";
            ChkActive.Checked = false;
            DtpCreateDate.Value = DateTime.Now;
            DtpLastUpdate.Value = DateTime.Now;
            CboAddressId.SelectedIndex = -1;
        }

        /* Method which updates a customer or username based on the customer or user ID combobox value */

        private void UpdateAddress()
        {
            // Store combobox ins a variable to check for empty
            var cbo = CboAddressId;

            // If combobox is empty
            if (cbo.SelectedValue == null)
            {
                // Exit
                return;
            }

            // Setup necessary variables
            var addresses = _scheduler.Addresses;
            var cities = _scheduler.Cities;
            var addressId = (int)CboAddressId.SelectedValue;
            var address = addresses.FirstOrDefault(u => u.AddressId == addressId);
            var cityId = address.CityId;
            var cityName = cities.FirstOrDefault(u => u.CityId == cityId).CityName;

            // Update address fields
            TxtAddress1.Text = address.Address1;
            TxtAddress2.Text = address.Address2;
            TxtCity.Text = cityName;
            TxtPostalCode.Text = address.PostalCode;
            TxtPhone.Text = address.Phone;
        }

        private void MnuHelp_Click(object sender, EventArgs e)
        {
            // Show help form
            var form = new FrmHelp();
            form.ShowDialog();
        }
    }
}