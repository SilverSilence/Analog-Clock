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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Width = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.Transparency = new System.Windows.Forms.Label();
            this.Second = new System.Windows.Forms.Label();
            this.Minute = new System.Windows.Forms.Label();
            this.Hour = new System.Windows.Forms.Label();
            this.Border = new System.Windows.Forms.Label();
            this.colorSecondDialog = new System.Windows.Forms.ColorDialog();
            this.colorMinuteDialog = new System.Windows.Forms.ColorDialog();
            this.colorHourDialog = new System.Windows.Forms.ColorDialog();
            this.colorBorderDialog = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.Second.Click += new System.EventHandler(this.Second_Click);
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
            this.Minute.Click += new System.EventHandler(this.label5_Click);
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
            this.Hour.Click += new System.EventHandler(this.label6_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Width;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.Label Transparency;
        private System.Windows.Forms.Label Second;
        private System.Windows.Forms.Label Minute;
        private System.Windows.Forms.Label Hour;
        private System.Windows.Forms.Label Border;
        private System.Windows.Forms.ColorDialog colorSecondDialog;
        private System.Windows.Forms.ColorDialog colorMinuteDialog;
        private System.Windows.Forms.ColorDialog colorHourDialog;
        private System.Windows.Forms.ColorDialog colorBorderDialog;
    }
}