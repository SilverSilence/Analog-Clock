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

            //Load Settings into boxes
            NumericInputBorder.Value = (decimal) Properties.Settings.Default.BorderWidth;
            NumericInputSec.Value = (decimal) Properties.Settings.Default.SecWidth;
            NumericInputMin.Value = (decimal) Properties.Settings.Default.MinWidth;
            NumericInputHour.Value = (decimal) Properties.Settings.Default.HourWidth;

            TransparencyBar.Value = Properties.Settings.Default.Transparency;
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

        private void NumericInput_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nIn = (NumericUpDown)sender;
            string name = nIn.Name.Replace("NumericInput", "");
            name += "Width";
            Properties.Settings.Default[name] = (float) nIn.Value;
            Properties.Settings.Default.Save();
        }

        private void TransparencyBar_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Transparency = TransparencyBar.Value;
            Color someColor;
            int secColor =  Properties.Settings.Default.SecHandColor;
            int minColor =  Properties.Settings.Default.MinHandColor;
            int hourColor = Properties.Settings.Default.HourHandColor;
            int borderColor = Properties.Settings.Default.BorderColor;

            int transparency = Properties.Settings.Default.Transparency;
            //Sec Color
            someColor = System.Drawing.Color.FromArgb(secColor);
            someColor = System.Drawing.Color.FromArgb(transparency, someColor);
            Properties.Settings.Default.SecHandColor = someColor.ToArgb();
            //Min Color
            someColor = System.Drawing.Color.FromArgb(minColor);
            someColor = System.Drawing.Color.FromArgb(transparency, someColor);
            Properties.Settings.Default.MinHandColor = someColor.ToArgb();
            //Hour Color
            someColor = System.Drawing.Color.FromArgb(hourColor);
            someColor = System.Drawing.Color.FromArgb(transparency, someColor);
            Properties.Settings.Default.HourHandColor = someColor.ToArgb();
            //Border Color
            someColor = System.Drawing.Color.FromArgb(borderColor);
            someColor = System.Drawing.Color.FromArgb(transparency, someColor);
            Properties.Settings.Default.BorderColor = someColor.ToArgb();
            //Save
            Properties.Settings.Default.Save();
        }
    }
}
