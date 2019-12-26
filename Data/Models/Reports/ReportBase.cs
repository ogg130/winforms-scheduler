using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;

using System.Windows.Forms;

namespace RobertOgden.Data.Models.Reports
{
    internal abstract class ReportBase
    {
        // Method which returns the data form one of three different reports */
        public void GetReport<T>(T report, DataGridView grid)
        {
            try
            {
                var dataTable = Repository.ReadReport(report);

                // Fill a new Bindinglist of whatever type is passed into the method and populate it
                var records = new BindingList<T>();

                // Iterate over the sql queries results
                for (var i = 0; i < dataTable.Rows.Count; ++i)
                {
                    // Add new record
                    records.Add((T)Activator.CreateInstance(typeof(T), new object[] { dataTable.Rows[i] }));
                }
                grid.DataSource = records;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}