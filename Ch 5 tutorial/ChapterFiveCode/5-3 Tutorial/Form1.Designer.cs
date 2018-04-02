namespace _5_3_Tutorial
{
    partial class Form1
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
            this.SpeedListBox = new System.Windows.Forms.ListBox();
            this.DisplaySpeedButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SpeedListBox
            // 
            this.SpeedListBox.FormattingEnabled = true;
            this.SpeedListBox.Location = new System.Drawing.Point(114, 21);
            this.SpeedListBox.Name = "SpeedListBox";
            this.SpeedListBox.Size = new System.Drawing.Size(304, 212);
            this.SpeedListBox.TabIndex = 0;
            // 
            // DisplaySpeedButton
            // 
            this.DisplaySpeedButton.Location = new System.Drawing.Point(114, 298);
            this.DisplaySpeedButton.Name = "DisplaySpeedButton";
            this.DisplaySpeedButton.Size = new System.Drawing.Size(84, 23);
            this.DisplaySpeedButton.TabIndex = 1;
            this.DisplaySpeedButton.Text = "DisplaySpeed";
            this.DisplaySpeedButton.UseVisualStyleBackColor = true;
            this.DisplaySpeedButton.Click += new System.EventHandler(this.DisplaySpeedButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(343, 298);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 365);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DisplaySpeedButton);
            this.Controls.Add(this.SpeedListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SpeedListBox;
        private System.Windows.Forms.Button DisplaySpeedButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

