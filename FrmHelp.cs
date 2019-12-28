using RobertOgden.Data.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RobertOgden
{
    public partial class FrmHelp : Form
    {
        private readonly List<string> _reminders; // Reminder data
        private readonly Scheduler _scheduler; // Scheduler data
        private Timer _timer; // Reminder timer

        public FrmHelp(List<string> reminders, Scheduler scheduler, Timer timer)
        {
            _reminders = reminders;
            _scheduler = scheduler;
            _timer = timer;

            InitializeComponent();
        }

        private void FrmHelp_Load(object sender, EventArgs e)
        {
            // Iterate over all lines in the file
            foreach (var line in System.IO.File.ReadAllLines("instructions1.txt"))
            {
                // Add each one to the second instruction block
                LstInstructions1.Items.Add(line);
            }

            // Iterate over all lines in the file
            foreach (var line in System.IO.File.ReadAllLines("instructions2.txt"))
            {
                // Add each one to the second instruction block
                LstInstructions2.Items.Add(line);
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

        private void FrmHelp_MouseMove(object sender, MouseEventArgs e)
        {
            SharedUtils.RestartTimer(_timer);
        }
    }
}