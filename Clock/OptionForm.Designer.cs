namespace Clock
{
    partial class OptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.BorderColorButton = new System.Windows.Forms.Button();
            this.HourHandColorButton = new System.Windows.Forms.Button();
            this.MinHandColorButton = new System.Windows.Forms.Button();
            this.SecHandColorButton = new System.Windows.Forms.Button();
            this.Transparency = new System.Windows.Forms.Label();
            this.Width = new System.Windows.Forms.Label();
            this.Border = new System.Windows.Forms.Label();
            this.Hour = new System.Windows.Forms.Label();
            this.Minute = new System.Windows.Forms.Label();
            this.Second = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.NumericInputSec = new System.Windows.Forms.NumericUpDown();
            this.NumericInputMin = new System.Windows.Forms.NumericUpDown();
            this.NumericInputHour = new System.Windows.Forms.NumericUpDown();
            this.NumericInputBorder = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInputSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInputMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInputHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInputBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderColorButton
            // 
            this.BorderColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BorderColorButton.Location = new System.Drawing.Point(627, 57);
            this.BorderColorButton.Name = "BorderColorButton";
            this.BorderColorButton.Size = new System.Drawing.Size(154, 21);
            this.BorderColorButton.TabIndex = 10;
            this.BorderColorButton.Text = "Select Color";
            this.BorderColorButton.UseVisualStyleBackColor = true;
            this.BorderColorButton.Click += new System.EventHandler(this.HandColorButton_Click);
            // 
            // HourHandColorButton
            // 
            this.HourHandColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HourHandColorButton.Location = new System.Drawing.Point(471, 57);
            this.HourHandColorButton.Name = "HourHandColorButton";
            this.HourHandColorButton.Size = new System.Drawing.Size(150, 21);
            this.HourHandColorButton.TabIndex = 9;
            this.HourHandColorButton.Text = "Select Color";
            this.HourHandColorButton.UseVisualStyleBackColor = true;
            this.HourHandColorButton.Click += new System.EventHandler(this.HandColorButton_Click);
            // 
            // MinHandColorButton
            // 
            this.MinHandColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinHandColorButton.Location = new System.Drawing.Point(315, 57);
            this.MinHandColorButton.Name = "MinHandColorButton";
            this.MinHandColorButton.Size = new System.Drawing.Size(150, 21);
            this.MinHandColorButton.TabIndex = 8;
            this.MinHandColorButton.Text = "Select Color";
            this.MinHandColorButton.UseVisualStyleBackColor = true;
            this.MinHandColorButton.Click += new System.EventHandler(this.HandColorButton_Click);
            // 
            // SecHandColorButton
            // 
            this.SecHandColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecHandColorButton.Location = new System.Drawing.Point(159, 57);
            this.SecHandColorButton.Name = "SecHandColorButton";
            this.SecHandColorButton.Size = new System.Drawing.Size(150, 21);
            this.SecHandColorButton.TabIndex = 7;
            this.SecHandColorButton.Text = "Select Color";
            this.SecHandColorButton.UseVisualStyleBackColor = true;
            this.SecHandColorButton.Click += new System.EventHandler(this.HandColorButton_Click);
            // 
            // Transparency
            // 
            this.Transparency.AutoSize = true;
            this.Transparency.BackColor = System.Drawing.SystemColors.Control;
            this.Transparency.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transparency.Location = new System.Drawing.Point(3, 81);
            this.Transparency.Name = "Transparency";
            this.Transparency.Size = new System.Drawing.Size(103, 22);
            this.Transparency.TabIndex = 2;
            this.Transparency.Text = "Transparency";
            this.Transparency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Width
            // 
            this.Width.BackColor = System.Drawing.SystemColors.Control;
            this.Width.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Width.Location = new System.Drawing.Point(3, 27);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(100, 23);
            this.Width.TabIndex = 0;
            this.Width.Text = "Width";
            this.Width.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Border
            // 
            this.Border.BackColor = System.Drawing.SystemColors.Control;
            this.Border.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Border.Location = new System.Drawing.Point(627, 0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(100, 23);
            this.Border.TabIndex = 6;
            this.Border.Text = "Border";
            this.Border.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hour
            // 
            this.Hour.BackColor = System.Drawing.SystemColors.Control;
            this.Hour.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hour.Location = new System.Drawing.Point(471, 0);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(100, 23);
            this.Hour.TabIndex = 5;
            this.Hour.Text = "Hour";
            this.Hour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Minute
            // 
            this.Minute.BackColor = System.Drawing.SystemColors.Control;
            this.Minute.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minute.Location = new System.Drawing.Point(315, 0);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(100, 23);
            this.Minute.TabIndex = 4;
            this.Minute.Text = "Minute";
            this.Minute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Second
            // 
            this.Second.BackColor = System.Drawing.SystemColors.Control;
            this.Second.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Second.Location = new System.Drawing.Point(159, 0);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(100, 23);
            this.Second.TabIndex = 3;
            this.Second.Text = "Second";
            this.Second.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Color
            // 
            this.Color.BackColor = System.Drawing.SystemColors.Control;
            this.Color.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color.Location = new System.Drawing.Point(3, 54);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(100, 23);
            this.Color.TabIndex = 1;
            this.Color.Text = "Color";
            this.Color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Color, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Second, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Minute, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Hour, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Border, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Width, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Transparency, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SecHandColorButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.MinHandColorButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.HourHandColorButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.BorderColorButton, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.NumericInputSec, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.NumericInputMin, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.NumericInputHour, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.NumericInputBorder, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.trackBar1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 111);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // NumericInputSec
            // 
            this.NumericInputSec.DecimalPlaces = 1;
            this.NumericInputSec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumericInputSec.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericInputSec.Location = new System.Drawing.Point(159, 30);
            this.NumericInputSec.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericInputSec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericInputSec.Name = "NumericInputSec";
            this.NumericInputSec.Size = new System.Drawing.Size(150, 20);
            this.NumericInputSec.TabIndex = 11;
            this.NumericInputSec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericInputSec.ValueChanged += new System.EventHandler(this.NumericInput_ValueChanged);
            // 
            // NumericInputMin
            // 
            this.NumericInputMin.DecimalPlaces = 1;
            this.NumericInputMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumericInputMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericInputMin.Location = new System.Drawing.Point(315, 30);
            this.NumericInputMin.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericInputMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericInputMin.Name = "NumericInputMin";
            this.NumericInputMin.Size = new System.Drawing.Size(150, 20);
            this.NumericInputMin.TabIndex = 12;
            this.NumericInputMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericInputMin.ValueChanged += new System.EventHandler(this.NumericInput_ValueChanged);
            // 
            // NumericInputHour
            // 
            this.NumericInputHour.DecimalPlaces = 1;
            this.NumericInputHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumericInputHour.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericInputHour.Location = new System.Drawing.Point(471, 30);
            this.NumericInputHour.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericInputHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericInputHour.Name = "NumericInputHour";
            this.NumericInputHour.Size = new System.Drawing.Size(150, 20);
            this.NumericInputHour.TabIndex = 13;
            this.NumericInputHour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericInputHour.ValueChanged += new System.EventHandler(this.NumericInput_ValueChanged);
            // 
            // NumericInputBorder
            // 
            this.NumericInputBorder.DecimalPlaces = 1;
            this.NumericInputBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumericInputBorder.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericInputBorder.Location = new System.Drawing.Point(627, 30);
            this.NumericInputBorder.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericInputBorder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericInputBorder.Name = "NumericInputBorder";
            this.NumericInputBorder.Size = new System.Drawing.Size(154, 20);
            this.NumericInputBorder.TabIndex = 14;
            this.NumericInputBorder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericInputBorder.ValueChanged += new System.EventHandler(this.NumericInput_ValueChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(159, 84);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(150, 24);
            this.trackBar1.TabIndex = 15;
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 111);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OptionForm";
            this.Text = "OptionForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInputSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInputMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInputHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericInputBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button BorderColorButton;
        private System.Windows.Forms.Button HourHandColorButton;
        private System.Windows.Forms.Button MinHandColorButton;
        private System.Windows.Forms.Button SecHandColorButton;
        private System.Windows.Forms.Label Transparency;
        private System.Windows.Forms.Label Width;
        private System.Windows.Forms.Label Border;
        private System.Windows.Forms.Label Hour;
        private System.Windows.Forms.Label Minute;
        private System.Windows.Forms.Label Second;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown NumericInputSec;
        private System.Windows.Forms.NumericUpDown NumericInputMin;
        private System.Windows.Forms.NumericUpDown NumericInputHour;
        private System.Windows.Forms.NumericUpDown NumericInputBorder;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}