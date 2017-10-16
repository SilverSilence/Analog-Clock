namespace Clock
{
    partial class Canvas
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
            this.Background = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Options = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Background.Location = new System.Drawing.Point(0, 386);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(695, 23);
            this.Background.TabIndex = 0;
            this.Background.Text = "Change Background";
            this.Background.UseVisualStyleBackColor = true;
            this.Background.Click += new System.EventHandler(this.background_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "*.png | *.jpg";
            this.openFileDialog.InitialDirectory = "D:\\Bilder\\Bilder\\InternetStuff\\Backgrounds";
            // 
            // Options
            // 
            this.Options.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Options.Location = new System.Drawing.Point(0, 363);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(695, 23);
            this.Options.TabIndex = 1;
            this.Options.Text = "Options";
            this.Options.UseVisualStyleBackColor = true;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // Canvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 409);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.Background);
            this.DoubleBuffered = true;
            this.Name = "Canvas";
            this.Text = "Canvas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Background;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button Options;
    }
}

