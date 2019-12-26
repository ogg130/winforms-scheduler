using System;
using System.Windows.Forms;

namespace RobertOgden
{
    public partial class FrmHelp : Form
    {
        public FrmHelp()
        {
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
    }
}