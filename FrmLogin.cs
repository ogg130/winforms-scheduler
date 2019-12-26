using RobertOgden.Data.Models;
using System;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace RobertOgden
{
    public partial class FrmLogin : Form
    {
        private readonly Scheduler _scheduler = new Scheduler();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            const string LOGFILE = "Login.txt";
            try
            {
                // Populate the schedule from the database
                _scheduler.Users = Repository.PopulateDefaults(new User());

                // Setup variables
                var userName = TxtUsername.Text.ToUpper();
                var password = TxtPassword.Text.ToUpper();

                // Used to check for a credentials match.
                var credentials = _scheduler.Users
                    .Where(u => (u.UserName.ToUpper() == userName)
                    && (u.Password.ToUpper() == password))
                    .ToList();

                // If a match doesnt exist
                if (!credentials.Any())
                {
                    // Clear the password field, throw an exception using the language selected in
                    // the users windows control panel settings.
                    TxtPassword.Text = "";
                    var manager = new ResourceManager(typeof(FrmLogin));
                    throw new InvalidOperationException(manager.GetString("InvalidCredentials"));
                }

                // If a match exists, the login is sucessful; write message to logs and open
                // the calendar form
                var message = $"Successful login by {TxtUsername.Text} at {DateTime.Now}\n";
                SharedUtils.WriteToLog(LOGFILE, message);
                SharedUtils.OpenForm(this, new FrmCalendar(_scheduler, credentials[0].UserId));
            }
            catch (InvalidOperationException ex)
            {
                // If an IO exception is thrown, mask it as an unsuccessful login attempt
                // and write to the logfile
                var message = $"Unsuccessful login attempt by {TxtUsername.Text} at {DateTime.Now}\n";
                SharedUtils.WriteToLog(LOGFILE, message);
                MessageBox.Show(ex.Message);
            }
        }
    }
}