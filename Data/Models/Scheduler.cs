using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace RobertOgden.Data.Models
{
    public class Scheduler
    {
        // Appointment data
        public BindingList<Appointment> Appointments { get; set; }

        // Country data
        public BindingList<Country> Countries { get; set; }

        // City data
        public BindingList<City> Cities { get; set; }

        // Address data
        public BindingList<Address> Addresses { get; set; }

        // Customer data
        public BindingList<Customer> Customers { get; set; }

        // User data
        public BindingList<User> Users { get; set; }

        public void UpdateAppointment(Appointment appointment, DataGridView grid)
        {
            try
            {
                Repository.UpdateAppointment(appointment);

                // Setup variables necessary to update the appointments gridview
                var target = this.Appointments.FirstOrDefault(a => a.CustomerId == appointment.CustomerId);
                var index = this.Appointments.IndexOf(target);

                // Update the appointments object
                if (index != -1)
                {
                    this.Appointments[index] = appointment;
                }

                // Refresh the gridview
                grid.DataSource = typeof(BindingList<Appointment>);
                grid.DataSource = this.Appointments;

                // Hide unnecessary columns
                var hiddenColumns = new List<int> { 0, 1, 2, 5, 6, 7, 8 };
                SharedUtils.HideColumns(grid, hiddenColumns);
            }
            catch (MySqlException ex)
            {
                // Display any caught SQL errors
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateAddress(Address address)
        {
            try
            {
                Repository.UpdateAddress(address);

                // Setup variables necessary to update the addresss gridview
                var target = this.Addresses.FirstOrDefault(a => a.AddressId == address.AddressId);
                var index = this.Addresses.IndexOf(target);

                // Update the addresss object
                if (index != -1)
                {
                    this.Addresses[index] = address;
                }
            }
            catch (MySqlException ex)
            {
                // Display any caught SQL errors
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateCustomer(Customer customer, DataGridView grid)
        {
            try
            {
                Repository.UpdateCustomer(customer);

                // Setup variables necessary to update the gridview
                var target = this.Customers.FirstOrDefault(a => a.CustomerId == customer.CustomerId);
                var index = this.Customers.IndexOf(target);

                // Update the object
                if (index != -1)
                {
                    this.Customers[index] = customer;
                }

                // Refresh the gridview
                grid.DataSource = typeof(BindingList<Customer>);
                grid.DataSource = this.Customers;
            }
            catch (MySqlException ex)
            {
                // Display any caught SQL errors
                MessageBox.Show(ex.Message);
            }
        }

        public void AddAppointment(Appointment appointment, DataGridView grid)
        {
            try
            {
                Repository.CreateAppointment(appointment);

                // Update the appointments object and the appointments gridview
                this.Appointments.Add(appointment);
                grid.DataSource = typeof(BindingList<Appointment>);
                grid.DataSource = this.Appointments;

                // Hide unnecessary columns
                var hiddenColumns = new List<int> { 0, 1, 2, 5, 6, 7, 8 };
                SharedUtils.HideColumns(grid, hiddenColumns);
            }
            catch (MySqlException ex)
            {
                // Display any cought SQL errors
                MessageBox.Show(ex.Message);
            }
        }

        public void AddCustomer(Customer customer, DataGridView grid)
        {
            try
            {
                // Create add open the connection
                Repository.CreateCustomer(customer);

                // Update the appointments object and the gridview
                this.Customers.Add(customer);
                grid.DataSource = typeof(BindingList<Customer>);
                grid.DataSource = this.Customers;
            }
            catch (MySqlException ex)
            {
                // Display any cought SQL errors
                MessageBox.Show(ex.Message);
            }
        }

        public void AddAddress(Address address)
        {
            try
            {
                Repository.CreateAddress(address);

                // Update the appointments object and the gridview
                this.Addresses.Add(address);
            }
            catch (MySqlException ex)
            {
                // Display any cought SQL errors
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteAppointment(Appointment source, DataGridView grid)
        {
            try
            {
                Repository.DeleteAppointment(source);

                // REmove the appointmnet and update the appointmets gridview
                this.Appointments.Remove(source);
                grid.DataSource = typeof(BindingList<Appointment>);
                grid.DataSource = this.Appointments;

                SharedUtils.HideColumns(grid, new List<int> { 0, 1, 2, 5, 6, 7, 8 });
            }
            catch (MySqlException ex)
            {
                // Throw any cought SQL errors
                MessageBox.Show(ex.Message);
            }
        }

        // Method which deletes a customer
        public void DeleteCustomer(Customer source, DataGridView grid)
        {
            try
            {
                Repository.DeleteCustomer(source);

                // Remove the record and update the gridview
                this.Customers.Remove(source);
                grid.DataSource = typeof(BindingList<Customer>);
                grid.DataSource = this.Customers;
            }
            catch (MySqlException ex)
            {
                // Throw any cought SQL errors
                MessageBox.Show(ex.Message);
            }
        }

        // Method which deletes a customer
        public void DeleteAddress(Address source, DataGridView grid)
        {
            try
            {
                Repository.DeleteAddress(source);

                // Remove the record and update the gridview
                this.Addresses.Remove(source);
                grid.DataSource = typeof(BindingList<Address>);
                grid.DataSource = this.Addresses;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* Method which returns an appointment given an appointmentId */

        public Appointment LookupAppointment(int appointmentId)
        {
            // Exectute a select * against the table name based on the name of the object passed into the function
            var results = Repository.PopulateAppointments();

            // If the select returns no results
            var appointment = results.FirstOrDefault(r => r.AppointmentId == appointmentId);
            if (appointment == null)
            {
                // exit
                return null; // Failure - return null
            }

            // Return the appoinment
            return appointment;
        }

        /* Method which returns an customer given an customerId */

        public Customer LookupCustomer(int customerId)
        {
            // Exectute a select * against the table name based on the name of the object passed into the function
            var results = Repository.PopulateDefaults(new Customer());

            // If the select returns no results
            var customer = results.FirstOrDefault(r => r.CustomerId == customerId);
            if (customer == null)
            {
                // exit
                return null; // Failure - return null
            }

            // Return the customer
            return customer;
        }

        public Address LookupAddress(int addressId)
        {
            // Exectute a select * against the table name based on the name of the object passed into the function
            var results = Repository.PopulateDefaults(new Address());

            // If the select returns no results
            var customer = results.FirstOrDefault(r => r.AddressId == addressId);
            if (customer == null)
            {
                // exit
                return null; // Failure - return null
            }

            // Return the customer
            return customer;
        }
    }
}