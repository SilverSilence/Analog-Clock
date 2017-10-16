using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
        }

        //Reusing Handler for all button. Distinguishing by sender.
        //Note: Might be more elegant to make a subclass of the button?
        private void HandColorButton_Click(object sender, EventArgs e)
        {
            //Get sender
            Button button = (Button) sender;

            DialogResult result = colorDialog.ShowDialog();

            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                //Identify which handle has been selected (relies on proper naming... not that elegant?)
                string handleName = button.Name.Replace("Button","");

                //Save Color in Settings. Will be loaded on next Refresh
                Properties.Settings.Default[handleName] = colorDialog.Color.ToArgb();
                Properties.Settings.Default.Save();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NumericInput_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nIn = (NumericUpDown)sender;
            string name = nIn.Name.Replace("NumericInput", "");
            name += "Width";
            Properties.Settings.Default[name] = (float) nIn.Value;
            Properties.Settings.Default.Save();
        }
    }
}
