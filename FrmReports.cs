﻿using RobertOgden.Data.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RobertOgden
{
    public partial class FrmReports : Form
    {
        private readonly Scheduler _scheduler; // Scheduler data
        private readonly List<string> _reminders; // Reminder data
        private readonly int _userId; // The currently logged in users user ID

        public FrmReports()
        {
            InitializeComponent();
        }

        public FrmReports(Scheduler scheduler, int userId, List<string> reminders)
        {
            _userId = userId;
            _scheduler = scheduler;
            _reminders = reminders;

            InitializeComponent();
            SharedUtils.RunOption1Report(DgvReportPreview, LblInstructions); // Run the default report
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

        private void MnuAddresses_Click(object sender, EventArgs e)
        {
            // Hide current form, show new form
            SharedUtils.OpenForm(this, new FrmAddresses(_scheduler, _userId, _reminders));
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

        private void RdoOption1_CheckedChanged(object sender, EventArgs e)
        {
            SharedUtils.RunOption1Report(DgvReportPreview, LblInstructions); // Run the option report
        }

        private void RdoOption2_CheckedChanged(object sender, EventArgs e)
        {
            SharedUtils.RunOption2Report(DgvReportPreview, LblInstructions); // Run the report
        }

        private void RdoOption3_CheckedChanged(object sender, EventArgs e)
        {
            SharedUtils.RunOption3Report(DgvReportPreview, LblInstructions); // Run the report
        }

        private void MnuHelp_Click(object sender, EventArgs e)
        {
            // Show help form
            var form = new FrmHelp();
            form.ShowDialog();
        }
    }
}