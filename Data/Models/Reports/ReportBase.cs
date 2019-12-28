using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;

using System.Windows.Forms;

namespace RobertOgden.Data.Models.Reports
{
    internal abstract class ReportBase
    {
        // Method which returns the data form one of three different reports */
        public BindingList<T> ToBindingList<T>(DataGridView grid)
        {
            // Fill a new Bindinglist of whatever type is passed into the method and populate it
            var records = new BindingList<T>();
            try
            {
                var dataTable = Repository.ReadReport(this);

                // Iterate over the sql queries results
                for (var i = 0; i < dataTable.Rows.Count; ++i)
                {
                    // Add new record
                    records.Add((T)Activator.CreateInstance(typeof(T), new object[] { dataTable.Rows[i] }));
                }
                grid.DataSource = records;
                return records;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return records;
            }
        }
    }
}