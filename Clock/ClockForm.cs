using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace Clock
{
    public partial class Canvas : Form
    {
        //Circle Variables
        private int radius = 100;
        private int diameter;
        private Point centerPoint;

        //Hand Variables
        private float secondsL = 0.9f, minutesL = 0.8f, hoursL = 0.3f;
        double[] coordinates;

        //Time variables
        private int seconds, minutes, hours;

        //Timer
        private Timer timer = new Timer();

        //Drawing Tools
        Pen myPen;
        Graphics myGraphic;
        Brush myBrush;

        public Canvas()
        {
            InitializeComponent();

            BackgroundImageLayout = ImageLayout.Stretch;
            
            //Init array
            coordinates = new double[2];
            
            //Set diamater and init indicators
            diameter = 2 * radius;
            secondsL *= radius;
            minutesL *= radius;
            hoursL   *= radius;

            //Init timer
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += new EventHandler(Timer_Tick);

            Update_Time();
        }



        private void background_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileToOpen = openFileDialog.FileName;

                System.IO.FileInfo File = new System.IO.FileInfo(openFileDialog.FileName);
                BackgroundImage = Image.FromFile(openFileDialog.FileName);

            }
        }

        private void Options_Click(object sender, EventArgs e)
        {
            OptionForm optionForm = new OptionForm();

            optionForm.Show();
        }

        private void Update_Time()
        {
            //Get Start Time
            DateTime time = DateTime.Now;
            seconds = time.Second;
            minutes = time.Minute;
            hours = time.Hour % 12;
        }

        private void Compute_Hand_Coordinates(int degrees, float hand_length)
        {
            double newX;
            double newY;

            //Convert degrees to radians
            double radian = degrees * Math.PI / 180;
            
            //Compute new coordinates
            if (degrees >= 0 && degrees <= 180)
            {
                newX = centerPoint.X + (hand_length * Math.Sin(radian));
                newY = centerPoint.Y - (hand_length * Math.Cos(radian));
            }
            else
            {
                newX = centerPoint.X - (hand_length * -Math.Sin(radian));
                newY = centerPoint.Y - (hand_length * Math.Cos(radian));
            }
            //Store
            coordinates[0] = newX;
            coordinates[1] = newY;
        }

        private void Draw_Hands()
        {
            //Draw Second Hand - Each second = 6 degrees (same for minute)
            int degrees = seconds * 6;
            
            //Compute coordinates
            Compute_Hand_Coordinates(degrees, secondsL);

            //Set Color & Brush Width
            myPen.Color = Color.FromArgb(Properties.Settings.Default.SecHandColor);
            myPen.Width = Properties.Settings.Default.SecWidth;
            
            //Draw Second Hand
            myGraphic.DrawLine(myPen, centerPoint.X, centerPoint.Y, (float)coordinates[0], (float)coordinates[1]);

            //Draw Minute Hand the same way
            degrees = minutes * 6;
            Compute_Hand_Coordinates(degrees, minutesL);
            myPen.Color = Color.FromArgb(Properties.Settings.Default.MinHandColor);
            myPen.Width = Properties.Settings.Default.MinWidth;
            myGraphic.DrawLine(myPen, centerPoint.X, centerPoint.Y, (float)coordinates[0], (float)coordinates[1]);

            //Draw Hour Hand - Each hour = 30 degrees
            degrees = (hours % 12) * 30;
            Compute_Hand_Coordinates(degrees, hoursL);
            myPen.Color = Color.FromArgb(Properties.Settings.Default.HourHandColor);
            myPen.Width = Properties.Settings.Default.HourWidth;
            myGraphic.DrawLine(myPen, centerPoint.X, centerPoint.Y, (float)coordinates[0], (float)coordinates[1]);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Update_Time();
            this.Refresh();

            //Create Utilities
            myPen = new Pen(Color.FromArgb(Properties.Settings.Default.BorderColor));
            myGraphic = this.CreateGraphics();
            myPen.Width = Properties.Settings.Default.BorderWidth;

            //Center Point of Form (updated because of resizes)
            centerPoint = new Point(this.ClientRectangle.Width / 2, this.ClientRectangle.Height / 2);

            //Draw Circle
            myGraphic.DrawEllipse(myPen, new Rectangle(centerPoint.X - radius, centerPoint.Y - radius, diameter, diameter));

            //Draw Hands
            Draw_Hands();

            //Draw small center Circle
            myBrush = new SolidBrush(Color.FromArgb(Properties.Settings.Default.BorderColor));
            myGraphic.FillEllipse(myBrush, new Rectangle(centerPoint.X - 5, centerPoint.Y - 5, 10, 10));

            //Dispose of Tools
            myGraphic.Dispose();
            myPen.Dispose();
        }
    }
}
